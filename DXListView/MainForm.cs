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
            MyData rootNode1 = new MyData(tlDataSource, new string[] { "Project A", "High" });
            MyData node1 = new MyData(rootNode1, new string[] { "Deliverable 1", "Normal" });
            MyData node2 = new MyData(node1, new string[] { "This task is mine A", "High" });
            MyData node3 = new MyData(node1, new string[] { "This task isn't mine A", "Low" });
            // Represents the second root node. 
            MyData rootNode2 = new MyData(tlDataSource, new string[] { "Project B", "Normal" });
            // Represents the child node of the second root node. 
            MyData node5 = new MyData(rootNode2, new string[] { "This task is mine B", "High" });
            TreeListColumn col1 = new TreeListColumn();
            col1.Caption = "Name";
            col1.VisibleIndex = 0;
            TreeListColumn col2 = new TreeListColumn();
            col2.Caption = "Priority";
            col2.VisibleIndex = 1;
            treeList1.Columns.AddRange(new TreeListColumn[] { col1, col2 });
            treeList1.DataSource = tlDataSource;
        }

        private void btnVOID_Click(object sender, EventArgs e)
        {
            this.Close();
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
