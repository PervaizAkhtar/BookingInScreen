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
        col1.Caption = "";
        col1.OptionsColumn.AllowSort = false;
        col1.OptionsColumn.AllowMoveToCustomizationForm = false;
        col1.OptionsColumn.AllowMove = false;
        col1.VisibleIndex = 0;
        col1.MinWidth = 240;
        col1.Width = 240;
        col1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;


        TreeListColumn col2 = tl.Columns.Add();
        col2.Caption = "";
        col2.VisibleIndex = 1;
        col2.MinWidth = 80;
        col2.Width = 80;
        col2.OptionsColumn.AllowSort = false;
        col2.OptionsColumn.AllowMoveToCustomizationForm = false;
        col2.OptionsColumn.AllowMove = false;
        col2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        

        tl.EndUpdate();
    }

    public  TreeListNode CreateRootNodeWithCustomerAccountNumber(string customerAccNo)
    {
        // Create a root node .
        TreeListNode parentForRootNodes = null;

        TreeListNode nodeCustomerAccNo = tl.AppendNode(
           new object[] { customerAccNo   }, parentForRootNodes);

        
        return nodeCustomerAccNo;
    }

    public TreeListNode CreatePLUNode(string pluDescription, decimal pluPrice)
    {
        TreeListNode parentForPluNodes = null;

        TreeListNode nodePLU = tl.AppendNode(
        new object[] { pluDescription,pluPrice }, parentForPluNodes);

        return nodePLU;
    }

    public TreeListNode CreatePLUNodeExtra(TreeListNode nodePLU, string pluExtraDescription, decimal? pluExtraPrice)
    {
        TreeListNode nodePluExtra = tl.AppendNode(new object[] { pluExtraDescription,(pluExtraPrice==null)? "" : pluExtraPrice.Value.ToString()  }, nodePLU);

        //tl.AppendNode("", nodePLU);

         return nodePluExtra;
    }
    
}