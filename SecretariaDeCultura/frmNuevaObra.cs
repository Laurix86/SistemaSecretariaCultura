using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesSecretaria;
namespace SecretariaDeCultura
{
    public partial class frmNuevaObra : Form
    {
        int ID;
        public frmNuevaObra()
        {
            InitializeComponent();
        }

        private void frmNuevaObra_Load(object sender, EventArgs e)
        {
            ID = Program.colObras.CantidadObras() + 1;
            txtIdObra.Text = Convert.ToString(ID);
            CargarComboAutor();

        }
        public bool ValidarDatos()
        {
            bool respuesta = false;
            /*if (txtIdObra.Text == "")
            { respuesta = false; }*/
            if (txtNombreObra.Text == "")
            {
                Mensajes(lblMsjNombreObra, "Completar nombre de la Obra");
                
            } else if (cbxAutorObra.SelectedIndex < 0)
            { Mensajes(lblMsjAutorObra, "Elegir un artista"); 
            } else if (!mskFCreacionObra.MaskCompleted)
            { Mensajes(lblMsjFCreaObra, "Completar fecha de creación"); 
            } else if (!mskFIngresoObra.MaskCompleted)
            { Mensajes(lblMsjFIngObra, "Completar fecha de ingreso"); 
            } else if ((rbCuadroObra.Checked && (txtAlturaObra.Text=="" || txtBaseObra.Text==""))|| (rbEsculturaObra.Checked && (txtVolumenObra.Text=="" || txtPesoObra.Text=="")))
            { Mensajes(lblMsjDimObra, "Completar los datos pedidos"); 
            }else
            {
                respuesta = true;
            }

            return respuesta;
        }
        private void btnGuardarObra_Click(object sender, EventArgs e)
        {  
            if (ValidarDatos())
            {
                
                string nombre = txtNombreObra.Text;
                int ind = cbxAutorObra.SelectedIndex + 1;
                Artista autor = Program.colArtistas.ArtistaPorId(ind);
                DateTime fIng = System.Convert.ToDateTime(mskFIngresoObra.Text);
                DateTime fCrea = System.Convert.ToDateTime(mskFCreacionObra.Text);
                decimal pBase, pAltura, pPeso, pVol;
                Obra auxObra;

                if (rbCuadroObra.Checked == true)
                {
                    bool tryBase = Decimal.TryParse(txtBaseObra.Text, out pBase);
                    bool tryAltura = Decimal.TryParse(txtAlturaObra.Text, out pAltura);

                    if (!tryBase || !tryAltura)
                    {
                        Mensajes(lblMsjDimObra, "Completar las dimensiones correctamente.");
                    }
                    else
                    {
                        auxObra = new Cuadro(ID, nombre, autor, fCrea, fIng, pBase, pAltura);
                        if (ExisteObra(auxObra))
                        {
                            MessageBox.Show("Este Cuadro ya fue registrado");
                        }
                        else
                        {
                            Program.colObras.AgregarObra(auxObra);
                            Mensajes(lblMsjGuardarObra, "Obra guardada");
                            LimpiarCasilleros();

                        }
                    }
                } else if (rbEsculturaObra.Checked == true)
                {
                    bool tryVol = Decimal.TryParse(txtVolumenObra.Text, out pVol);
                    bool tryPeso = Decimal.TryParse(txtPesoObra.Text, out pPeso);

                    if (!tryVol || !tryPeso)
                    {
                        Mensajes(lblMsjDimObra, "Completar las dimensiones correctamente.");
                    }else
                    {
                        auxObra = new Escultura(ID, nombre, autor, fCrea, fIng, pPeso, pVol);
                        if (ExisteObra(auxObra))
                        {
                            MessageBox.Show("Esta Escultura ya fue registrada");

                        }
                        else
                        { 
                            Program.colObras.AgregarObra(auxObra);
                            Mensajes(lblMsjGuardarObra, "Obra guardada");
                            

                            LimpiarCasilleros();
                        }
                    }
                }

            } 
        }

        public bool ExisteObra(Obra obj)
        {
            bool existe = false;                         
                if (Program.colObras.ExisteObra(obj))
                {
                    existe = true;
                }
                else
                {
                    existe = false;
                }
            return existe;
        }

        private void rbCuadroObra_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEsculturaObra.Checked)
            {
                txtPesoObra.Visible = true;
                txtVolumenObra.Visible = true;
                txtBaseObra.Visible = false;
                txtAlturaObra.Visible = false;
            }
            else if (rbCuadroObra.Checked)
            {
                txtBaseObra.Visible = true;
                txtAlturaObra.Visible = true;
                txtPesoObra.Visible = false;
                txtVolumenObra.Visible = false;
            }
        }

        private void btnNuevoAutorObra_Click(object sender, EventArgs e)
        {
            frmNuevoArtista frmAutor = new frmNuevoArtista();
            frmAutor.ShowDialog();
            CargarComboAutor();
        }

        private void CargarComboAutor()
        {
            cbxAutorObra.Items.Clear();
            int cantArt = Program.colArtistas.CantidadArtistas();
            if (cantArt > 0)
            {
                for (int i = 1; i <= cantArt; i++)
                {
                    cbxAutorObra.Items.Add(Program.colArtistas.ArtistaPorId(i).Id + " - " + Program.colArtistas.ArtistaPorId(i).Apellido + " " + Program.colArtistas.ArtistaPorId(i).Nombre);

                }
            }
        }

        private void LimpiarCasilleros()
        {
            txtNombreObra.Text = "";
            cbxAutorObra.SelectedIndex = -1;
            mskFCreacionObra.Text = "";
            mskFIngresoObra.Text = "";
            txtAlturaObra.Text = "";
            txtBaseObra.Text = "";
            txtVolumenObra.Text = "";
            txtPesoObra.Text = "";
            ID = Program.colObras.CantidadObras() + 1;
            txtIdObra.Text = Convert.ToString(ID);
        }


        
        private async void Mensajes(Label p_lbl, string p_mensaje)
        {
            p_lbl.Text = p_mensaje;
            await Task.Delay(2500);
            p_lbl.Text = "";

        }

        private void btnCancelarObra_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }

}
    


           


    


