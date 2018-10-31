using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        protected static string msj = "El dni es invalido";
        public DniInvalidoException():base()
        {

        }
        public DniInvalidoException(Exception e):this(DniInvalidoException.msj, e)
        {

        }
        public DniInvalidoException(string mensaje):base(mensaje)
        {

        }
        public DniInvalidoException(string mensaje, Exception e):base(mensaje, e)
        {

        }
    }
}
