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
    public partial class ChildForm : Form
    {
        private MainForm _MainForm;
        public ChildForm(MainForm MainForm)
        {
            InitializeComponent();
            _MainForm = MainForm;
        }

        public void Limparcontexto()
        {
            textBox_Nome.Text = string.Empty;
            textBox_Apelido.Text = string.Empty;
            textBox_Idade.Text = string.Empty;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            _MainForm.Menucontexto(false);
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limparcontexto();

        }

        private void ChildForm_Load(object sender, EventArgs e)
        {
            _MainForm.Menucontexto(true);
        }

        private void ChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _MainForm.Menucontexto(false);
        }
    }
}
