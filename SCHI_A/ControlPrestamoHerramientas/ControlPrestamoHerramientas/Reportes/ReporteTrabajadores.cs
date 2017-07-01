using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlPrestamoHerramientas.Reportes
{
    public partial class ReporteTrabajadores : Form
    {
        public ReporteTrabajadores()
        {
            InitializeComponent();
        }

        private void ReporteTrabajadores_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
