using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using ClasesSecretaria;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretariaDeCultura
{
    public partial class frmNuevoPrestamo : Form
    {
        int id;
        public frmNuevoPrestamo()
        {
            InitializeComponent();
        }

        private void frmNuevoPrestamo_Load(object sender, EventArgs e)
        {
            CargarCombobox();
            InicializarControles();
        }

        private void btnGuardarPrestamo_Click(object sender, EventArgs e)
        {
            if (InputsCompletos()) {

                string auxString = "";
                int indObra = cbxObrasPrestamo.SelectedIndex + 1;
                
                Obra auxObra = Program.colObras.ObraPorId(indObra);
                DateTime fDesde = Convert.ToDateTime(mkdDesdePrestamo.Text);
                DateTime fHasta = Convert.ToDateTime(mkdHastaPrestamo.Text);
                int indCentro = cbxCentroPrestamo.SelectedIndex + 1;
                MessageBox.Show("id centro " + indCentro);
                CentroCultural auxCentro = Program.colCentros.CentrosPorId(indCentro);
                Prestamo auxPres = new Prestamo(id, auxObra, fDesde, fHasta, auxCentro);
                Program.colPrestamos.ComprobarDisponibilidadObra(auxPres, ref auxString);

                if(auxString != "")
                {
                    MessageBox.Show(auxString);
                } else
                {
                    Program.colPrestamos.AgregarPrestamos(auxPres);
                    Mensajes(lblMsjGuardadoPrestamo, "Prestamo registrado exitosamente.");
                    InicializarControles();
                }
            }
        }

        
        private void btnAddObraPrestamo_Click(object sender, EventArgs e)
        {
            frmNuevaObra frmObra = new frmNuevaObra();
            frmObra.ShowDialog();

            CargarCombobox();
        }

        private void btnAddCentroPrestamo_Click(object sender, EventArgs e)
        {
            frmNuevoCentro frmCentro = new frmNuevoCentro();
            frmCentro.ShowDialog();
            CargarCombobox();

        }

        private void CargarCombobox()
        {
            int cantCentros = Program.colCentros.CantidadDeCentros();
            int cantObras = Program.colObras.CantidadObras();
            CentroCultural auxCentro;
            cbxObrasPrestamo.Items.Clear();
            cbxCentroPrestamo.Items.Clear();

            
            if (cantCentros > 0)
            {
                for (int i = 1; i <= cantCentros; i++)
                {
                    auxCentro = Program.colCentros.CentrosPorId(i);
                    cbxCentroPrestamo.Items.Add(auxCentro.Nombre);
                }
            }

            if (cantObras > 0)
            {
                for (int i = 1; i <= cantObras; i++)
                {
                    cbxObrasPrestamo.Items.Add(Program.colObras.ObraPorId(i).Nombre);
                }
            }
        }

        private bool InputsCompletos()
        {
            bool completo = false;

            if(cbxObrasPrestamo.SelectedIndex == -1)
            {
                Mensajes(lblMsjObraPrestamo, "Seleccione una obra a prestar");
            } else if(cbxCentroPrestamo.SelectedIndex == -1)
            {
                Mensajes(lblMsjCentroPrestamo, "Seleccione un Centro Cultural");
            } else if (!mkdDesdePrestamo.MaskCompleted || !mkdHastaPrestamo.MaskCompleted)
            {
                Mensajes(lblMsjFechaPrestamo, "Complete las fecha correctamente");
            }
            else
            {
                completo = true;
            }
            return completo;
        }
        private void InicializarControles()
        {
            id = Program.colPrestamos.CantidadPrestamos() + 1;
            txtIdPrestamo.Text = Convert.ToString(id);
            cbxObrasPrestamo.SelectedIndex = -1;
            cbxCentroPrestamo.SelectedIndex = -1;
            mkdDesdePrestamo.Text = "";
            mkdHastaPrestamo.Text = "";
        }
       
        private async void Mensajes(Label p_lbl, string p_mensaje)
        {
            p_lbl.Text = p_mensaje;
            await Task.Delay(2500);
            p_lbl.Text = "";

        }

        private void btnCancelarPrestamo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiarPrestamo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }
    }
}
