using System;
using System.Collections.Generic;
using System.Text;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public  class Profesor : Universitario
    {
        #region atributo
        Queue<EClases> claseDelDia;
        static Random random;

        #endregion
        #region metodos
        static Profesor()
        {
            random = new Random();
        }
        public Profesor()
        {
            this.claseDelDia = new Queue<EClases>(2);
        }
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {

        }
        protected override string ParticipaEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASE DEL DIA: ");
            foreach (EClases item in claseDelDia)
            {
                sb.AppendLine(item + "");
            }
            return sb.ToString();
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticipaEnClase());

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos();
        }

        private void _randomClases()
        {
            while(this.claseDelDia.Count<2)
            {
                int NumeroDeClase = random.Next(0, 3);
                this.claseDelDia.Enqueue((EClases)NumeroDeClase);
            }
        }

        public static bool operator ==(Profesor i , EClases clase )
        {
            bool flag = false;
            foreach(EClases item in i.claseDelDia)
            {
                if ( item == clase)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static bool operator !=(Profesor i, EClases clase)
        {
            return !(i == clase);
        }

        #endregion
    }
}
