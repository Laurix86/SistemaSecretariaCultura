using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClasesSecretaria
{
    [Serializable]
    public class Artista
    {
        #region atributos de instancia

        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nacionalidad;
        private DateTime _fechaNacimiento;
        private DateTime _fechaFallecimiento;
        
        #endregion

        #region constructores

        public Artista(string pnom, string papel, string pnac, DateTime pfnac)
        {
            
            this.Nombre = pnom;
            this.Apellido = papel;
            this.Nacionalidad = pnac;
            this.FechaNacimiento = pfnac;
        }
        public Artista(int pid, string pnom, string papel, string pnac, DateTime pfn, DateTime pff)
        {
            this.Id = pid;
            this.Nombre = pnom;
            this.Apellido = papel;
            this.Nacionalidad = pnac;
            this.FechaNacimiento = pfn;
            if (pff != DateTime.MinValue)
            {
                this.FechaFallecimiento = pff;
            }

        }
       
        #endregion

        #region propiedades
        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Nacionalidad
        {
            get { return _nacionalidad; }
            set { _nacionalidad = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public DateTime FechaFallecimiento
        {
            get { return _fechaFallecimiento; }
            set { _fechaFallecimiento = value; }
        }
        #endregion
        #region consultas

        public bool Equals(Artista a)
        {
            if(this.Nombre == a.Nombre && this.Apellido == a.Apellido && this.FechaNacimiento.Year == a.FechaNacimiento.Year) //agregar fecha fallecimiento
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return this.Apellido + ", " + this.Nombre + " - F.Nac: " + this.FechaNacimiento.ToString("dd/MM/yyyy");
        }

        #endregion

        #region comandos


        #endregion
    } //fin clase artista

    [Serializable]
    public class ColeccionArtistas
    {
        private List<Artista> ColArtistas;
        private List<Artista> auxList;
        private int contador;

        public ColeccionArtistas()
        {
            ColArtistas = new List<Artista>();
        }

        public int CantidadArtistas()
        {
            return ColArtistas.Count();
        }

        public void AgregarArtista(Artista a)
        {
            ColArtistas.Add(a);
        }

        public bool ExisteArtista(Artista a)
        {
            
            foreach(Artista elem in ColArtistas)
            {

                if (elem.Equals(a))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Artista> ArtistaPorApellido(string ape)
        {
            auxList = new List<Artista>();

            foreach(Artista art in ColArtistas)
            {
                if (art.Apellido.ToUpper().Contains(ape.ToUpper()))
                {
                    auxList.Add(art);
                }
            }
            return auxList;
        }

        public List<Artista> ArtistaPorNombreCompleto(string nom) 
        {
            auxList = new List<Artista>();
            foreach (Artista art in ColArtistas)
            {
                if (art.Nombre.Contains(nom.ToUpper()) || art.Apellido.Contains(nom.ToUpper()))
                {
                    auxList.Add(art);
                }
            }
            return auxList;
        }

        public List<Artista> ArtistaPorNacimiento(int anio)
        {
            auxList = new List<Artista>();

            foreach(Artista art in ColArtistas)
            {
                if(art.FechaNacimiento.Year == anio)
                {
                    auxList.Add(art);
                }
            }

            return auxList;
        }

        public List<Artista> ArtistaPorFallecimiento(int anio)
        {
            auxList = new List<Artista>();

            foreach (Artista art in ColArtistas)
            {
                if (art.FechaFallecimiento.Year == anio)
                {
                    auxList.Add(art);
                }
            }

            return auxList;
        }

        public Artista ArtistaPorId(int pid)
        {
            foreach(Artista art in ColArtistas)
            {
                if(art.Id == pid)
                {
                    return art;
                }
            }
            return null;
        }

        public List<Artista> ArtistaPorNacionalidad(string nac)
        {
            auxList = new List<Artista>();
            foreach(Artista art in ColArtistas)
            {
                if(art.Nacionalidad.Contains(nac.ToUpper()))
                {
                    auxList.Add(art);
                }
            }
            return auxList;

        }

       


    }
}
