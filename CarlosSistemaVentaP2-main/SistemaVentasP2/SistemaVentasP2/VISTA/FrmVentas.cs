using SistemaVentasP2.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentasP2.VISTA
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                try
                {
                    var consultacliente = db.tb_cliente.ToList();

                    comboBox2.DataSource = consultacliente;
                    comboBox2.DisplayMember = "nombreCliente";
                    comboBox2.ValueMember = "iDCliente";

                    var consultadocumento = db.tb_documento.ToList();

                    comboBox2.DataSource = consultadocumento;
                    comboBox2.DisplayMember = "nombreDocumento";
                    //comboBox2.ValueMember = "iDDocuemnto ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
