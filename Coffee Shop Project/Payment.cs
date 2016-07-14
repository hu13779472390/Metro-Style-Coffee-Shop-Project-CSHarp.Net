using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop_Project
{

    public partial class Payment : Form
    {
        POS pos = POS.GetPOS();
        public event EventHandler TransactionCompleted;
        private decimal paymentAmount;
        public decimal PaymentAmount
        {
            get { return paymentAmount; }
            set
            {
                paymentAmount = value;
                txtPaymentAmount.Text = String.Format("{0:C}", paymentAmount);
            }
        }

        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            txtAmountToPay.Text = String.Format("{0:C}", POS.totalToPay);

            TransactionCompleted += pos.TransactionCompletedMethod;
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            decimal rp;
            if (decimal.TryParse(txtPaymentAmount.Text, out rp))
            {
                POS.totalToPay -= rp;
                txtAmountToPay.Text = String.Format("{0:C}", POS.totalToPay);
                if (POS.totalToPay > 0)
                {
                    txtAmountToPay.Text = String.Format("{0:C}", 0);
                    MessageBox.Show("Transaction not Completed", "Incomplete Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pos.lblTotal.Text = $"Change to Give: {String.Format("{0:C}", POS.totalToPay)}";

                }
                else if (POS.totalToPay == 0)
                {
                    txtAmountToPay.Text = String.Format("{0:C}", POS.totalToPay);
                    MessageBox.Show("Transaction has Successfully Completed", "Transaction Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                    this.Close();
                    TransactionCompleted(this,e);

                }         
                else if (POS.totalToPay < 0)
                {
                    txtAmountToPay.Text = String.Format("{0:C}", POS.totalToPay);
                    MessageBox.Show($"Please give a change {String.Format("{0:C}", POS.totalToPay)}", "Transaction Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    TransactionCompleted(this,e);
                }
            }
            else
            {
                MessageBox.Show("Input is in Wrong Format", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
