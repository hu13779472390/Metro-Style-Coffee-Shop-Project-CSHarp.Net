using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop_Project
{
    public partial class DisplaySales : Form
    {
        public DisplaySales()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            btn.BackColor = Color.DarkGray;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            btn.BackColor = Color.CornflowerBlue;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            btn.BackColor = Color.DarkGray;
        }

        private void GenerateGraph()
        {
            try
            {

                using (Coffee_ProjectEntities cpe = new Coffee_ProjectEntities())
                {

                    var query = from product in cpe.TblTransactionItems
                                group product by product.TblProduct.Description into g
                                select new { ProductId = g.Key, TotalUnitSold = g.Count() };
                    var list = query.ToList();

                    chart1.DataSource = list;
                    chart1.Series["Series1"].XValueMember = "ProductId";
                    chart1.Series["Series1"].YValueMembers = "TotalUnitSold";
                    chart1.Series["Series1"].Name = "Products";
                    chart1.DataBind();
                    chart1.Show();
                }
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message,ex.Source,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void DisplaySales_Load(object sender, EventArgs e)
        {
            GenerateGraph();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainManu().Show();
        }
    }
}
