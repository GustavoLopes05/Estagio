using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Estagio
{
    public partial class MainForm : Form
    {

        public static ChildForm myFormInstance;

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

            if (myFormInstance == null || myFormInstance.IsDisposed)
            {
                myFormInstance = new ChildForm(this);
                myFormInstance.MdiParent = this;
                myFormInstance.Size = this.Size;
                myFormInstance.Show();
            }
            else
            {
                myFormInstance.Focus(); // Bring it to the front
            }
   

        }

        private void limparCamposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myFormInstance.Limparcontexto();

        }
}
}
