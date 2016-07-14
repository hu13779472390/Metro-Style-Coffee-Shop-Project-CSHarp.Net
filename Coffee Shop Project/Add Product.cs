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
using System.Threading;
using System.Globalization;

namespace Coffee_Shop_Project
{
    public partial class Add_Product : Form
    {
        public Add_Product()
        {
            InitializeComponent();
        }
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {

            lblSaving.Visible = true;
        }

        private void Add_Product_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("rs-PK");

            using (Coffee_ProjectEntities cpe = new Coffee_ProjectEntities())
            {
                DataTable temptabel = new DataTable();
                temptabel.Columns.Add("ProductType",typeof(int));
                temptabel.Columns.Add("ProductDescription", typeof(string));

                var items = cpe.TblProductTypes.Select(eb => eb);
                foreach (var item in items)
                {
                    temptabel.Rows.Add((int)item.ProductType, (string)item.ProductDescription);
                }

                cmbCategory.DataSource = temptabel;
                cmbCategory.DisplayMember = "ProductDescription";
                cmbCategory.ValueMember = "ProductType";
            }
        }

        byte[] imageBytes;
        private void linkChooseNewItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Choose Image";
            openFileDialog1.Filter = "All Images|*.png;*.jpg;*.bmp";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                string fileName = openFileDialog1.FileName;
               picNewItem.Image = Image.FromFile(fileName);

                FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            
                imageBytes = new byte[fileStream.Length];
                fileStream.Read(imageBytes, 0, imageBytes.Length);
                MemoryStream stream = new MemoryStream(imageBytes);
                picNewItem.Image = Image.FromStream(stream);
                txtDescription.Text = Path.GetFileName(fileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (Coffee_ProjectEntities cpe = new Coffee_ProjectEntities())
            {
                TblProduct newProduct = new TblProduct()
                {
                    Description = txtDescription.Text,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    Image = imageBytes,
                    ProductType = (int)cmbCategory.SelectedValue 
                };

                cpe.TblProducts.Add(newProduct);   
                cpe.SaveChanges();
                lblSaving.Visible = false;
                MessageBox.Show("Item Saved Successfully", "Item Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainManu().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            btn.BackColor = Color.DarkGray;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            btn.BackColor = Color.CornflowerBlue;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            btn.BackColor = Color.DarkGray;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
