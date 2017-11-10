using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Nodes.Operations;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bind();
        }

        private void btnVOID_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Bind()
        {
            CreateColumns(treeList1);
            CreateNodes(treeList1);
        }

        private void CreateColumns(TreeList tl)
        {
            //356
            // Create three columns.
            tl.BeginUpdate();
            TreeListColumn col1 = tl.Columns.Add();
            col1.Caption = "Description";
            col1.VisibleIndex = 0;
            col1.MinWidth = 270;
            col1.Width  = 270;
            

            TreeListColumn col2 = tl.Columns.Add();
            col2.Caption = "Price";
            col2.VisibleIndex = 1;
            col2.MinWidth = 50;
            col2.Width = 50;

            tl.EndUpdate();
        }

        private void CreateNodes(TreeList tl)
        {
            tl.BeginUnboundLoad();

            // Create a root node .
            TreeListNode parentForRootNodes = null;


            TreeListNode nodeCustomerAccNo = tl.AppendNode(
               new object[] { "For MR Z ERO", "" }, parentForRootNodes);

            TreeListNode nodePLU = tl.AppendNode(
               new object[] { "Shirt", "5.50" }, nodeCustomerAccNo);


            TreeListNode nodePLUExtra1 = tl.AppendNode(
               new object[] { "Lt. Blue", "1.50" }, nodePLU);

            TreeListNode nodePLUExtra2 = tl.AppendNode(
               new object[] { "Twead", "0.50" }, nodePLU);

            tl.AppendNode("", nodePLU);


            tl.EndUnboundLoad();

            tl.ExpandAll();
        }

    }
    
}
