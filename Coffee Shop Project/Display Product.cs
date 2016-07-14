using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;
using System.Threading;
using System.Globalization;

namespace Coffee_Shop_Project
{
    public partial class Display_Product : Form
    {
        public Display_Product()
        {
            InitializeComponent();
        }

         
        public void DisplayData(int _productType)
        {
            using (Coffee_ProjectEntities cpe = new Coffee_ProjectEntities())
            {

                DataTable tempTable = new DataTable();
                tempTable.Columns.Add("Id", typeof(int));
                tempTable.Columns.Add("Product Type", typeof(int));
                tempTable.Columns.Add("Decription", typeof(string));
                tempTable.Columns.Add("Price", typeof(string));

                var items = cpe.TblProducts.Select(it => it);
                foreach (var item in items)
                {
                    if(item.ProductType==_productType)
                    tempTable.Rows.Add(item.ProductID, item.ProductType, item.Description, item.Price);
                }
                productGridView.DataSource = tempTable;
            }
        }
        public void DisplayAllData()
        {
            using (Coffee_ProjectEntities cpe = new Coffee_ProjectEntities())
            {

                DataTable tempTable = new DataTable();
                tempTable.Columns.Add("Id", typeof(int));
                tempTable.Columns.Add("Product Type", typeof(int));
                tempTable.Columns.Add("Decription", typeof(string));
                tempTable.Columns.Add("Price", typeof(string));

                var items = cpe.TblProducts.Select(it => it);
                foreach (var item in items)
                {
               
                        tempTable.Rows.Add(item.ProductID, item.ProductType, item.Description, item.Price);
                }
                productGridView.DataSource = tempTable;
            }
        }
        private void Display_Product_Load(object sender, EventArgs e)
        { 
            DisplayAllData();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("rs-Pk", false);
            
        }

        public void ContentClickDisplay()
        {
            int selectedProductId = 0;
            for (int i = 0; i < productGridView.Rows.Count; i++)
            {
                if (productGridView.Rows[i].Selected == true)
                {
                    selectedProductId = (int)productGridView.Rows[i].Cells[0].Value;
                }
            }

            using (Coffee_ProjectEntities cpe = new Coffee_ProjectEntities())
            {
                var recievedImage = from m in cpe.TblProducts
                                    select m;
                foreach (var item in recievedImage)
                {
                    if (item.ProductID == selectedProductId)
                    {
                        lblDescription.Visible = true;
                        lblPrice.Visible = true;
                        txtDescription.Visible = true;
                        byte[] imagedBytes = item.Image;
                        MemoryStream memoryStream = new MemoryStream(imagedBytes);
                        selectedImage.Image = Image.FromStream(memoryStream);
                        txtDescription.Text = item.Description;
                        lblPrice.Text = String.Format("{0:C}", item.Price);
                        break;
                    }
                }
            }

        }
        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ContentClickDisplay();     
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainManu().Show();
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
    }
}
