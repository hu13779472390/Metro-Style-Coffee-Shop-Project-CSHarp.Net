using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Coffee_Shop_Project
{
    public partial class MainManu : Form
    {
        public MainManu()
        {
            InitializeComponent();
        }

        Add_Product ap = new Add_Product();
        private void metroTile1_Click(object sender, EventArgs e)
        {
            ap.Show();
            this.Hide();
       
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Display_Product().Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Hide();
            POS obj = POS.GetPOS();
            obj.Show();
        }

        private void MainManu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            btn.BackColor = Color.DarkGray;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            btn.BackColor = Color.CornflowerBlue;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            btn.BackColor = Color.DarkGray;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            if (btn.Name == "pictureBox3")
            {
                this.SendToBack();
            }
            else if (btn.Name == "pictureBox2")
            {
                Application.Exit();
            }
        }

        private void NewItemTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Add_Product().Show();
        }

        private void DisplayProductTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Display_Product().Show();
        }

        private void POStile_Click(object sender, EventArgs e)
        {
            this.Hide();
            POS obj = POS.GetPOS();
            obj.Show();
        }

        private void NewItemTile_MouseHover(object sender, EventArgs e)
        {  
            MetroTile tile = (MetroTile)sender;
            tile.BackColor = Color.CornflowerBlue;
            //tile.ForeColor = Color.WhiteSmoke;
        }                                                   

        private void NewItemTile_MouseLeave(object sender, EventArgs e)
        {
            MetroTile tile = (MetroTile)sender;
            tile.BackColor = Color.White;
            //tile.ForeColor = Color.Gray;
        }

        private void NewItemTile_MouseMove(object sender, MouseEventArgs e)
        {
            MetroTile tile = (MetroTile)sender;
            tile.BackColor = Color.CornflowerBlue;
           // tile.ForeColor = Color.WhiteSmoke;
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new DisplaySales().Show();
        }

        private void metroTile1_MouseHover(object sender, EventArgs e)
        {
            MetroTile tile = (MetroTile)sender;
            tile.BackColor = Color.CornflowerBlue;
        }

        private void metroTile1_MouseLeave(object sender, EventArgs e)
        {
            MetroTile tile = (MetroTile)sender;
            tile.BackColor = Color.White;
        }

        private void metroTile1_MouseMove(object sender, MouseEventArgs e)
        {
            MetroTile tile = (MetroTile)sender;
            tile.BackColor = Color.CornflowerBlue;
        }
    }
}
