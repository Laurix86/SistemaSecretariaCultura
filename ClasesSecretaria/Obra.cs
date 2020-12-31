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
    public abstract class Obra
    {
        #region atributos de instancia
        private int _id;
        private string _nombre;
        private Artista _autor;
        private DateTime _fechaCreacion;
        private DateTime _fechaIngreso;

        #endregion

        #region constructores
        public Obra(int pid, string pnom, Artista part, DateTime pfc, DateTime pfi)
        {
            this.Id = pid;
            this.Nombre = pnom;
            this.Autor = part;
            this.FechaCreacion = pfc;
            this.FechaIngreso = pfi;
        }
        #endregion

        #region propiedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nombre {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public Artista Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }
        public DateTime FechaCreacion {
            get { return _fechaCreacion; }
            set { _fechaCreacion = value; }

        }
        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }

        #endregion

        #region consultas
        public abstract string Dimensiones();

        public bool Equals(Obra o)
        {
            return this.Nombre == o.Nombre && this.FechaCreacion == o.FechaCreacion && this.Autor == o.Autor && this.GetType() == o.GetType();
        }
        #endregion
    } // fin clase Obra

    [Serializable]
    public class Escultura : Obra
    {
        private decimal _peso;
        private decimal _volumen;

        #region constructores
        public Escultura(int pid, string pnom, Artista part, DateTime pfc, DateTime pfi, decimal ppeso, decimal pvol) : base(pid, pnom, part, pfc, pfi)
        {
            this.Peso = ppeso;
            this.Volumen = pvol;
        }
        #endregion

        #region propiedades
        public decimal Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        public decimal Volumen
        {
            get { return _volumen; }
            set { _volumen = value; }
        }
        #endregion

        #region consultas
        public override string Dimensiones()
        {
            return "Peso: " + this.Peso + " Volumen: " + this.Volumen;
        }


        public override string ToString()
        {

            return "Escultura => Nombre: " + this.Nombre + " - F. Creación: " + this.FechaCreacion.ToString("dd/MM/yyyy");

        }
        #endregion
    } // clase Escultura

    [Serializable]
    public class Cuadro : Obra
    {
        private decimal _base;
        private decimal _altura;

        #region constructores
        public Cuadro(int pid, string pnom, Artista part, DateTime pfc, DateTime pfi, decimal pbase, decimal palt) : base(pid, pnom, part, pfc, pfi)
        {
            this.Base = pbase;
            this.Altura = palt;
        }
        #endregion

        #region propiedades
        public decimal Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public decimal Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }
        #endregion

        #region consultas
        public override string Dimensiones()
        {
            return "Base: " + this.Base + " Altura: " + this.Altura;
        }

        public override string ToString() {

            return "Cuadro => Nombre: " + this.Nombre + " - F. Creación: " + this.FechaCreacion.ToString("dd/MM/yyyy");

        }
    }// fin clase Cuadro

    #endregion


    [Serializable]
    public class ColeccionObras
    {
        private List<Obra> ColObras;
        private List<Obra> auxList;
        private int contador;

        public ColeccionObras()
        {
            ColObras = new List<Obra>();
        }

        public void AgregarObra(Obra o)
        {
            ColObras.Add(o);
        }

        public bool ExisteObra(Obra o)
        {
            foreach (Obra obra in ColObras)
            {
                if (obra.Equals(o))
                {
                    return true;
                }

            }
            return false;
        }
        public int CantidadObras()
        {
            return ColObras.Count();
        }
        public Obra ObraPorId(int pid)
        {
            foreach (Obra o in ColObras)
            {
                if (o.Id == pid)
                {
                    return o;
                }
            }
            return null;
        }

        public List<Obra> ObraPorNombre(string nom)
        {
            auxList = new List<Obra>();
            foreach (Obra o in ColObras)
            {
              
                if (o.Nombre.Contains(nom.ToUpper()))
                {
                    auxList.Add(o);
                }
            }
            return auxList;
        }

        public List<Obra> ObraPorNombreAutor(string nom)
        {
            auxList = new List<Obra>();

            foreach (Obra o in ColObras)
            {
                if (o.Autor.Nombre.Contains(nom))
                {
                    auxList.Add(o);
                }
            }

            return auxList;
        }

        public List<Obra> ObraPorApellidoAutor(string ape)
        {
            auxList = new List<Obra>();

            foreach (Obra o in ColObras)
            {
                if (o.Autor.Apellido.Contains(ape))
                {
                    auxList.Add(o);
                }
            }

            return auxList;
        }

        public List<Obra> ObraPorAutor(Artista a)
        {
            auxList = new List<Obra>();

            foreach (Obra o in ColObras)
            {
                Artista aux = o.Autor;
                if (aux.Id == a.Id)
                {
                    auxList.Add(o);
                }
            }

            return auxList;
        }

        public List<Obra> ObraPorAnioCreacion(int anio)
        {
            auxList = new List<Obra>();
            foreach (Obra o in ColObras)
            {
                if (o.FechaCreacion.Year == anio)
                {
                    auxList.Add(o);
                }
            }
            return auxList;
        }

        public int CantidadEsculturas()
        {
            contador = 0;
            foreach(Obra o in ColObras)
            {
                if(o.GetType() == typeof(Escultura))
                {
                    contador++;
                }
            }

            return contador;
        }

        public int CantidadCuadros()
        {
            contador = 0;
            foreach (Obra o in ColObras)
            {
                if (o.GetType() == typeof(Cuadro))
                {
                    contador++;
                }
            }

            return contador;
        }


    }


}
