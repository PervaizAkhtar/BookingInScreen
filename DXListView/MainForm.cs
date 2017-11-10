using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace DXListView
{
    public partial class MainForm : Form
    {
        public DevExpressTreeListManager mgr;
        public string CustomerAccNo = "For MR Z ERO";
        public int Qty = 1;
        public TreeListNode NodePlu = null;
        public TreeListNode NodeCustomerAccNo = null;
        public string FolderPath = System.Configuration.ConfigurationManager.AppSettings["FolderPath"];
        public MainForm()
        {
            InitializeComponent();
            mgr = new DevExpressTreeListManager(treeList1);
            Button1.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;
            button4.Click += Button_Click;
            button5.Click += Button_Click;
            button6.Click += Button_Click;

            button9.Click += Button_Click;
            button10.Click += Button_Click;
            button11.Click += Button_Click;
            button12.Click += Button_Click;
            button13.Click += Button_Click;
            button14.Click += Button_Click;
            button15.Click += Button_Click;
            button16.Click += Button_Click;
            button17.Click += Button_Click;
            button18.Click += Button_Click;
            button19.Click += Button_Click;
            button20.Click += Button_Click;

        }

        void Button_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Name)
            {
                case "Button1":
                case "button2":
                case "button3":
                case "button4":
                case "button5":
                case "button6":
                    AddPluToTree(btn.Text, btn.Tag.ToString());
                    break;

                case "button9":
                case "button10":
                case "button11":
                case "button12":
                case "button13":
                case "button14":
                case "button15":
                case "button16":
                case "button17":
                case "button18":
                case "button19":
                case "button20":
                    AddPLUExtraToTree(btn.Text, btn.Tag.ToString());
                    break;

            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NodeCustomerAccNo = mgr.CreateRootNodeWithCustomerAccountNumber(CustomerAccNo);

            treeList1.OptionsBehavior.Editable = false;

            treeList1.OptionsView.ShowIndicator = false;
            treeList1.OptionsView.ShowVertLines = false;
            treeList1.OptionsView.ShowHorzLines = false;
            treeList1.OptionsView.ShowColumns = false;


            treeList1.OptionsView.ShowSummaryFooter = true;
            TreeListColumn column = treeList1.Columns[1];
            column.AllNodesSummary = true;
            column.SummaryFooterStrFormat = "Total  {0:0.00}";
            column.SummaryFooter = SummaryItemType.Sum;

            
            
        }

        private void btnVOID_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void AddPluToTree(string pluText, string pluPrice)
        {
            pluText = Qty + " x " + pluText;

            decimal   price = decimal.Parse(pluPrice.ToString());

            price *= Qty;

            NodePlu = mgr.CreatePLUNode(pluText, price);

            treeList1.EndUnboundLoad();

            treeList1.ExpandAll();

            panelPlu.Visible = false;

            panelColor.Visible = true;
        }

        public void AddPLUExtraToTree(string pluExtraText, string pluExtraPrice)
        {
            decimal price = decimal.Parse(pluExtraPrice.ToString());

            mgr.CreatePLUNodeExtra(NodePlu, pluExtraText, price);

            treeList1.EndUnboundLoad();

            treeList1.ExpandAll();

            panelPlu.Visible = false;

            panelColor.Visible = false;

            panelFabric.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelPlu.Visible = true;
            panelColor.Visible = false;
            panelFabric.Visible = false;
            var sum = treeList1.Columns[1];
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblQty.Text = "Qty: 2";
            Qty = 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblQty.Text = "Qty: 1";
        }

        private void treeList1_AfterExpand(object sender, NodeEventArgs e)
        {
            e.Node.StateImageIndex = 0;
        }

        private void treeList1_AfterCollapse(object sender, NodeEventArgs e)
        {
            e.Node.StateImageIndex = 1;
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            Qty = 1;
            treeList1.Nodes.Clear();
            NodeCustomerAccNo = mgr.CreateRootNodeWithCustomerAccountNumber(CustomerAccNo);

            panelPlu.Visible = true;
            panelFabric.Visible = false;
            panelColor.Visible = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                TreeListNode node = treeList1.FocusedNode;
                if (node == null)
                {
                    MessageBox.Show("Select item from plu list and then press remove button.");
                }
                else
                {
                    if (node.Id == 0)
                    {

                    }
                    else
                    {
                        if (node.ParentNode != null)
                            node.ParentNode.Nodes.Remove(node);
                        else
                            treeList1.Nodes.Remove(node);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                treeList1.EndUpdate();
                panelPlu.Visible = true;
                panelFabric.Visible = false;
                panelColor.Visible = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                int indexItem = treeList1.Nodes.Count - 1;

                if (indexItem == 0)
                { 
                }
                else 
                {
                    treeList1.Nodes.RemoveAt(indexItem);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                treeList1.EndUpdate();
                panelPlu.Visible = true;
                panelFabric.Visible = false;
                panelColor.Visible = false;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            treeList1.Print();
        }

        private void CreateFolder()
        {

            if (System.IO.Directory.Exists(FolderPath))
            {

            }
            else {
                System.IO.Directory.CreateDirectory(FolderPath);
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CreateFolder();
            string timeStamp = DateTime.Now.ToString("dd-MM-yyy HHmmss");
            treeList1.ExportToPdf(FolderPath + @"\Ticket_" + timeStamp + ".pdf");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CreateFolder();
            string timeStamp = DateTime.Now.ToString("dd-MM-yyy HHmmss");
            treeList1.ExportToRtf(FolderPath + @"\Ticket_" + timeStamp + ".rtf");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CreateFolder();
            string timeStamp = DateTime.Now.ToString("dd-MM-yyy HHmmss");
            treeList1.ExportToCsv(FolderPath + @"\Ticket_" + timeStamp + ".csv");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            CreateFolder();
            string timeStamp = DateTime.Now.ToString("dd-MM-yyy HHmmss");
            treeList1.ExportToText(FolderPath + @"\Ticket_" + timeStamp + ".txt");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            CreateFolder();
            string timeStamp = DateTime.Now.ToString("dd-MM-yyy HHmmss");
            treeList1.ExportToXls(FolderPath + @"\Ticket_" + timeStamp + ".xls");
        }
    }
}
