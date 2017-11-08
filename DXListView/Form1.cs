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

namespace DXListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnVOID_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    //The operation class that collects checked nodes
    class GetCheckedNodesOperation : TreeListOperation
    {
        public List<TreeListNode> CheckedNodes = new List<TreeListNode>();
        public GetCheckedNodesOperation() : base() { }
        public override void Execute(TreeListNode node)
        {
            if (node.CheckState != CheckState.Unchecked)
                CheckedNodes.Add(node);
        }
    }
}
