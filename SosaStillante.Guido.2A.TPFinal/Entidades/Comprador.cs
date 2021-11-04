using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comprador : Persona
    {
        #region Atributos

        /// <summary>
        /// Atributos propios de la clase comprador
        /// </summary>
        double billeteraUsd;
        double btc;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Comprador() { }

        /// <summary>
        /// Sobrecarga de constructor con parametros correctos para la asignacion, utiliza el constructor base que inicializa al comprador de forma anonima
        /// </summary>
        /// <param name="dni">Documento del Comprador</param>
        /// <param name="billeteraUsd">Billetera del comprador</param>
        public Comprador(long dni, double billeteraUsd) : base() 
        {
            this.dni = dni;
            this.billeteraUsd = billeteraUsd;
        }

        /// <summary>
        /// Sobrecarga de constructor con parametros de tipo string, invoca a las propiadades que lo setean al tipo requerido, utiliza el contructor base por defecto
        /// </summary>
        /// <param name="dni">Documento en tipo string</param>
        /// <param name="billeteraUsd">Billetera en tipo string</param>
        public Comprador(string dni, string billeteraUsd) : base()
        {
            this.stringDNI = dni;
            this.BilleteraUsd = billeteraUsd;
        }

        /// <summary>
        /// Sobrecarga de constructor completo
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="genero"></param>
        /// <param name="billeteraUsd"></param>
        public Comprador(string nombre, string apellido, long dni, EGenero genero, double billeteraUsd) 
            : base(nombre, apellido, dni, genero)
        {
            this.billeteraUsd = billeteraUsd;
        }
        /// <summary>
        /// Sobrecarga de constructor completo
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="genero"></param>
        /// <param name="billeteraUsd"></param>
        public Comprador(string nombre, string apellido, string dni, EGenero genero, string billeteraUsd)
            : base(nombre, apellido, dni, genero)
        {
            this.BilleteraUsd = billeteraUsd;
        }
        #endregion

        #region Prop

        /// <summary>
        /// Propiedad de lectura y escritura para el atributo double billetera del objeto comprador
        /// </summary>
        public double Billetera
        {
            get { return this.billeteraUsd; }
            set { this.billeteraUsd = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para el atributo double btc del objeto comprador
        /// </summary>
        public double Btc
        {
            get { return this.btc; }
            set { this.btc = value; }
        }

        /// <summary>
        /// Propiedad que valida el double con metodo de la clase base para asignarlo al atributo
        /// </summary>
        public string BilleteraUsd
        {
            set { this.billeteraUsd = ValidarDouble(value); }
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Sobrecarga del Metodo ToString que construye una cadena con los datos del comprador
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat(" Documento: {0} BTC: {1} Billetera(USD): {2}", this.Dni, this.Btc, this.Billetera);
            return sb.ToString();
        }

        /// <summary>
        /// Metodo de compra que suma en uno la cantidad de btc del comprador y disminuye su dinero en 63000usd
        /// </summary>
        public void Compra()
        {
            this.btc += 1;
            this.billeteraUsd -=  63000;
        }
        #endregion
    }
}
