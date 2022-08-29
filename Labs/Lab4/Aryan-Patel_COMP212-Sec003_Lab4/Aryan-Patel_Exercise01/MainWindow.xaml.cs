﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Aryan_Patel_Exercise01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int diameter = (int)Sizes.MEDIUM; // diameter of circle
        private Brush brushColor = Brushes.Red; // drawing color
        private bool shouldErase = false; // specify whether to erase
        private bool shouldPaint = false; // specify whether to paint

        private enum Sizes // size constants for diameter of the circle
        {
            SMALL = 4,
            MEDIUM = 8,
            LARGE = 12
        } // end enum Sizes

        // constructor
        public MainWindow()
        {
            InitializeComponent();
        } // end constructor

        // paints a circle on the Canvas
        private void PaintCircle(Brush circleColor, Point position)
        {
            Ellipse newEllipse = new Ellipse(); // create an Ellipse   

            newEllipse.Fill = circleColor; // set Ellipse's color      
            newEllipse.Width = diameter; // set its horizontal diameter
            newEllipse.Height = diameter; // set its vertical diameter 

            // set the Ellipse's position            
            Canvas.SetTop(newEllipse, position.Y);
            Canvas.SetLeft(newEllipse, position.X);

            paintCanvas.Children.Add(newEllipse);
        } // end method PaintCircle

        // handles paintCanvas's MouseLeftButtonDown event
        private void paintCanvas_MouseLeftButtonDown(object sender,
           MouseButtonEventArgs e)
        {
            shouldPaint = true; // OK to draw on the Canvas
        } // end method paintCanvas_MouseLeftButtonDown

        // handles paintCanvas's MouseLeftButtonUp event
        private void paintCanvas_MouseLeftButtonUp(object sender,
           MouseButtonEventArgs e)
        {
            shouldPaint = false; // do not draw on the Canvas
        } // end method paintCanvas_MouseLeftButtonUp

        // handles paintCanvas's MouseRightButtonDown event
        private void paintCanvas_MouseRightButtonDown(object sender,
           MouseButtonEventArgs e)
        {
            shouldErase = true; // OK to erase the Canvas
        } // end method paintCanvas_MouseRightButtonDown

        // handles paintCanvas's MouseRightButtonUp event
        private void paintCanvas_MouseRightButtonUp(object sender,
           MouseButtonEventArgs e)
        {
            shouldErase = false; // do not erase the Canvas
        } // end method paintCanvas_MouseRightButtonUp

        // handles paintCanvas's MouseMove event
        private void paintCanvas_MouseMove(object sender,
           MouseEventArgs e)
        {
            if (shouldPaint)
            {
                // draw a circle of selected color at current mouse position
                Point mousePosition = e.GetPosition(paintCanvas);
                PaintCircle(brushColor, mousePosition);
            } // end if
            else if (shouldErase)
            {
                // erase by drawing circles of the Canvas's background color
                Point mousePosition = e.GetPosition(paintCanvas);
                PaintCircle(paintCanvas.Background, mousePosition);
            } // end else if
        } // end method paintCanvas_MouseMove

        // handles Red RadioButton's Checked event
        private void redRadioButton_Checked(object sender,
           RoutedEventArgs e)
        {
            brushColor = Brushes.Red;
        } // end method redRadioButton_Checked

        // handles Blue RadioButton's Checked event
        private void blueRadioButton_Checked(object sender,
           RoutedEventArgs e)
        {
            brushColor = Brushes.Blue;
        } // end method blueRadioButton_Checked

        // handles Green RadioButton's Checked event
        private void greenRadioButton_Checked(object sender,
           RoutedEventArgs e)
        {
            brushColor = Brushes.Green;
        } // end method greenRadioButton_Checked

        // handles Black RadioButton's Checked event
        private void blackRadioButton_Checked(object sender,
           RoutedEventArgs e)
        {
            brushColor = Brushes.Black;
        } // end method blackRadioButton_Checked

        // handles Small RadioButton's Checked event
        private void smallRadioButton_Checked(object sender,
           RoutedEventArgs e)
        {
            diameter = (int)Sizes.SMALL;
        } // end method smallRadioButton_Checked

        // handles Medium RadioButton's Checked event
        private void mediumRadioButton_Checked(object sender,
           RoutedEventArgs e)
        {
            diameter = (int)Sizes.MEDIUM;
        } // end method mediumRadioButton_Checked

        // handles Large RadioButton's Checked event
        private void largeRadioButton_Checked(object sender,
           RoutedEventArgs e)
        {
            diameter = (int)Sizes.LARGE;
        } // end method largeRadioButton_Checked

        // handles Undo Button's Click event
        private void undoButton_Click(object sender, RoutedEventArgs e)
        {
            int count = paintCanvas.Children.Count;

            // if there are any shapes on Canvas remove the last one added
            if (count > 0)
                paintCanvas.Children.RemoveAt(count - 1);
        } // end method undoButton_Click

        // handles Clear Button's Click event
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            paintCanvas.Children.Clear(); // clear the canvas
        } // end method clearButton_Click

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        } // end method exitButton_Click
    }
}
