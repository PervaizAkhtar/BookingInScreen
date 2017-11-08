using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXListView
{
    public partial class MainForm : Form
    {
        public DevExpressTreeListManager mgr;
        public string CustomerAccNo="For MR Z ERO";
        public TreeListNode NodePlu = null;

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
                    AddPluToTree("", btn.Text, btn.Tag.ToString());
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
            // TODO: This line of code loads data into the 'nORTHWINDDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nORTHWINDDataSet.Orders);
        }

        private void btnVOID_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog(); 
        }

        private void treeList1_AfterExpand(object sender, NodeEventArgs e)
        {
            e.Node.StateImageIndex = 0;
        }

        private void treeList1_AfterCollapse(object sender, NodeEventArgs e)
        {
            e.Node.StateImageIndex = 1;
        }

        private void AddPluToTree(string quantity, string pluText, string pluPrice)
        { 
            if(!string.IsNullOrEmpty(quantity))
            {
                pluText = quantity + " x " + pluText;
            }
            else
            {
                pluText = "1" + " x " + pluText;
            }

            decimal price = Decimal.Parse(pluPrice.ToString());

            NodePlu = mgr.CreatePLUNode(CustomerAccNo, pluText, price);

            treeList1.EndUnboundLoad();

            treeList1.ExpandAll();

            panelPlu.Visible = false;
            panelColor.Visible = true;
        }

        public void AddPLUExtraToTree(string pluExtraText, string pluExtraPrice)
        {
            decimal price = Decimal.Parse(pluExtraPrice.ToString());

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
        }

 
      


#if false 

        void InitData()
        {
            // Represents the root of the tree. 
            MyData tlDataSource = new MyData(null, null);
            // Represents the first root node. 
            MyData rootNode1 = new MyData(tlDataSource, new string[] { "Root Object", "High" });
            MyData node1 = new MyData(rootNode1, new string[] { "Shirt", "Normal" });
            MyData node2 = new MyData(node1, new string[] { "Grey", "High" });
            MyData node3 = new MyData(node1, new string[] { "Linen", "Low" });
            MyData node4 = new MyData(node1, new string[] { "Silk", "Low" });
            
            
            TreeListColumn col1 = new TreeListColumn();
            col1.Caption = "Name";
            col1.VisibleIndex = 0;

            TreeListColumn col2 = new TreeListColumn();
            col2.Caption = "Priority";
            col2.VisibleIndex = 1;
            col2.Width = 40;

            treeList1.Columns.AddRange(new TreeListColumn[] { col1, col2 });
            treeList1.DataSource = tlDataSource;

            treeList1.BackgroundImage = Image.FromFile(@"C:\Users\PervaizA.BUZZ\Documents\visual studio 2013\Projects\DXListView\DXListView\Resources\Customers Ticket.jpg");
        }

#endif

    }

#if false 

    // Represents a sample Business Object 
    public class MyData : TreeList.IVirtualTreeListData
    {
        protected MyData parentCore;
        protected ArrayList childrenCore = new ArrayList();
        protected object[] cellsCore;

        public MyData(MyData parent, object[] cells)
        {
            // Specifies the parent node for the new node. 
            this.parentCore = parent;
            // Provides data for the node's cell. 
            this.cellsCore = cells;

            if (this.parentCore != null)
            {
                this.parentCore.childrenCore.Add(this);
            }
        }

        void TreeList.IVirtualTreeListData.VirtualTreeGetChildNodes(VirtualTreeGetChildNodesInfo info)
        {
            info.Children = childrenCore;
        }

        void TreeList.IVirtualTreeListData.VirtualTreeGetCellValue(VirtualTreeGetCellValueInfo info)
        {
            info.CellData = cellsCore[info.Column.AbsoluteIndex];
        }

        void TreeList.IVirtualTreeListData.VirtualTreeSetCellValue(VirtualTreeSetCellValueInfo info)
        {
            cellsCore[info.Column.AbsoluteIndex] = info.NewCellData;
        }

    }

#endif

}
