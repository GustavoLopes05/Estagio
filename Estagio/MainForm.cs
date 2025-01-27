using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estagio
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            InitializeComponent();
        }

        public void MenuContexto()
        {
            menuContextoToolStripMenuItem.Visible = false;
        }

        private void childFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuContextoToolStripMenuItem.Visible = true;
            ChildForm Child = new ChildForm();
            Child.MdiParent = this;
            Child.Show();

        }

    }
}
