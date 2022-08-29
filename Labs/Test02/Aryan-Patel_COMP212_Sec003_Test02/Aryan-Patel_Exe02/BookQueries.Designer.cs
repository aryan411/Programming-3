
using System.Drawing;

namespace Aryan_Patel_Exe02
{
    partial class BookQueries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectQueryLabel = new System.Windows.Forms.Label();
            this.queriesComboBox = new System.Windows.Forms.ComboBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectQueryLabel
            // 
            this.selectQueryLabel.AutoSize = true;
            this.selectQueryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectQueryLabel.Location = new System.Drawing.Point(41, 13);
            this.selectQueryLabel.Name = "selectQueryLabel";
            this.selectQueryLabel.Size = new System.Drawing.Size(145, 25);
            this.selectQueryLabel.TabIndex = 2;
            this.selectQueryLabel.Text = "Search a query";
            // 
            // queriesComboBox
            // 
            this.queriesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queriesComboBox.FormattingEnabled = true;
            this.queriesComboBox.Items.AddRange(new object[] {
            "Number of Titles grouped by author",
            "List Of Title Name"});
            this.queriesComboBox.Location = new System.Drawing.Point(44, 41);
            this.queriesComboBox.Name = "queriesComboBox";
            this.queriesComboBox.Size = new System.Drawing.Size(725, 33);
            this.queriesComboBox.TabIndex = 1;
            this.queriesComboBox.SelectedIndexChanged += new System.EventHandler(this.queriesComboBox_SelectedIndexChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(41, 83);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(66, 25);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Result";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(46, 111);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(1037, 333);
            this.outputTextBox.TabIndex = 3;
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // BooksQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 457);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.queriesComboBox);
            this.Controls.Add(this.selectQueryLabel);
            this.Name = "BooksQueries";
            this.Text = "Books Queries";
            this.Load += new System.EventHandler(this.BooksQueries_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectQueryLabel;
        private System.Windows.Forms.ComboBox queriesComboBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox outputTextBox;


    }
}

