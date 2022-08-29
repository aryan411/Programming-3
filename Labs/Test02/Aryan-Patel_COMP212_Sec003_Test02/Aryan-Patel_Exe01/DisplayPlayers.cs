using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseballLibrary;
using System.Data.Entity;

namespace Aryan_Patel_Exe01
{
    public partial class DisplayPlayers : Form
    {
        static decimal temp = 0;
        static string name;
        static string playerName;
        static int PlayerID;
        public DisplayPlayers()
        {
            InitializeComponent();
        }
        private BaseballLibrary.BaseballEntities dbcontext = new BaseballLibrary.BaseballEntities();

        private void searchPlayer_Click(object sender, EventArgs e)
        {
            playerName = txtSearchPlayr.Text.ToString();
            var r = from player in dbcontext.Players where player.FirstName == playerName select player;
            //specify Datasource for playerBindingSource
            playerBindingSource.DataSource = r.ToList();
        }

        private void btnSearchid_Click(object sender, EventArgs e)
        {
            PlayerID = Convert.ToInt32(txtSearchid.Text);
            var r = from player in dbcontext.Players where player.PlayerID == PlayerID select player;
            //specify Datasource for playerBindingSource
            playerBindingSource.DataSource = r.ToList();
        }

        private void btnallPlayer_Click(object sender, EventArgs e)
        {
            txtSearchPlayr.Text = null;
            //specify Datasource for playerBindingSource
            playerBindingSource.DataSource = dbcontext.Players.Local;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHighestAvg.AppendText("Player with Highest Batting Average is :\n");
            foreach (var p in dbcontext.Players)
            {
                if (p.BattingAverage > temp)
                {
                    temp = p.BattingAverage;
                    name = p.FirstName;

                }




            }
            txtHighestAvg.AppendText(Environment.NewLine);
            txtHighestAvg.AppendText($"\r\nPlayer Name: " + name);
            txtHighestAvg.AppendText(Environment.NewLine);
            txtHighestAvg.AppendText($"\r\nBatting Avg:" + temp);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            txtResult.AppendText(" List of all Players and Batting Average");
            foreach (var p in dbcontext.Players)
            {
                txtResult.AppendText(Environment.NewLine);
                txtResult.AppendText($"\r\nPlayer Name:");
                txtResult.AppendText(Environment.NewLine);
                txtResult.AppendText($"\r\n\t{p.FirstName}");
                txtResult.AppendText(Environment.NewLine);
                txtResult.AppendText($"\r\nBatting Avg:");
                txtResult.AppendText(Environment.NewLine);
                txtResult.AppendText($"\r\n\t{p.BattingAverage}");

            }
            foreach (var p in dbcontext.Players)
            {
                if (p.BattingAverage > temp)
                {
                    temp = p.BattingAverage;
                    name = p.FirstName;

                }
            }

        }
        private void DisplayPlayers_Load(object sender, EventArgs e)
        {
            dbcontext.Players.Load();
            //specify Datasource for playerBindingSource
            playerBindingSource.DataSource = dbcontext.Players.Local;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
