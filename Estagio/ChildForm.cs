﻿using System;
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

        public ChildForm()
        {
            InitializeComponent();
        }


        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     }
}
