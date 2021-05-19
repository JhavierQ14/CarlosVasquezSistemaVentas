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
using SistemaVentasP2.DAO;
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
           
            {
                
                    ClsDCliente clsDClientes = new ClsDCliente();



                    comboBox2.DataSource = clsDClientes.cargarComboCliente();
                    comboBox2.DisplayMember = "nombreCliente";
                    comboBox2.ValueMember = "iDCliente";


                ClsDDocumento clsDDocumento = new ClsDDocumento();

                    comboBox1.DataSource = clsDDocumento.cargarDocumento();
                    comboBox1.DisplayMember = "nombreDocumento";
                    comboBox1.ValueMember = "iDDocumento";
               
            }
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto buscar = new FrmBuscarProducto();
            buscar.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string precio = dataGridView1.CurrentRow.Cells[2].Value.ToString();


      
            this.Close();

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