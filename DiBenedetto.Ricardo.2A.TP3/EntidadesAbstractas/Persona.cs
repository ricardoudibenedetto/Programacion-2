using System;
using System.Collections.Generic;
using System.Text;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        #region Campos
        string apellido;
        string nombre;
        int dni;
        ENacionalidad nacionalidad;
        #endregion
        #region Propiedades
        public string Apellido
        {
            get {return this.apellido; }
            set { this.Apellido=ValidarNombreApellido(value); }
        }
        public int DNI
        {
            get { return this.dni; }
            set {this.dni = ValidarDni(this.nacionalidad,value); }
        }
        public string Nombre
        {
            get {return this.nombre; }
            set {this.nombre = ValidarNombreApellido(value); }
        }
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set {this.nacionalidad = value; }
        }
        public string StringToDNI
        {
            set { this.dni = ValidarDni(this.nacionalidad, value); }
        }
        #endregion
        #region metodo
        public Persona():this("","",ENacionalidad.Argentino)
        {

        }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad):this(nombre,apellido,1,nacionalidad)
        {

        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad):this(nombre, apellido, dni.ToString(),nacionalidad)
        {

        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {
            

        }
        /// <summary>
        /// datos completos de la persona , Nombre y apellido.
        /// </summary>
        /// <returns>retorna un string </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE COMPLETO: " + Apellido + "," + Nombre);
            sb.AppendLine("NACIONALIDAD: " + Nacionalidad);
            return sb.ToString();
        }
        /// <summary>
        /// valida que el dni corresponda a la nacionalidad
        /// </summary>
        /// <param name="nacionalidad">nacionalidad de la persona(Argentino, Extarangero)</param>
        /// <param name="dato">DNI a validar</param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if(nacionalidad == ENacionalidad.Argentino && ( dato < 1 ||dato >89999999))
            {
                throw new DniInvalidoException("DNI INVALIDO", new NacionalidadInvalidaException("EL DNI NO COINCIDE CON LA NACINALIDAD"));
            }
            else
            {
                if(nacionalidad==ENacionalidad.Extranjero && (dato < 90000001))
                {
                    throw new NacionalidadInvalidaException("LA NACIONALIDAD NO COINCIDE CON EL DNI");
                }
            }
            return dato;
        }
        /// <summary>
        /// valida que el dni no contenga caracteres
        /// </summary>
        /// <param name="nacionalidad">nacionalidad de la persona(Argentino, Extarangero)</param>
        /// <param name="dato">DNI a validar</param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int datoInt;
            int retorno;
            if (int.TryParse(dato, out datoInt))
            {
                retorno = ValidarDni(nacionalidad, datoInt);
            }
            else
            {
                throw new DniInvalidoException();
            }
            return 1;
        }
        /// <summary>
        /// valida que el nombre y el apellido solo contega caracteres validos 
        /// </summary>
        /// <param name="dato">Nombre o Apellido a validar</param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {

           
            return "";
        }

        #endregion

    }
}
