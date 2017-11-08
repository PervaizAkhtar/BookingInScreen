using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
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
        public MainForm()
        {
            InitializeComponent();
            InitData();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nORTHWINDDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nORTHWINDDataSet.Orders);

        }

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
    }


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
}
