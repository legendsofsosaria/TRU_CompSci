using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void ShowCard(string card)
		{
			switch (card)
			{
				case "Ace of Spades":
					ShowAceSpades();
					break;
				case "10 of Hearts":
					ShowTenHearts();
					break;
				case "King of Clubs":
					ShowKingClubs();
					break;
			}
		}

		private void ShowAceSpades()
		{
			aceSpadesPictureBox.Visible = true;
			tenHeartsPictureBox.Visible = false;
			kingClubsPictureBox.Visible = false;
		}

		private void ShowTenHearts()
		{
			tenHeartsPictureBox.Visible = true;
			aceSpadesPictureBox.Visible = false;
			kingClubsPictureBox.Visible = false;
		}

		private void ShowKingClubs()
		{
			kingClubsPictureBox.Visible = true;
			tenHeartsPictureBox.Visible = false;
			aceSpadesPictureBox.Visible = false;
		}

		private void showCardButton_Click(object sender, EventArgs e)
		{
			if (cardListBox.SelectedIndex != -1)
			{
				ShowCard(cardListBox.SelectedItem.ToString());
			}
			else
			{
				MessageBox.Show("Please select a card from the list box.");
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
