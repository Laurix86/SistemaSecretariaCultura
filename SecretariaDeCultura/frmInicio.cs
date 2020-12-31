
using System;
using ClasesSecretaria;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SecretariaDeCultura
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            string fileName;
            BinaryFormatter deserializer = new BinaryFormatter();
            Stream openFileStream;
            string directory = Application.StartupPath;

            // Obras 
            fileName = directory + "\\ColObras.bin";
            if (File.Exists(fileName))
            {
                openFileStream = File.OpenRead(fileName);
                try
                {
                    //deserializer = new BinaryFormatter();
                    Program.colObras = (ColeccionObras)deserializer.Deserialize(openFileStream);
                }
                catch { }
                finally { }
                openFileStream.Close();
            }
            // Artistas
            fileName = directory + "\\ColArtistas.bin";
            if (File.Exists(fileName))
            { 
                openFileStream = File.OpenRead(fileName);
                try
                {
                    //deserializer = new BinaryFormatter();
                    Program.colArtistas = (ColeccionArtistas)deserializer.Deserialize(openFileStream);
                }
                catch { }
                finally { }
                openFileStream.Close();
            }

            // Centros
            fileName = directory + "\\ColCentros.bin";
            if (File.Exists(fileName))
            { 
                openFileStream = File.OpenRead(fileName);
                try
                {
                    //deserializer = new BinaryFormatter();
                    Program.colCentros = (ColeccionCentros)deserializer.Deserialize(openFileStream);
                }
                catch { }
                finally { }
                openFileStream.Close();
            }

            // Prestamos
            fileName = directory + "\\ColPrestamos.bin";
            if (File.Exists(fileName))
            { 
                openFileStream = File.OpenRead(fileName);
                try
                {
                    //deserializer = new BinaryFormatter();
                    Program.colPrestamos = (ColeccionPrestamos)deserializer.Deserialize(openFileStream);
                }
                catch { }
                finally { }
                openFileStream.Close();
            }

                MessageBox.Show("Información de la Secretaría recuperada correctamente");
        }

        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            string fileName;
            Stream SaveFileStream;
            BinaryFormatter serializer = new BinaryFormatter();

            string directory = Application.StartupPath;

            // Obras
            fileName = directory + "\\ColObras.bin";
            SaveFileStream = File.OpenWrite(fileName);
           // serializer = new BinaryFormatter();
            serializer.Serialize(SaveFileStream, Program.colObras);
            SaveFileStream.Close();

            // Artistas
            fileName = directory + "\\ColArtistas.bin";
            SaveFileStream = File.OpenWrite(fileName);
           // serializer 
            serializer.Serialize(SaveFileStream, Program.colArtistas);
            SaveFileStream.Close();

            // Centros
            fileName = directory + "\\ColCentros.bin";
            SaveFileStream = File.OpenWrite(fileName);
           // serializer = new BinaryFormatter();
            serializer.Serialize(SaveFileStream, Program.colCentros);
            SaveFileStream.Close();

            // Prestamos
            fileName = directory + "\\ColPrestamos.bin";
            SaveFileStream = File.OpenWrite(fileName);
           // serializer = new BinaryFormatter();
            serializer.Serialize(SaveFileStream, Program.colPrestamos);
            SaveFileStream.Close();

            MessageBox.Show("Información guardada");
            Application.Exit();
        }

        private void btnNuevaObra_Click(object sender, EventArgs e)
        {
            frmNuevaObra frmObra = new frmNuevaObra();
            frmObra.ShowDialog();
        }

        private void btnNuevArtista_Click(object sender, EventArgs e)
        {
            frmNuevoArtista frmArtista = new frmNuevoArtista();
            frmArtista.ShowDialog();
        }

        private void btnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            frmNuevoPrestamo frmPrestamo = new frmNuevoPrestamo();
            frmPrestamo.ShowDialog();
        }

        private void btnNuevoCentro_Click(object sender, EventArgs e)
        {
            frmNuevoCentro frmCentro = new frmNuevoCentro();
            frmCentro.ShowDialog();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            frmConsulta frmConsulta = new frmConsulta();
            frmConsulta.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
