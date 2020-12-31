using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ClasesSecretaria;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretariaDeCultura
{
    public partial class frmNuevoCentro : Form
    {
        int id;
        public frmNuevoCentro()
        {
            InitializeComponent();
        }

        private void frmNuevoCentro_Load(object sender, EventArgs e)
        {
            ComboListaProvincias();
            id = Program.colCentros.CantidadDeCentros() + 1;
            txtIdCentro.Text = Convert.ToString(id);
        }

        private void btnGuardarCentro_Click(object sender, EventArgs e)
        {
            if (InputsCompletos())
            {
                if (ExisteCentro())
                {
                    MessageBox.Show("El centro: " + txtNombreCentro.Text + " ya se encuentra registrado.");
                }else
                {
                    
                    string prov = (string)cbxProvinciaCentro.SelectedItem;
                    CentroCultural auxCentro = new CentroCultural(id, txtNombreCentro.Text, txtLocalidadCentro.Text,prov);
                    Program.colCentros.AgregarCentro(auxCentro);
                    Mensajes(lblMsjGuardadoCentro, "Centro guardado exitosamente!");
                    txtNombreCentro.Text = "";
                    txtLocalidadCentro.Text = "";
                    cbxProvinciaCentro.Text = "";
                    id = Program.colCentros.CantidadDeCentros() + 1;
                    txtIdCentro.Text = Convert.ToString(id);
                }
            }
        }
        private bool InputsCompletos()
        {

            bool completo = false;

            if(txtNombreCentro.Text == "")
            {
                Mensajes(lblMsjNameCentro, "Ingrese el nombre del Centro.");
            }else if(txtLocalidadCentro.Text == "")
            {
                Mensajes(lblMsjLocCentro, "Ingrese la localidad del Centro.");
            } else if (cbxProvinciaCentro.Text == "")
            {
                Mensajes(lblMsjProvCentro, "Ingrese la provincia del Centro.");
            }
            else
            {
                completo = true;
            }
            return completo;
        }

        private bool ExisteCentro()
        {
            CentroCultural auxCentro = new CentroCultural(0, txtNombreCentro.Text, txtLocalidadCentro.Text, cbxProvinciaCentro.Text);

            if (Program.colCentros.ExisteCentro(auxCentro))
            {
                return true;
            }
            else return false;
        }
        private async void Mensajes(Label p_lbl, string p_mensaje)
        {
            p_lbl.Text = p_mensaje;
            await Task.Delay(2500);
            p_lbl.Text = "";

        }

        private void ComboListaProvincias()
        {
            foreach(string p in Program.listaProvincias)
            {
                cbxProvinciaCentro.Items.Add(p);
            }
        }

        
        private void btnCancelarCentro_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
