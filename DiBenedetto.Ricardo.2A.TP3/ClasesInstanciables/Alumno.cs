using System;
using System.Collections.Generic;
using System.Text;
using EntidadesAbstractas;
namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        #region atributos
        EClases claseQueToma;
        EEstadoCuenta estadoCuenta;
        #endregion
        public Alumno():this(0,"","","",ENacionalidad.Argentino,EClases.Laboratorio)
        {

        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        protected override string ParticipaEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("TOMA CLASE DE " + this.claseQueToma.ToString());
            return sb.ToString();
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.estadoCuenta.ToString());
            sb.AppendLine(this.ParticipaEnClase());

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        public static bool operator ==(Alumno a, EClases clase)
        {
            bool flag = false;
            if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                flag = true;
            }
            return flag;
        }
        public static bool operator !=(Alumno a, EClases clase)
        {
            bool flag = false;
            if (a.claseQueToma != clase)
            {
                flag = true;
            }
            return flag;
        }
    }
}
