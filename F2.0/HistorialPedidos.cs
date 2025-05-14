using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HistorialPedidos : Form
    {
        public HistorialPedidos()
        {
            InitializeComponent();
        }

        private void HistorialPedidos_Load(object sender, EventArgs e)
        {
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CargarHPedidos();
        }

        private void CargarHPedidos()
        {
            string conexionString = "Data Source=MAURICIO;Initial Catalog=LoginFloraria;Integrated Security=True";
            string query = "SELECT * FROM HPedidos";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
        }

        private void CargarHProductosPorIdPedido(int idPedido)
        {
            string conexionString = "Data Source=MAURICIO;Initial Catalog=LoginFloraria;Integrated Security=True";
            string query = "SELECT * FROM HProductos WHERE IdPedidos = @IdPedidos";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdPedidos", idPedido);

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView2.DataSource = tabla;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

                // Asegúrate de que la columna se llama "Id" en tu tabla HPedidos
                int idPedido = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);

                // Llama la función para cargar los productos relacionados
                CargarHProductosPorIdPedido(idPedido);
            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBoxBuscar.Text.Replace("'", "''"); // Para evitar errores con comillas

            // Aplica el filtro al DataGridView1, verificando columnas como IdTicket, Nombre, etc.
            if (dataGridView1.DataSource is DataTable tabla)
            {
                tabla.DefaultView.RowFilter =
                    $"Convert(IdTicket, 'System.String') LIKE '%{filtro}%' OR " +        // Filtra por IdTicket
                    $"Nombre LIKE '%{filtro}%' OR " +                                    // Filtra por Nombre
                    $"Telefono LIKE '%{filtro}%' OR " +                                  // Filtra por Telefono
                    $"Domicilio LIKE '%{filtro}%' OR " +                                 // Filtra por Domicilio
                    $"Convert(FechaEntrega, 'System.String') LIKE '%{filtro}%' OR " +    // Filtra por FechaEntrega
                    $"Convert(HoraEntrega, 'System.String') LIKE '%{filtro}%' OR " +     // Filtra por HoraEntrega
                    $"MetodoPago LIKE '%{filtro}%' OR " +                                // Filtra por MetodoPago
                    $"Convert(Subtotal, 'System.String') LIKE '%{filtro}%' OR " +        // Filtra por Subtotal
                    $"Convert(PagoTotal, 'System.String') LIKE '%{filtro}%' OR " +       // Filtra por PagoTotal
                    $"Convert(PuntosAntes, 'System.String') LIKE '%{filtro}%' OR " +     // Filtra por PuntosAntes
                    $"Convert(PuntosRestantes, 'System.String') LIKE '%{filtro}%' OR " + // Filtra por PuntosRestantes
                    $"Convert(PuntosObtenidos, 'System.String') LIKE '%{filtro}%' OR " + // Filtra por PuntosObtenidos
                    $"Convert(PuntosDespues, 'System.String') LIKE '%{filtro}%'";        // Filtra por PuntosDespues
            }
        }

        private void pictureBoxRegresar_Click(object sender, EventArgs e)
        {

        }
    }
}
