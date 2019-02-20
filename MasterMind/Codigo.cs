using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MasterMind
{
    public class Codigo
    {

        private int score;
        static private int contador = 0;

        public int Score { get => score; set => score = value; }

        public Codigo()
        {

            this.Score = 0;

        }

        //Esta función la utilizo para generar un numero del 1 al 8
        //Ese numero representa un color.
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

        //Ejecutar Funciones en orden
        //Esta función simplemente ejecuta las funciones de comprobación de resultados en orden.
        
        public void EjecutarFunciones(int[] codigo, int[] jugadorInput, Panel[] resultado)
        {
            FBlanca(codigo, jugadorInput, resultado);
            FNegra(codigo, jugadorInput, resultado);
        }

        //Comprobar Ficha blanca
        //Esta funcion comprueba el array del usuario y mira
        //si hay colores que existan en el array.
        //Si el color existe en alguna posición lo pondra en el
        //panel correspondiente con un background blanco
        public void FBlanca(int[] codigo, int[] input, Panel[] resultado)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < codigo.GetLength(0); j++)
                {
                    if (input[i] == codigo[j])
                    {
                        resultado[i].BackColor = Color.White;
                    }
                }
            }
        }

        //Comprobar Ficha Negra
        //Esta funcion comprueba el array del usuario y mira
        //si el color introducido en cada una de las posiciones del array
        //input coincide con los colores en el array codigo.
        //Si el color existe en alguna posición lo pondra en el
        //panel correspondiente con un background negro y sumara el Score en 1
        public void FNegra(int[] codigo, int[] input, Panel[] resultado)
        {

            for (int i = 0; i < input.GetLength(0); i++)
            {
                if (codigo[i] == input[i])
                {
                    resultado[i].BackColor = Color.Black;
                    Score++;
                }
            }
        }

        //Limpiar Resultados
        //Limpia el array de resultados para que en el proximo
        //turno no haya resultados del turno anterior
        public void LimpiarResultados(Panel[] resultado)
        {
            for (int i = 0; i < resultado.GetLength(0); i++)
            {
                resultado[i].BackColor = Color.Empty;
            }
        }
    }
}
