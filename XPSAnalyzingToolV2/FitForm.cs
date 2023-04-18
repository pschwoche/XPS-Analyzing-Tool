using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPSAnalyzingTool
{
    public partial class FitForm : Form
    {
        public FitForm()
        {
           InitializeComponent();
            this.Visible = true;
          
        }

        private void FitForm_Load(object sender, EventArgs e)
        {

                // Füge Wurzelknoten zum TreeView hinzu
                TreeNode rootNode = new TreeNode("Personen");
                treeView1.Nodes.Add(rootNode);

                // Füge Kindknoten zum Wurzelknoten hinzu
                TreeNode person1Node = new TreeNode("Person 1");
                person1Node.Nodes.Add("Name: John");
                person1Node.Nodes.Add("Alter: 30");
                person1Node.Nodes.Add("Haarfarbe: Braun");
                rootNode.Nodes.Add(person1Node);

                // Füge einen weiteren Kindknoten hinzu
                TreeNode person2Node = new TreeNode("Person 2");
                person2Node.Nodes.Add("Name: Jane");
                person2Node.Nodes.Add("Alter: 25");
                person2Node.Nodes.Add("Haarfarbe: Blond");
                rootNode.Nodes.Add(person2Node);

                // Erweitere den Wurzelknoten
                treeView1.ExpandAll();
            
        }
    }
}