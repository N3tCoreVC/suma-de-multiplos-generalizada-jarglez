using System;

namespace suma_de_multiplos_de_3_y_5_jarglez {

    public class Multiplos 
    {
        private readonly int[] multiplos;
        
        public Multiplos(int numero, int rango) {
            multiplos = obtenMultiplos(numero, rango);
        }

        public int[] getMultiplos() {
            return this.multiplos;
        }

        private int obtenMultiplicadores(int numero, int rango) {
            if (rango%numero > 0) {
                return (rango-1)/numero;
            } else {
                return rango/numero;
            }
        }

        private int[] obtenMultiplos(int numero, int rango) {
            int multiplicadores = obtenMultiplicadores(numero, rango);
            int[] respuesta = new int[multiplicadores];
            int ultimoResultado = 0;
            int multiplicador = 1;
            Boolean condicion;
            do {
                ultimoResultado = 0;                
                ultimoResultado = numero * multiplicador;   
                respuesta[multiplicador-1] = ultimoResultado;
                multiplicador++;
                condicion = (((ultimoResultado + numero)  < rango) 
                            || ((ultimoResultado + numero) == rango));
            } while (condicion);                
            return respuesta;
        }
    }
}