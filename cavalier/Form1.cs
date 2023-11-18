using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Cavalier
{
    public partial class Form1 : Form
    {
        static int[] depi = new int[] { 2, 1, -1, -2, -2, -1, 1, 2 };
        static int[] depj = new int[] { 1, 2, 2, 1, -1, -2, -2, -1 };
        //random de 0 à 2
        public Form1()
        {
            InitializeComponent();
        }
        private Button[,] grille;
      
       

       
        private void Form1_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.Gold;
            this.Text = "Menu | Euler's Knight";
            button1.Text = "";
         button1.BackgroundImage = Image.FromFile("img/cava.jpg");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void règlesDuJeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string regles = "FR: Le but de ce jeu est de faire parcourir un cavalier sur l'ensemble des cases d'un échiquier sans passer deux fois sur la même case.\n\n EN: The Euler's Knight game involves moving a knight on a chessboard to visit every square exactly once, following the rules of chess Knight moves. ";
            MessageBox.Show(regles);
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = "Jeu du cavalier d'Euler développé par Ahmed zwawi";
            MessageBox.Show(about);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

