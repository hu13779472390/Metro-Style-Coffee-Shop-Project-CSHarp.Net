using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MetroFramework.Controls;
using System.Drawing.Printing;

namespace Coffee_Shop_Project
{
    public delegate void PaymentMadeEventHandler(object sender, EventArgs e);

    public partial class POS : Form
    {
        private static POS _instance;
        public PaymentMadeEventHandler PaymentMadeEvent;
        public static decimal totalToPay = 0;
        DataTable tempTable;

        List<TblProduct> ChosenProductsList = new List<TblProduct>();

        public event EventHandler TransactionSuccess;
        protected POS()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("rs-PK", false);
            tempTable = new DataTable();
            tempTable.Columns.Add("Id", typeof(int));
            tempTable.Columns.Add("Description", typeof(string));
            tempTable.Columns.Add("Price", typeof(string));

            ChosenItemsDataGridView.DataSource = tempTable;
        }

        public static POS GetPOS()
        {
            if (_instance == null)
            {
                _instance = new POS();
            }
            return _instance;
        }
        private void POS_Load(object sender, EventArgs e)
        {

            CreateTabbedPanel();
            AddProductsToTabbedPanel();

        }
        public void CreateTabbedPanel()
        {
            using (Coffee_ProjectEntities cpe = new Coffee_ProjectEntities())
            {
                foreach (var item in cpe.TblProductTypes)
                {
                    metroTabControl1.TabPages.Add(item.ProductType.ToString(), item.ProductDescription);
                }
            }
        }
        public void AddProductsToTabbedPanel()
        {
            int i = 1;
            using (Coffee_ProjectEntities cpe = new Coffee_ProjectEntities())
            {
                foreach (TabPage item in metroTabControl1.TabPages)
                {
                    FlowLayoutPanel flp = new FlowLayoutPanel();
                    flp.Dock = DockStyle.Fill;
                    foreach (var product in cpe.TblProducts)
                    {
                        if (product.ProductType == i)
                        {
                            Button btn = new Button();
                            btn.Size = new Size(100, 100);
                            btn.Image = Image.FromStream(new MemoryStream(product.Image));
                            btn.ImageAlign = ContentAlignment.TopCenter;
                            btn.TextAlign = ContentAlignment.BottomCenter;
                            btn.ImageAlign = ContentAlignment.TopCenter;
                            btn.Tag = product;

                            btn.Click += Btn_Click;

                            btn.Text = product.Description;
                            btn.BackColor = Color.White;
                            flp.Controls.Add(btn);
                        }
                    }

                    item.Controls.Add(flp);
                    i++;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;

            TblProduct selectedProduct = (TblProduct)currentButton.Tag;
            tempTable.Rows.Add(selectedProduct.ProductID, selectedProduct.Description, String.Format("{0:C}", selectedProduct.Price));
            ChosenItemsDataGridView.DataSource = tempTable;
            ChosenProductsList.Add(selectedProduct); 

            totalToPay += selectedProduct.Price;
            lblTotal.Visible = true;
            removeAll.Visible = true;
            lblTotal.Text = String.Format("Total to Pay: {0:C}", totalToPay);
        }
        public void TransactionCompletedMethod(object sebder,EventArgs e)
        {
            this.Refresh();
            lblTotal.Text = String.Format("Total to Pay: {0:C}", totalToPay);

            using (Coffee_ProjectEntities cpe = new Coffee_ProjectEntities())
            {
                if (ChosenProductsList.Count>0)
                {
                    TblTransaction transaction = new TblTransaction();
                    transaction.TransactionDate = DateTime.Now;
                    foreach (var item in ChosenProductsList)
                    {
                        transaction.TblTransactionItems.Add(new TblTransactionItem() { ProductID = item.ProductID });
                    }

                    cpe.TblTransactions.Add(transaction);
                    try
                    {
                        cpe.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            PrintReciept();
        }

        private void PrintReciept()
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += PrintDocument_PrintPage;

            DialogResult result = printDialog.ShowDialog();
            if(result==DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Microsoft Sans Serif",10);
            Brush brush = new SolidBrush(Color.Black);
            float fontHeight = font.GetHeight();

            int x = 10;
            int y = 10;
           int offeset =3;

            graphic.DrawString("Coffee Corner",new Font("Verdana",16), brush, x+20, y);

            offeset +=(int) (new Font("Verdana", 16).GetHeight());

            graphic.DrawString("Paris Road(Sialkote)",new Font("Courier New",12), brush, x+10,y+offeset);
            offeset += 30;
            graphic.DrawString($"{DateTime.Now}".PadLeft(22), new Font("Courier New",12), brush, x + 10, y + offeset);
            offeset += 20;
            Point p1 = new Point(x,y+offeset);
            Point p2 = new Point(x+300, y + offeset);
            string header ="Id".PadRight(8)+"Description".PadRight(20)+"Type".PadRight(10)+"Price".PadRight(10);
            offeset += 10;
            graphic.DrawString(header, new Font("Microsoft Sans Serif", 12), brush, x +3, y + offeset);
            offeset += 25;
            graphic.DrawLine(Pens.Black,p1, p2);
            Point p3 = new Point(x, y + offeset);
        Point p4 = new Point(x +300, y + offeset);
            graphic.DrawLine(Pens.Black, p3, p4);
            offeset += 10;

            foreach (var item in ChosenProductsList)
            {
                string row = $"{item.ProductID}".PadRight(8) + $"{item.Description}\t"+$"{item.ProductType}".PadRight(10) + $"{item.Price}".PadRight(10);
                graphic.DrawString(row, font, brush, x + 3, y + offeset);
                offeset += 15;  
            }

        }

        private void openPayment(object sender, EventArgs e)
        {
            Payment pObj = new Payment();
            pObj.ShowDialog();
        }

        #region HandyEvents
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.SendToBack();
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

        private void removeAll_MouseHover(object sender, EventArgs e)
        {
            removeAll.ForeColor = Color.Silver;
        }

        private void removeAll_MouseLeave(object sender, EventArgs e)
        {
            removeAll.ForeColor = Color.Red;
        }

        private void removeAll_MouseMove(object sender, MouseEventArgs e)
        {
            removeAll.ForeColor = Color.Silver;
        }

        private void ChosenItemsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Visible = true;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.LightGray;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.WhiteSmoke;
        }

        private void btnDelete_MouseMove(object sender, MouseEventArgs e)
        {
            btnDelete.BackColor = Color.LightGray;
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainManu().Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            decimal temp = 0;
            for (int i = 0; i < ChosenItemsDataGridView.Rows.Count; i++)
            {
                if (ChosenItemsDataGridView.Rows[i].Selected == true)
                {
                    string str = (string)ChosenItemsDataGridView.Rows[i].Cells[(tempTable.Columns.Count - 1)].Value;
                    string cutten = str.Replace("Rs", "");
                    temp = decimal.Parse(cutten);
                    tempTable.Rows.RemoveAt(i);

                    ChosenItemsDataGridView.Refresh();
                    break;
                }
            }
            totalToPay -= temp;
            lblTotal.Text = String.Format("Total to Pay: {0:C}", totalToPay);
        }

        private void metroTile1_MouseHover(object sender, EventArgs e)
        {
            MetroTile tile = (MetroTile)sender;
            tile.BackColor = Color.Silver;
        }

        private void metroTile1_MouseLeave(object sender, EventArgs e)
        {
            MetroTile tile = (MetroTile)sender;
            tile.BackColor = Color.LightGray;
        }

        private void metroTile1_MouseMove(object sender, MouseEventArgs e)
        {
            MetroTile tile = (MetroTile)sender;
            tile.BackColor = Color.Silver;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            tempTable.Clear();
            ChosenItemsDataGridView.DataSource = tempTable;
            lblTotal.Visible = false;
            removeAll.Visible = false;
            btnDelete.Visible = false; 
        }
    }
}
