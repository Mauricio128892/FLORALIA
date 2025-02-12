using System;
using System.Windows.Forms;

namespace MAURIYYOO2
{
    public partial class Form1 : Form
    {
        private Inventario inventario;

        private void Form1_Load(object sender, EventArgs e) // Cuerpo del método Form1_Load agregado
        {
            // Aquí puedes agregar el código que quieres ejecutar cuando se carga el formulario
            // Por ejemplo, cargar datos, inicializar componentes, etc.
        }

        public Form1()
        {
            InitializeComponent();
            inventario = new Inventario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los TextBox
                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text;
                int cantidad = int.Parse(txtCantidad.Text);
                decimal precio = decimal.Parse(txtPrecio.Text);

                // Crear un nuevo producto
                Producto nuevoProducto = new Producto(id, nombre, cantidad, precio);

                // Agregar el producto al inventario
                inventario.AgregarProducto(nuevoProducto);

                // Mostrar un MessageBox de éxito
                MessageBox.Show("Producto agregado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los TextBox después de agregar el producto
                txtId.Clear();
                txtNombre.Clear();
                txtCantidad.Clear();
                txtPrecio.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: ID, Cantidad y Precio deben ser números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Mostrar un MessageBox con el error si algo sale mal
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarInventario_Click(object sender, EventArgs e)
        {
            // Limpiar el ListBox antes de mostrar los productos
            lstInventario.Items.Clear();

            // Mostrar todos los productos del inventario
            foreach (var producto in inventario.Productos.Values) // Acceder a la colección de valores del diccionario
            {
                lstInventario.Items.Add(producto.ToString()); // .ToString() para mostrar la representación en cadena del producto
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MostrarInventario_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lstInventario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}