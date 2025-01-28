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

        public void Menucontexto(bool Menucontexto)
        {
            menuContextoToolStripMenuItem.Visible = Menucontexto;
        }

        private void childFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menucontexto(true);
            ChildForm Child = new ChildForm(this);
            Child.MdiParent = this;
            Child.Show();

        }

        private void limparCamposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm Child = new ChildForm(this);
            Child.Limparcontexto();

        }
}
}
