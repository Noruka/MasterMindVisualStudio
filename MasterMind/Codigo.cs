using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    public class Codigo
    {

        private int codigoM;
        static private int contador=0;

        public int CodigoM { get => codigoM; set => codigoM = value; }

        public Codigo() {

            this.CodigoM = 0;

        }

        //Esta función la utilizo para generar un numero del 1 al 8
        //Ese numero representa un color.
        //Los codigos son "traducidos" a los colores en String
        //en la función TraductorCodigoColor() y TraductorColorCodigo()
        public int RandomGen()
        {
            int random;

            Random r = new Random();

            random = r.Next(1, 9);
            return random;
        }

        //Esta función genera la combinación de colores
        //que el usuario tiene que adivinar.
        //Las normas son que los colores no se pueden repetir
        public void RellenarArray(int[] codigoGenerado)
        {
            Boolean check = false;
            int temp1;

            for (int i = 0; i < codigoGenerado.GetLength(0); i++)
            {
                do
                {
                    temp1 = RandomGen();
                    for (int j = 0; j < codigoGenerado.GetLength(0); j++)
                    {

                        if (codigoGenerado[j] == temp1)
                        {
                            check = false;
                            break;
                        }
                        else
                        {
                            check = true;
                        }
                    }
                } while (!check);
                codigoGenerado[i] = temp1;
            }
        }

        public Boolean CheckGameStatus()
        {

            if (contador == 10)
            {
                return true;
            }
            else
            {
                contador = 0;
                return false;
            }
        }

        //Ejecutar Funciones en orden
        //Esta función simplemente ejecuta las funciones en orden.
        //Como cada que se tiene que comprobar los resultados hay que ejecutar
        //estas funciones, pues simplemente aqui generalizo las funciones
        //y esto me permite añadir y quitar funciones de forma mas clara.
        public void EjecutarFunciones(int[] codigo, int[] jugadorInput, String[] resultado)
        {

            FBlanca(codigo, jugadorInput, resultado);
            FNegra(codigo, jugadorInput, resultado);
            FixNullArray(resultado);
            //ImprimirResultados
            LimpiarResultados(resultado);
            //Debugging //System.out.println("El contador esta a: "+contador);
        }

        //Comprobar Ficha blanca
        //Esta funcion comprueba el array del usuario y mira
        //si hay colores que existan en el array.
        //Si el color existe en alguna posición llamara a la funcion
        //InterpretadorArray() y le enviara el array resultado, la posicion
        //y un score de valor 1 para el contador anterior mencionado.
        public void FBlanca(int[] codigo, int[] input, String[] resultado)
        {

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < codigo.GetLength(0); j++)
                {
                    if (input[i] == codigo[j])
                    {
                        InterpretadorArray(resultado, i, 1);
                    }
                }
            }
        }

        //Comprobar Ficha Negra
        //Esta funcion comprueba el array del usuario y mira
        //si el color introducido en cada una de las posiciones del array
        //input coincide con los colores en el array codigo.
        //Si el color en las dos posiciones coincide
        //llama a la función InterpretadorArray() y le
        //envia el array resultado, la posición en el array y un
        //score de 2.
        public void FNegra(int[] codigo, int[] input, String[] resultado)
        {

            for (int i = 0; i < input.GetLength(0); i++)
            {
                if (codigo[i] == input[i])
                {
                    InterpretadorArray(resultado, i, 2);
                }
            }
        }

        //Arreglar el null
        //Esta función elimina los "null" del array resultado
        //y lo rellena con un String de espacio vacio
        //representando que el usuario no a acertado
        //ni el color ni la posicion
        public void FixNullArray(String[] resultado)
        {

            for (int i = 0; i < resultado.GetLength(0); i++)
            {
                if (resultado[i] == null)
                {
                    resultado[i] = "        ";
                }
            }
        }

        //Limpia el array de resultados
        //Limpia el array de resultados para que en el proximo
        //turno no haya resultados del turno anterior
        public void LimpiarResultados(String[] resultado)
        {
            for (int i = 0; i < resultado.GetLength(0); i++)
            {
                resultado[i] = null;
            }
        }

        //Inserta el resultado en el array resultado en String
        //Aqui esta el interprete de los resultados
        //llama a la funcion InsertarEnPosicion() y le envia
        //un string dependiendo de si el usuario ha adivinado o no
        //el color. La funcion InsertarEnPoscion() recibe el array,
        //la posicion y el string a meter. 
        public void InterpretadorArray(String[] resultado, int pos, int res)
        {

            if (res == 1)
            {
                InsertarEnPosicion(resultado, pos, "F. Blanca");

            }
            else
            {
                if (res == 2)
                {
                    InsertarEnPosicion(resultado, pos, "F. Negra");
                    contador += 2;
                }
                else
                {
                    InsertarEnPosicion(resultado, pos, "        ");
                }
            }

        }

        //Funciones arrays
        //Esta función simplemente inserta en una posicion que recibe un string
        public void InsertarEnPosicion(String[] resultado, int pos, String res)
        {

            resultado[pos] = res;
        }

    }
}
