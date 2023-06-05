using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperatorio_primer_parcial_unit_test_palabras
{
    public class AnalizadorPalabras
    {
        public bool EsPalidromo(String palabra)
        {
            if (!this.EsUnaSolaPalabra(palabra))
            {
                throw new ArgumentException("Solo se admite una palabra");
            }
            string reversedText = RevertirPalabra(palabra);
            return palabra.Equals(reversedText);
        }
        private bool EsUnaSolaPalabra(string text)
        {
            if (text.Contains(' '))
            {
                return false;
            }
            return true;
        }
        private string RevertirPalabra(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
