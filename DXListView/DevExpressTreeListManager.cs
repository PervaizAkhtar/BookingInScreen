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

public class DevExpressTreeListManager
{
    private TreeList tl;

    public DevExpressTreeListManager(TreeList treeList)
    {
        this.tl = treeList;
        CreateColumns();
    }

    private void CreateColumns()
    {
        tl.BeginUpdate();
        TreeListColumn col1 = tl.Columns.Add();
        col1.Caption = "Description";
        col1.VisibleIndex = 0;
        col1.MinWidth = 270;
        col1.Width = 270;


        TreeListColumn col2 = tl.Columns.Add();
        col2.Caption = "Price";
        col2.VisibleIndex = 1;
        col2.MinWidth = 50;
        col2.Width = 50;

        tl.EndUpdate();
    }

    private TreeListNode CreateRootNodeWithCustomerAccountNumber(string customerAccNo)
    {
        // Create a root node .
        TreeListNode parentForRootNodes = null;

        TreeListNode nodeCustomerAccNo = tl.AppendNode(
           new object[] { customerAccNo, "" }, parentForRootNodes);

        return nodeCustomerAccNo;
    }

    public TreeListNode CreatePLUNode(string customerAccNo, string pluDescription, decimal pluPrice)
    {
        TreeListNode nodeCustomerAccNo = CreateRootNodeWithCustomerAccountNumber(customerAccNo);

        TreeListNode nodePLU = tl.AppendNode(
        new object[] { pluDescription, pluPrice }, nodeCustomerAccNo);

        return nodePLU;
    }

    public TreeListNode CreatePLUNodeExtra(TreeListNode nodePLU, string pluExtraDescription, decimal pluExtraPrice)
    {
         TreeListNode nodePluExtra = tl.AppendNode(new object[] { pluExtraDescription, pluExtraPrice }, nodePLU);

        //tl.AppendNode("", nodePLU);

         return nodePluExtra;
    }
    
}

