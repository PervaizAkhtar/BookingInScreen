using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXBookingIn
{
    public partial class frmEdit : Form
    {
        public int Qty { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        [DefaultValue(false)]
        public bool Void { get; set; }
        

        public frmEdit()
        {
            InitializeComponent();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Enabled == false)
            {
            }
            else
            {
                Qty = int.Parse(txtQuantity.Text);
            }
            Description = txtDescription.Text;
            if (!string.IsNullOrEmpty(txtPrice.Text))
            {
                Price = Decimal.Parse(txtPrice.Text);
            }
            Void = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Void = true;
            this.Close();
        }
    }
}
