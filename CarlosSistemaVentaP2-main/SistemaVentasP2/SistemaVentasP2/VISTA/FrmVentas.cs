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

                    comboBox1.DataSource = consultadocumento;
                    comboBox1.DisplayMember = "nombreDocumento";
                    comboBox1.ValueMember = "iDDocumento";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

    }
}
//var consultacliente = bd.tb_cliente.ToList();

//cbxClient.DataSource = consultacliente;
//cbxClient.DisplayMember = "nombreCliente";
//cbxClient.ValueMember = "iDCliente";

//var consultadocumento = bd.tb_documento.ToList();
//cbxTdocument.DataSource = consultadocumento;
//cbxTdocument.DisplayMember = "nombreDocumento";
//cbxTdocument.ValueMember = "iDDocumento";