using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microondas
{
    public partial class Form1 : Form
    {
        private string input = "";
        private Timer countdownTimer;
        private int totalTimeInSeconds;

        public Form1()
        {
            InitializeComponent();
            timer2.Interval = 1000;
        }

        /* Atualiza o Visor */
        private void UpdateVisor()
        {
            if (timer2.Enabled)
            {
                int minutos = totalTimeInSeconds / 60;
                int segundos = totalTimeInSeconds % 60;

                txtVisor.Text = $"{minutos:D2}:{segundos:D2}";
            }
            else
            {
                if (input.Length > 0)
                {
                    string paddedInput = input.PadLeft(4, '0');

                    int minutos = int.Parse(paddedInput.Substring(0, 2));
                    int segundos = int.Parse(paddedInput.Substring(2, 2));

                    txtVisor.Text = $"{minutos:D2}:{segundos:D2}";
                }
                else
                {
                    txtVisor.Text = "00:00"; 
                }
            }
        }


        /* Counter Tick */
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (totalTimeInSeconds > 0)
            {
                totalTimeInSeconds--;
                UpdateVisor();
            }
            else
            {
                timer2.Stop();
            }
        }

        /* Botão Liga */
        private void buttonLiga_Click(object sender, EventArgs e)
        {
            string paddedInput = input.PadLeft(4, '0');
            int minutos = int.Parse(paddedInput.Substring(0, 2));
            int segundos = int.Parse(paddedInput.Substring(2, 2));
            totalTimeInSeconds = (minutos * 60) + segundos;

            timer2.Start();
        }

        /* Botão Para */
        private void buttonPara_Click(object sender, EventArgs e)
        {
            input = ""; 
            totalTimeInSeconds = 0;
            timer2.Stop(); 
            txtVisor.Text = "00:00"; 
        }
        
        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "0";
                UpdateVisor();
            }
        }

        private void buttonUm_Click(object sender, EventArgs e)
        {
            if (input.Length < 4) 
            {
                input += "1"; 
                UpdateVisor(); 
            }
        }

        private void buttonDois_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "2";
                UpdateVisor();
            }
        }
        private void buttonTres_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "3";
                UpdateVisor();
            }
        }
        private void buttonQuatro_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "4";
                UpdateVisor();
            }
        }
        private void buttonCinco_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "5";
                UpdateVisor();
            }
        }
        private void buttonSeis_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "6";
                UpdateVisor();
            }
        }
        private void buttonSete_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "7";
                UpdateVisor();
            }
        }
        private void buttonOito_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "8";
                UpdateVisor();
            }
        }
        private void buttonNove_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "9";
                UpdateVisor();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
