using System;
using System.Collections.Generic;

namespace suma_de_multiplos_de_3_y_5_jarglez
{
    class Sumatoria
    {
        private Multiplos sacaMultiplos;
        private int[][] multiplos;
        private int sumatorias = 0;
        public Sumatoria(int[] numeros, int rango) {
            multiplos = new int[numeros.Length][];
            Boolean condicion = false;
            for (int cuenta = 0; numeros.Length > cuenta; cuenta++) {
                sacaMultiplos = new Multiplos(numeros[cuenta], rango);
                multiplos[cuenta] = sacaMultiplos.getMultiplos();
                //Console.WriteLine(multiplos[cuenta].Length);
            }            
            for (int j = 0;  multiplos.GetLength(0) > j; j++ ) {
                for (int i = 0; multiplos[j].Length > i; i++) {
                    if (j > 0) {
                        for (int k = 0; multiplos.GetLength(0)-1 > k; k++) {
                            if (multiplos[j][i]%multiplos[k][0] != 0) {                                
                                condicion = true;
                            } else {
                                condicion = false;
                            }
                            //Console.WriteLine(condicion);
                        } 
                        if (condicion) {
                            sumatorias = sumatorias + multiplos[j][i];
                        }              
                        //Console.WriteLine(multiplos[j][i]);          
                    } else {
                        sumatorias = sumatorias + multiplos[j][i];
                    }                    
                    //Console.WriteLine($"sumatoria: {sumatorias}");                     
                }
            }
        }
        public int getSumatoria(){
            return this.sumatorias;
        }

        static void Main(string[] args)
        {
            int numerosHacer = 0;
            int[] numeros = {3,5};
            int rango = 0;   
            int cuentas = 0;        
            try {                 
                Console.Write("Cuantos Números quieres hacer: ");
                numerosHacer = Int32.Parse(Console.ReadLine());
                numeros = new int[numerosHacer];
                ;
                do {
                    Console.Write($"Numero {cuentas + 1}: ");
                    numeros[cuentas] = Int32.Parse(Console.ReadLine());
                    cuentas++;
                } while (numerosHacer > cuentas);
                Console.Write("Hasta que número quieres hacer la sumatoria: ");
                rango = Int32.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Cyan;
                Sumatoria sumatoria = new Sumatoria(numeros, rango);
                Console.WriteLine($"La sumatoria es: {sumatoria.getSumatoria()}\n");
                Console.ResetColor();
            } catch (Exception e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                Console.Write("Hubo un error... solo acepto enteros.\n");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Presione enter para continuar ...");
            Console.ReadLine();
            Console.ResetColor();
        }
    }
}
