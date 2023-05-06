using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoVelhaForms
{
    public partial class Form1 : Form
    {
        int Xplayer = 0, Oplayer = 0, empates = 0, rodadas = 0;
        bool turno = true, jogo_final = false;
        string[] velha = new string[9];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            int buttonIndex = btn.TabIndex;
            for(int i = 0; i < 9; i++)
            {
                
            }  

        }
    }
}
