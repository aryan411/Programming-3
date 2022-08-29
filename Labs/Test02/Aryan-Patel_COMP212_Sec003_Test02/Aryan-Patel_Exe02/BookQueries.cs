using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksLibrary;

namespace Aryan_Patel_Exe02
{

    public partial class BookQueries : Form
    {
        public BookQueries()
        {
            InitializeComponent();
        }

        BooksEntities dbContext = new BooksEntities();

        private void queriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // set the data displayed according to what is selected
                switch (queriesComboBox.SelectedIndex)
                {
                    //a.Get a count of all the authors grouped by title, sorted by title. 
                    //  It should display a title and number of authors who have written that title.
                    case 1:
                        var authorsByTitle =
                            from book in dbContext.Titles
                            orderby book.Title1
                            select new { Title = book.Title1};

                        outputTextBox.Clear();

                        outputTextBox.AppendText($"\n");
                        outputTextBox.AppendText($"\r{"Title",-40}");
                        outputTextBox.AppendText($"\n*****************************************************************");
                        foreach (var book in authorsByTitle)
                        {
                            outputTextBox.AppendText($"\r\n{book.Title,-60}");
                        }

                        break;

                    //b.Get a list of all the titles grouped by author name, sorted by author; 
                    //  for a given author name sort the titles alphabetically.
                    case 0:
                        var titlesByAuthor =
                            from author in dbContext.Authors
                            orderby author.LastName, author.FirstName
                            select new
                            {
                                Name = author.FirstName + " " + author.LastName,
                                Titles =
                                  from book in author.Titles
                                  orderby book.Title1
                                  select book.Title1
                            };

                        outputTextBox.Clear();

                        outputTextBox.AppendText($"\n*****");
                        outputTextBox.AppendText("\nTitles grouped by author name:");
                        outputTextBox.AppendText($"\n*****");
                        int count = 0;
                        foreach (var author in titlesByAuthor)
                        {
                          foreach (var title in author.Titles)
                          {
                            count++;
                          }
                        }
                        outputTextBox.AppendText($"\r\n total titles: {count}");
                        // display titles written by each author, grouped by author
                        foreach (var author in titlesByAuthor)
                        {
                            // display author's name
                            outputTextBox.AppendText($"\r\n{author.Name}: count:{author.Titles.Count()}");

                            // display titles written by that author
                            foreach (var title in author.Titles)
                            {
                                outputTextBox.AppendText($"\r\n\t{title}");
                            }
                        }

                        break;
                } // end switch
            } // end try
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BooksQueries_Load(object sender, EventArgs e)
        {
            // set the ComboBox to show the default query
            queriesComboBox.SelectedIndex = 0;
        }
    }
}
