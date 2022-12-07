using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treeview_control1 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode tNode;
            tNode = treeView1.Nodes.Add("Websites"); // root node : level_0 node
            treeView1.Nodes[0].Nodes.Add("Net-informations.com"); // level_1 node
            treeView1.Nodes[0].Nodes[0].Nodes.Add("CLR"); // level_2 node
            treeView1.Nodes[0].Nodes.Add("Vb.net-informations.com"); // level_1 node
            treeView1.Nodes[0].Nodes[1].Nodes.Add("String Tutorial"); // level_2 node
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Excel Tutorial"); // level_2 node
            treeView1.Nodes[0].Nodes.Add("Csharp.net-informations.com"); // level_1 node
            treeView1.Nodes[0].Nodes[2].Nodes.Add("ADO.NET"); // level_2 node
            treeView1.Nodes[0].Nodes[2].Nodes[0].Nodes.Add("Dataset"); // level_3 node
            TreeNode tNode1;
            tNode1 = treeView1.Nodes.Add("C language"); // root node : level_0 node
            treeView1.Nodes[1].Nodes.Add("Java language"); // level_1 node
            treeView1.Nodes[1].Nodes[0].Nodes.Add("C# language"); // level_2 node
            treeView1.Nodes[1].Nodes.Add("C++ language"); // level_1 node
            treeView1.ExpandAll();

        }
        //ss
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.FullPath.ToString());
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
