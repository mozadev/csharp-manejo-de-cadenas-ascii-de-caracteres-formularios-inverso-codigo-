using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void preg1_btnProcesar_Click(object sender, EventArgs e)
        {
            string cadena = txtcadena.Text.ToLower();

            string vocalesEncontradas = "";
            int cantVocales = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                switch (cadena[i])
                {
                    case 'a':
                        cantVocales += 1;
                        vocalesEncontradas += cadena[i];
                        break;
                    case 'e':
                        cantVocales += 1;
                        vocalesEncontradas += cadena[i];
                        break;
                    case 'i':
                        cantVocales += 1;
                        vocalesEncontradas += cadena[i];
                        break;
                    case 'o':
                        cantVocales += 1;
                        vocalesEncontradas += cadena[i];
                        break;
                    case 'u':
                        cantVocales += 1;
                        vocalesEncontradas += cadena[i];
                        break;
                }
            }
            txtNumVoc.Text = cantVocales.ToString();
            txtVocales.Text = vocalesEncontradas;

        }

        private void preg2_btnEliminarEsp_Click(object sender, EventArgs e)
        {
            string cadena = txtcadena.Text;
            string cadenaSinBlancos = cadena.Replace(" ", "");
            txtEliminarEspa.Text = cadenaSinBlancos;
        }

        private void preg3_btnNumEspaciosBla_Click(object sender, EventArgs e)
        {
            string cadena = txtcadena.Text.ToLower();
            int contador = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == ' ')
                {
                    contador++;
                }
            }
            txtNumEspa.Text = contador.ToString();


        }

        private void Preg4_Click(object sender, EventArgs e)
        {

            string cadena = txtcadena.Text.ToUpper();

            string vocalesEncontradas = "";
            int cantZ = 0;
            int cantN = 0;
            int TOTAL = 0;


            for (int i = 0; i < cadena.Length; i++)
            {
                switch (cadena[i])
                {
                    case 'Z':
                        cantZ += 1;

                        break;
                    case 'N':
                        cantN += 1;

                        break;

                }
            }
            TOTAL = cantN + cantZ;

            txtcantiNyZ.Text = TOTAL.ToString();

            string cadenaInvertida = "";

            // Recorrer cadena letra por letra
            foreach (char letra in cadena)
            {
                // Anteponer la letra a la cadena invertida
                cadenaInvertida = letra + cadenaInvertida;
            }
            txtCadInve.Text = cadenaInvertida;
        }

        private void preg5_leerLetraIhastaM_Click(object sender, EventArgs e)
        {
            char letra = char.Parse(txtLetraIM.Text.ToUpper());
            if (73<letra && letra <= 77)
            {
                txtLeerLetraIhastaMResultado.Text = "si esta";
            }
            else

            {
                txtLeerLetraIhastaMResultado.Text = "no esta";
            }

        }

        private void Preg6_btnContarayb_Click(object sender, EventArgs e)
        {
            int contar_a = 0;
            int contar_b = 0;

            string cadena = txtcadena.Text;
            for (int i = 0; i < cadena.Length; i++)
            {
                switch (cadena[i])
                {
                    case 'a':
                        contar_a += 1;

                        break;
                    case 'b':
                        contar_b += 1;

                        break;

                }
            }
            txtContaRa.Text = contar_a.ToString();
            txtContaRb.Text = contar_b.ToString();

        }

        private void Preg7_btnEsCapicual_Click(object sender, EventArgs e)
        {
            Boolean palindroma = true;

            string cadena = txtPalabraCapicua.Text;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] != cadena[cadena.Length-i-1])
                {
                    palindroma = false;
                }
            }
            txtRptaEsCapicua.Text = palindroma.ToString();

        }

        private void preg8_ApPatNombApMat_Click(object sender, EventArgs e)
        {
            string apPat = txtapPat.Text;
            string apMat = txtApMate.Text;
            string nombre = txtnombre.Text;
            string resulatdo = apPat +" "+ nombre +" " +apMat;

            txtApPatNombApMatResul.Text = resulatdo;
        }

        private void preg_9ordenInverso_Click(object sender, EventArgs e)
        {
            string cad1 = txtcad1.Text;
            string cad2 = txtcad2.Text;
            string cad1cad2= cad1+cad2;
            txtcad3.Text = cad1cad2;
            string ordenInverso = "";

            // Recorrer cadena letra por letra
            foreach (char letra in cad1cad2)
            {
                // Anteponer la letra a la cadena invertida
                ordenInverso = letra + ordenInverso;
            }
            txtOrdenInversoPta9.Text = ordenInverso;
           
        }

        private void preg10_btnNumCons_Click(object sender, EventArgs e)
        {
            string cadena = txtfrasePeg10.Text;
            int contadorConsonates = 0;
            string consonantes = "";

            for (int i = 0; i < cadena.Length; i++)
            {
                char letra = cadena[i];
               
                if (65 <= letra && letra <= 90)
                {
                    consonantes = consonantes+ letra ;
                    contadorConsonates=contadorConsonates+ 1;
                }
            }
            txtnumConsPreg10.Text = contadorConsonates.ToString();
            txtConsoPreg10.Text = consonantes;

        }
    }
}
