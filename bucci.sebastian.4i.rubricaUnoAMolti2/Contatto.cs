using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bucci.sebastian._4i.rubricaUnoAMolti
{
    public enum TipoContatto { nessuno, Email, telefono, Web, Instagram, Facebook}
    public class Contatto
    {
        public int idPersona { get; set; }
        public TipoContatto Tipo { get; set; }
        public string Valore { get; set; }

        public Contatto() 
        {
            Tipo = TipoContatto.nessuno;
        }

        public Contatto(string riga)
        {
            string[] campi = riga.Split(',');

            int id = 0;
            int.TryParse(campi[0], out id);
            idPersona = id;

            TipoContatto c;
            Enum.TryParse(campi[1], out c);
            this.Tipo = c;
            this.Valore = campi[2];
        }
    }
}
