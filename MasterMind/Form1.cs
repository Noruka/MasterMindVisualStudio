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
        int posArrayJugador = 0;

        int[] arrayMastermind = new int[5];
        int[] arrayJugador = new int[5];

        Panel[] panelMastermind = new Panel[5];
        Panel[] panelJugador = new Panel[5];
        Panel[] panelAciertos = new Panel[5];


        public Form1()
        {
            InitializeComponent();

            Codigo codigoMastermind = new Codigo();

            codigoMastermind.RellenarArray(arrayMastermind);

            GenerarPanelMastermind(panelMastermind);
            GenerarPanelAciertos(panelAciertos);
            GenerarPanelJugador(panelJugador);


            MostrarMastermind(arrayMastermind, panelMastermind);

        }

        public void GenerarPanelMastermind(Panel[] panel) {

            for (int i = 0; i < panel.GetLength(0); i++)
            {
                panel[i] = new Panel();
                panel[i].Left = 12 + (i * 56);
                panel[i].Top = 220;
                panel[i].Width = 50;
                panel[i].Height = 50;
                panel[i].BorderStyle = BorderStyle.FixedSingle;

                this.Controls.Add(panel[i]);
            }

        }

        public void GenerarPanelAciertos(Panel[] panel) {

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

        public void GenerarPanelJugador(Panel[] panel) {

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

        public void MostrarMastermind(int[] codigo, Panel[] panel)
        {

            for (int i = 0; i < panel.GetLength(0); i++)
            {
                TraductorCodigoColor(panel, codigo, i);
            }

        }

        //Conversor de numeros a letras
        //Esta funcion hace exactamente lo contrario
        //Recibe un numero representativo y devuelve un String
        //Si el color no es valido devuelve un mensaje de error
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

        private void btnBlanco_Click(object sender, EventArgs e)
        {
            if (posArrayJugador < 5)
            {
                arrayJugador[posArrayJugador] = 1;
                posArrayJugador++;
                btnBlanco.Enabled = false;
            }
            else {



            }
            
        }

        private void btnNegro_Click(object sender, EventArgs e)
        {
            if (posArrayJugador < 5)
            {
                arrayJugador[posArrayJugador] = 2;
                posArrayJugador++;
                btnNegro.Enabled = false;
            }
            
        }

        private void btnRosa_Click(object sender, EventArgs e)
        {
            if (posArrayJugador < 5)
            {
                arrayJugador[posArrayJugador] = 3;
                posArrayJugador++;
                btnRosa.Enabled = false;
            }
            
        }

        private void btnNaranja_Click(object sender, EventArgs e)
        {
            if (posArrayJugador < 5)
            {
                arrayJugador[posArrayJugador] = 4;
                posArrayJugador++;
                btnNaranja.Enabled = false;
            }
            
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            if (posArrayJugador < 5)
            {
                arrayJugador[posArrayJugador] = 5;
                posArrayJugador++;
                btnRojo.Enabled = false;
            }
            
        }

        private void btnAmarillo_Click(object sender, EventArgs e)
        {
            if (posArrayJugador < 5)
            {
                arrayJugador[posArrayJugador] = 6;
                posArrayJugador++;
                btnAmarillo.Enabled = false;
            }
            
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            if (posArrayJugador < 5)
            {
                arrayJugador[posArrayJugador] = 7;
                posArrayJugador++;
                btnVerde.Enabled = false;
            }
            
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            if (posArrayJugador < 5)
            {
                arrayJugador[posArrayJugador] = 8;
                posArrayJugador++;
                btnAzul.Enabled = false;
            }
            
        }
    }
}
