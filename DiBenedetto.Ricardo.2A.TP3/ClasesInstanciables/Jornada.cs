using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInstanciables
{
    public class Jornada
    {
        #region atributos
        List<Alumno> alumnos;
        EClases clase;
        Profesor instructor;
        #endregion
        #region propiedades
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        public EClases Clases
        {
            get { return this.clase; }
            set {this.clase = value; }
        }
        public Profesor Instructor
        {
            get { return this.instructor; }
            set {this.instructor = value; }
        }

        #endregion
        #region metodos
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }
        public Jornada(EClases clase ,Profesor instructor):this()
        {
            this.Clases = clase;
            this.Instructor = instructor;
        }

        public static bool operator == ( Jornada j, Alumno  a)
        {
            return a == j.clase;
        }
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j==a);
        }

        public static Jornada operator +(Jornada j , Alumno a )
        {
            bool flag = false;
            foreach(Alumno item in j.alumnos)
            {
                
                if(item == a )
                {
                    flag = true;
                }
            }
            if(flag== false )
            {
                j.alumnos.Add(a);

            }
            return j;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASE : " + this.clase);
            sb.AppendLine("PROFESOR : " + this.instructor.ToString());
            foreach(Alumno item in this.alumnos)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("-----------------------------------------------");
            return sb.ToString();
        }

      

        #endregion


    }
}
