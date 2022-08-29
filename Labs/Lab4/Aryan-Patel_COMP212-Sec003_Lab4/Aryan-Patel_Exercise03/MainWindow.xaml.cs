using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Aryan_Patel_Exercise03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // values for bill computation
        private double subT = 0.0;
        private double tax = 0.0;
        private double totalBill = 0.0;

        // combo box values
        List<Bill_Detail> Appetizer = new List<Bill_Detail>();
        List<Bill_Detail> Beverage = new List<Bill_Detail>();
        List<Bill_Detail> Dessert = new List<Bill_Detail>();
        List<Bill_Detail> MainCourse = new List<Bill_Detail>();

        // datagrid item source
        private ObservableCollection<Bill_Detail> oBillItems = new ObservableCollection<Bill_Detail>();

        public MainWindow()
        {
            InitializeComponent();
            initializeComboBoxValues();
            dgBillItems.ItemsSource = oBillItems;
        }

        // initialize combobox options
        private void initializeComboBoxValues()
        {
            MainCourse.Add(new Bill_Detail { Name = "Prime Rib", Category = "Main Course", Price = 20.95 });
            MainCourse.Add(new Bill_Detail { Name = "Shrimp Scampi", Category = "Main Course", Price = 18.95 });
            MainCourse.Add(new Bill_Detail { Name = "Turkey Dinner", Category = "Main Course", Price = 13.95 });
            MainCourse.Add(new Bill_Detail { Name = "Stuffed Chicken", Category = "Main Course", Price = 14.95 });
            MainCourse.Add(new Bill_Detail { Name = "Seafood Alfredo", Category = "Main Course", Price = 15.95 });
            MainCourse.Add(new Bill_Detail { Name = "Chicken Alfredo", Category = "Main Course", Price = 13.95 });
            MainCourse.Add(new Bill_Detail { Name = "Chicken Picatta", Category = "Main Course", Price = 13.95 });
            MainCourse.Add(new Bill_Detail { Name = "Turkey Club", Category = "Main Course", Price = 11.95 });
            MainCourse.Add(new Bill_Detail { Name = "Lobster Pie", Category = "Main Course", Price = 19.95 });


            Appetizer.Add(new Bill_Detail { Name = "Buffalo Fingers", Category = "Appetizer", Price = 6.95 });
            Appetizer.Add(new Bill_Detail { Name = "Potato Skins", Category = "Appetizer", Price = 8.95 });
            Appetizer.Add(new Bill_Detail { Name = "Nachos", Category = "Appetizer", Price = 8.95 });
            Appetizer.Add(new Bill_Detail { Name = "Buffalo Wings", Category = "Appetizer", Price = 5.95 });
            Appetizer.Add(new Bill_Detail { Name = "Shrimp Cocktail", Category = "Appetizer", Price = 12.95 });
            Appetizer.Add(new Bill_Detail { Name = "Chips and Salsa", Category = "Appetizer", Price = 6.95 });
            Appetizer.Add(new Bill_Detail { Name = "Mushroom Caps", Category = "Appetizer", Price = 10.95 });


            Beverage.Add(new Bill_Detail { Name = "Juice", Category = "Beverage", Price = 2.50 });
            Beverage.Add(new Bill_Detail { Name = "Milk", Category = "Beverage", Price = 1.50 });
            Beverage.Add(new Bill_Detail { Name = "Tea", Category = "Beverage", Price = 1.50 });
            Beverage.Add(new Bill_Detail { Name = "Mineral Water", Category = "Beverage", Price = 2.95 });
            Beverage.Add(new Bill_Detail { Name = "Soda", Category = "Beverage", Price = 1.95 });
            Beverage.Add(new Bill_Detail { Name = "Coffee", Category = "Beverage", Price = 1.25 });


            Dessert.Add(new Bill_Detail { Name = "Carrot Cake", Category = "Dessert", Price = 5.95 });
            Dessert.Add(new Bill_Detail { Name = "Mud Pie", Category = "Dessert", Price = 4.95 });
            Dessert.Add(new Bill_Detail { Name = "Apple Crisp", Category = "Dessert", Price = 5.95 });
            Dessert.Add(new Bill_Detail { Name = "Apple Pie", Category = "Dessert", Price = 5.95 });
            Dessert.Add(new Bill_Detail { Name = "Sundae", Category = "Dessert", Price = 3.95 });

            
            cbAppetizer.DisplayMemberPath = "Name";
            cbAppetizer.SelectedValuePath = "Price";
            cbAppetizer.SetBinding(ComboBox.ItemsSourceProperty, new Binding() { Source = Appetizer });


            cbBeverage.DisplayMemberPath = "Name";
            cbBeverage.SelectedValuePath = "Price";
            cbBeverage.SetBinding(ComboBox.ItemsSourceProperty, new Binding() { Source = Beverage });


            cbDessert.DisplayMemberPath = "Name";
            cbDessert.SelectedValuePath = "Price";
            cbDessert.SetBinding(ComboBox.ItemsSourceProperty, new Binding() { Source = Dessert });


            cbMainCourse.DisplayMemberPath = "Name";
            cbMainCourse.SelectedValuePath = "Price";
            cbMainCourse.SetBinding(ComboBox.ItemsSourceProperty, new Binding() { Source = MainCourse });
        }

        // open centennial college website
        private void centennialLogo_mouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.centennialcollege.ca/");
        }

        // set the selected item of beverage
        private void cbBeverage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbBeverage.SelectedIndex != -1)
            {
                // set the selected beverage as Bill_Detail type
                Bill_Detail addBillItem = (Bill_Detail)cbBeverage.SelectedItem;
                addFoodItemToDataGrid(addBillItem);
            }
        }

        // work around for scenario when same beverage item is selected
        private void cbBeverage_OnDropDownOpened(object sender, EventArgs e)
        {
            cbBeverage.SelectedItem = null;
        }

        // set the selected item of appetizer
        private void cbAppetizer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbAppetizer.SelectedIndex != -1)
            {
                // set the selected appetizer as Bill_Detail type
                Bill_Detail addBillItem = (Bill_Detail)cbAppetizer.SelectedItem;
                addFoodItemToDataGrid(addBillItem);
            }

        }

        // work around for scenario when same appetizer item is selected
        private void cbAppetizer_OnDropDownOpened(object sender, EventArgs e)
        {
            cbAppetizer.SelectedItem = null;
        }

        // set the selected item of main course
        private void cbMainCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbMainCourse.SelectedIndex != -1)
            {
                // set the selected main course as Bill_Detail type
                Bill_Detail addBillItem = (Bill_Detail)cbMainCourse.SelectedItem;
                addFoodItemToDataGrid(addBillItem);
            }
        }

        // work around for scenario when same main course item is selected
        private void cbMainCourse_OnDropDownOpened(object sender, EventArgs e)
        {
            cbMainCourse.SelectedItem = null;
        }

        // set the selected item of dessert
        private void cbDessert_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbDessert.SelectedIndex != -1)
            {
                Bill_Detail addBillItem = (Bill_Detail)cbDessert.SelectedItem;
                addFoodItemToDataGrid(addBillItem);
            }
        }

        // work around for scenario when same dessert item is selected
        private void cbDessert_OnDropDownOpened(object sender, EventArgs e)
        {
            cbDessert.SelectedItem = null;
        }

        // add selected food item to datagrid
        private void addFoodItemToDataGrid(Bill_Detail billItem)
        {
            //string alertData = $"Name:\t\t{billItem.Name}\nCategory:\t{billItem.Category}\nPrice:\t\t{billItem.Price:C}";
            //MessageBox.Show(alertData, "Alert");

            // check first if item is already in the list
            if (oBillItems.Any(rowItem => rowItem.Name.Equals(billItem.Name)))
            {
                Bill_Detail rowItem = (Bill_Detail)oBillItems.Single(item => item.Name.Equals(billItem.Name));
                rowItem.Quantity++;

                subT += rowItem.Price;
            }
            else
            {
                // add to the list since this is a new item
                billItem.Quantity = 1;
                oBillItems.Add(billItem);

                subT += billItem.Price;
            }

            calculateTotalBill();
        }

        // calculate total bill (with tax)
        private void calculateTotalBill()
        {
            // for now lets compute the tax as 15%
            tax = subT * .15;
            totalBill = subT + tax;

            // reflect the changes in the UI
            updateLabelComputation();
        }

        // update bill computation labels
        private void updateLabelComputation()
        {
            labelSubTotal.Content = String.Format("${0:0.00}", subT);
            labelTax.Content = String.Format("${0:0.00}", tax);
            labelTotal.Content = String.Format("${0:0.00}", totalBill);
        }

        // clear bill
        private void btnClearBill_Click(object sender, RoutedEventArgs e)
        {
            subT = 0.0;
            tax = 0.0;
            totalBill = 0.0;

            // update the bill computation label
            updateLabelComputation();

            // remove everything from the list
            oBillItems.Clear();

            // reset the combo box as well
            cbBeverage.SelectedIndex = -1;
            cbAppetizer.SelectedIndex = -1;
            cbMainCourse.SelectedIndex = -1;
            cbDessert.SelectedIndex = -1;
        }

        // delete an item
        private void btnRemoveItem_Click(object sender, RoutedEventArgs e)
        {
            Bill_Detail itemToRemove = (Bill_Detail)dgBillItems.SelectedItem;

            // nothing to remove since list is empty
            if (oBillItems.Count == 0)
            {
                return;
            }

            if (itemToRemove != null)
            {
                //string alertData = $"Name:\t\t{itemToRemove.Name}\nCategory:\t{itemToRemove.Category}\nPrice:\t\t{itemToRemove.Price:C}\nQuantity:\t\t{itemToRemove.Quantity}";
                //MessageBox.Show(alertData, "Alert");

                // calculate the bill to reflect the removed item
                double itemPrice = itemToRemove.Price * itemToRemove.Quantity;
                subT -= itemPrice;

                calculateTotalBill();

                // remove the item
                oBillItems.Remove(itemToRemove);
            }
            else
            {
                string alertData = $"Please select an item to be removed.";

                MessageBox.Show(alertData, "Alert");
            }
        }

        // compute for the quantity change
        private void dgBillItems_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            Bill_Detail itemEdited = (Bill_Detail)dgBillItems.SelectedItem;

            TextBox quantityTextBox = e.EditingElement as TextBox;
            string editedItemQuantity = quantityTextBox.Text.ToString();

            //string editedItem = $"EditedItem:\nName:\t\t{itemEdited.Name}\nCategory:\t{itemEdited.Category}\nPrice:\t\t{itemEdited.Price:C}\nQuantity:\t\t{itemEdited.Quantity}";
            //string separator = "\n-------------------------------\n";
            //string updatedQuantity = $"Updated Quantity:\t {editedItemQuantity}";
            //string alertData = editedItem + separator + updatedQuantity;
            //MessageBox.Show(alertData, "Alert");

            // get the item price for computation
            double previousItemPrice = itemEdited.Price * itemEdited.Quantity;

            // try to parse the edited quantity before computing
            if (Int32.TryParse(editedItemQuantity, out int parsedQuantity))
            {
                if (parsedQuantity < 0)
                {
                    // just a check if the user enters negative; default to 0
                    itemEdited.Quantity = 0;
                    parsedQuantity = 0; // default to 0 for correct computation
                }

                double newItemPrice = itemEdited.Price * parsedQuantity;

                // remove the previous item price from sub total
                subT -= previousItemPrice;

                // then add the edited item price
                subT += newItemPrice;

                calculateTotalBill();
            }
            else
            {
                MessageBox.Show("Please Enter a valid Quantity", "Alert");
            }
        }

    }
}
