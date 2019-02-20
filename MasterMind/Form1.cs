using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class Form1 : Form
    {
        //Genero variables globales
        //posArrayJugador actua como una i en un for y va recorriendo el
        //array de colores del jugador
        //turno simplemente hace un seguimiento de los turnos
        int posArrayJugador = 0;
        int turno = 1;

        //El arrayMastermind es donde se guarda el codigo generado
        //El arrayJugador guarda el ultimo codigo que ha metido el jugador
        int[] arrayMastermind = new int[5];
        int[] arrayJugador = new int[5];

        //Estos arrays son para crear los paneles
        Panel[] panelMastermind = new Panel[5];
        Panel[] panelJugador = new Panel[5];
        Panel[] panelJugador2 = new Panel[5];
        Panel[] panelAciertos = new Panel[5];
        //Creo el objeto del codigo mastermind para usar sus funciones y hacer un seguimiento del Score
        //que utilizo para saber si ha acertado todas las posiciones.
        Codigo codigoMastermind = new Codigo();

        //Genero el form generando los paneles
        public Form1()
        {
            InitializeComponent();

            codigoMastermind.RellenarArray(arrayMastermind);

            //Genera los paneles que muestran los colores
            ///*Debugging*/GenerarPanelMastermind(panelMastermind);
            ///
            //Si Generas el panel Mastermind desactivar GenerarPanelJugador2
            GenerarPanelAciertos(panelAciertos);
            GenerarPanelJugador(panelJugador);
            GenerarPanelJugador2(panelJugador2);


            //MostrarMastermind(arrayMastermind, panelMastermind);

        }

        //public void GenerarPanelMastermind(Panel[] panel)
        //{

        //    for (int i = 0; i < panel.GetLength(0); i++)
        //    {
        //        panel[i] = new Panel();
        //        panel[i].Left = 12 + (i * 56);
        //        panel[i].Top = 250;
        //        panel[i].Width = 50;
        //        panel[i].Height = 50;
        //        panel[i].BorderStyle = BorderStyle.FixedSingle;

        //        this.Controls.Add(panel[i]);
        //    }

        //}

        //public void MostrarMastermind(int[] codigo, Panel[] panel)
        //{

        //    for (int i = 0; i < panel.GetLength(0); i++)
        //    {
        //        TraductorCodigoColor(panel, codigo, i);
        //    }

        //}
        //Paneles que mantienen la ultima combinacion insertada
        public void GenerarPanelJugador2(Panel[] panel)
        {

            for (int i = 0; i < panel.GetLength(0); i++)
            {
                panel[i] = new Panel();
                panel[i].Left = 12 + (i * 56);
                panel[i].Top = 250;
                panel[i].Width = 50;
                panel[i].Height = 50;
                panel[i].BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(panel[i]);
            }

        }
        //Paneles que mantienen os aciertos de la jugada actual
        public void GenerarPanelAciertos(Panel[] panel)
        {

            for (int i = 0; i < panel.GetLength(0); i++)
            {
                panel[i] = new Panel();
                panel[i].Left = 12 + (i * 56);
                panel[i].Top = 50;
                panel[i].Width = 50;
                panel[i].Height = 50;
                panel[i].BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(panel[i]);
            }
        }
        //Paneles que mantienen el codigo que va insertando el jugador
        public void GenerarPanelJugador(Panel[] panel)
        {

            for (int i = 0; i < panel.GetLength(0); i++)
            {
                panel[i] = new Panel();
                panel[i].Left = 12 + (i * 56);
                panel[i].Top = 150;
                panel[i].Width = 50;
                panel[i].Height = 50;
                panel[i].BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(panel[i]);
            }

        }
        //Conversor de numeros a colores
        //Recibe un numero representativo y ajusta el panel
        //Si el color no es valido devuelve el color gris
        public void TraductorCodigoColor(Panel[] panel, int[] codigo, int i)
        {
            switch (codigo[i])
            {

                case 1:
                    panel[i].BackColor = Color.White; break;
                case 2:
                    panel[i].BackColor = Color.Black; break;
                case 3:
                    panel[i].BackColor = Color.Pink; break;
                case 4:
                    panel[i].BackColor = Color.Orange; break;
                case 5:
                    panel[i].BackColor = Color.Red; break;
                case 6:
                    panel[i].BackColor = Color.Yellow; break;
                case 7:
                    panel[i].BackColor = Color.Green; break;
                case 8:
                    panel[i].BackColor = Color.Blue; break;
                default:
                    panel[i].BackColor = Color.Gray; break;
            }
        }

        //Funcion que chequea los resultados y que controla el juego
        public void Post()
        {
            if (posArrayJugador >= 5 && turno<=10)
            {

                for (int i = 0; i < panelAciertos.GetLength(0); i++)
                {
                    panelAciertos[i].BackColor = Color.Empty;
                }
                for (int i = 0; i < arrayJugador.GetLength(0); i++)
                {
                    TraductorCodigoColor(panelJugador2, arrayJugador, i);
                }

                codigoMastermind.EjecutarFunciones(arrayMastermind, arrayJugador, panelAciertos);

                btnSiguiente.Enabled = true;

                if (codigoMastermind.Score >= 5)
                {
                    MessageBox.Show("Has ganado!");
                    Application.Exit();
                }
                codigoMastermind.Score = 0;
            }
            
        }

        //Cuando el usuario le da al boton siguiente se suma el turno, se resetea la posicion para volver a escribir en el array del jugador
        //habilita los botones y resetea los paneles del codigo insertado (panelJugador).
        //También comprueba si el usuario se ha pasado de turnos o no
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = false;
            turno++;
            posArrayJugador = 0;

            EnableBotones();

            //Resetear Jugador
            for (int i = 0; i < panelJugador.GetLength(0); i++)
            {
                panelJugador[i].BackColor = Color.Empty;
            }

            if (turno > 10)
            {
                MessageBox.Show("Has perdido! Demasiados intentos!");
                Application.Exit();
            }
            else
            {
                lbTurno.Text = "Turno: " + turno;
            }
        }
        //Simple funcion que habilita todos los botones
        public void EnableBotones()
        {
            btnBlanco.Enabled = true;
            btnNegro.Enabled = true;
            btnRosa.Enabled = true;
            btnRojo.Enabled = true;
            btnNaranja.Enabled = true;
            btnVerde.Enabled = true;
            btnAzul.Enabled = true;
            btnAmarillo.Enabled = true;
        }
        
        //Botones para que el usuario escriba el codigo
        //el if que hay dentro es para que no pueda pulsar mas botones que posiciones tiene el array del jugador
        //Escribe el color en el array del jugador para luego comprobarlo para poner las fichas blancas y negras
        //Y pasa a la siguiente posicion del array jugador para escribir en él
        private void btnBlanco_Click(object sender, EventArgs e)
        {
            if (posArrayJugador < arrayJugador.GetLength(0))
            {
                arrayJugador[posArrayJugador] = 1;
                panelJugador[posArrayJugador].BackColor = Color.White;
                posArrayJugador++;
                btnBlanco.Enabled = false;
                Post();
            }
        }

        private void btnNegro_Click(object sender, EventArgs e)
        {
            if (posArrayJugador < arrayJugador.GetLength(0))
            {
                arrayJugador[posArrayJugador] = 2;
                panelJugador[posArrayJugador].BackColor = Color.Black;
                posArrayJugador++;
                btnNegro.Enabled = false;
                Post();
            }
        }

        private void btnRosa_Click(object sender, EventArgs e)
        {
            if (posArrayJugador < arrayJugador.GetLength(0))
            {
                arrayJugador[posArrayJugador] = 3;
                panelJugador[posArrayJugador].BackColor = Color.Pink;
                posArrayJugador++;
                btnRosa.Enabled = false;
                Post();
            }
        }

        private void btnNaranja_Click(object sender, EventArgs e)
        {
            if (posArrayJugador < arrayJugador.GetLength(0))
            {
                arrayJugador[posArrayJugador] = 4;
                panelJugador[posArrayJugador].BackColor = Color.Orange;
                posArrayJugador++;
                btnNaranja.Enabled = false;
                Post();
            }
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            if (posArrayJugador < arrayJugador.GetLength(0))
            {
                arrayJugador[posArrayJugador] = 5;
                panelJugador[posArrayJugador].BackColor = Color.Red;
                posArrayJugador++;
                btnRojo.Enabled = false;
                Post();
            }
        }

        private void btnAmarillo_Click(object sender, EventArgs e)
        {
            if (posArrayJugador < arrayJugador.GetLength(0))
            {
                arrayJugador[posArrayJugador] = 6;
                panelJugador[posArrayJugador].BackColor = Color.Yellow;
                posArrayJugador++;
                btnAmarillo.Enabled = false;
                Post();
            }
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            if (posArrayJugador < arrayJugador.GetLength(0))
            {
                arrayJugador[posArrayJugador] = 7;
                panelJugador[posArrayJugador].BackColor = Color.Green;
                posArrayJugador++;
                btnVerde.Enabled = false;
                Post();
            }
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            if (posArrayJugador < arrayJugador.GetLength(0))
            {
                arrayJugador[posArrayJugador] = 8;
                panelJugador[posArrayJugador].BackColor = Color.Blue;
                posArrayJugador++;
                btnAzul.Enabled = false;
                Post();
            }
        }
    }
}
