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

namespace InventarioLibros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void libroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.libroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Libro' Puede moverla o quitarla según sea necesario.
            this.libroTableAdapter.Fill(this.bibliotecaDataSet.Libro);

        }

        private void fillByAutorToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.libroTableAdapter.FillByAutor(this.bibliotecaDataSet.Libro, autorToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string message = "Has elegido eliminar el libro " + nombreTextBox.Text + ". Estas seguro?";
            string caption = "Eliminando libro...";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(this, message, caption, buttons);

            if (result == DialogResult.Yes)
            {

                try
                {
                    //Con DataSet
                    this.libroTableAdapter.Delete(Convert.ToInt32(this.idLibroTextBox.Text),
                        Convert.ToInt32(this.idCategoriaTextBox.Text),
                        this.nombreTextBox.Text,
                        this.autorTextBox.Text,
                        this.fechaPublicacionDateTimePicker.Value);

                }
                catch
                {

                    MessageBox.Show("El libro no se ha podido eliminar.");
                }

            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
                //Con ADO.NET
                // Create the connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.BibliotecaConnectionString))
                {
                    // Create the SqlCommand object and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand("Biblioteca.dbo.spUpdateLibro", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Add parameters for the stored procedure.
                        sqlCommand.Parameters.Add(new SqlParameter("@IdLibro", SqlDbType.Int));
                        sqlCommand.Parameters["@IdLibro"].Value = Convert.ToInt32(this.idLibroTextBox.Text);

                        sqlCommand.Parameters.Add(new SqlParameter("@IdCategoria", SqlDbType.Int));
                        sqlCommand.Parameters["@IdCategoria"].Value = Convert.ToInt32(this.idCategoriaTextBox.Text);

                        sqlCommand.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                        sqlCommand.Parameters["@Nombre"].Value = this.nombreTextBox.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@Autor", SqlDbType.VarChar));
                        sqlCommand.Parameters["@Autor"].Value = this.autorTextBox.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@FechaPublicacion", SqlDbType.Date));
                        sqlCommand.Parameters["@FechaPublicacion"].Value = this.fechaPublicacionDateTimePicker.Value;


                        try
                        {
                            // Open the connection.
                            connection.Open();

                            // Run the command to execute the stored procedure.
                            sqlCommand.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se h podido modificar el libro." + ex.Message);
                        }
                        finally
                        {
                            // Close connection.
                            connection.Close();
                        }
                    }
                }
            }
        
    }
    
}
