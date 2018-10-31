using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        #region Campos
        int legajo;
        #endregion
        #region Metodos
        public Universitario():this(0,"","","",ENacionalidad.Argentino)
        {

        }
        public Universitario(int legajo, string nombre, string apellido,string dni,ENacionalidad nacionalidad):base(nombre, apellido , nacionalidad)
        {
            this.legajo = legajo;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("LEGAJO :"+this.legajo);
            return sb.ToString();
        }
        
        public static bool operator ==(Universitario pg1 , Universitario pg2 )
        {
            bool flag = false;
            if(pg1 is Universitario && pg2 is Universitario )
            {
                if(pg1.DNI == pg2.DNI || pg1.legajo==pg2.legajo)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        protected abstract string ParticipaEnClase();

        public override bool Equals(object obj)
        {
            bool flag = false;
            if(this==((Universitario)obj))
            {
                flag = true;
            }
            return flag;
        }
        #endregion
    }
}
