using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
