using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void AggiungiNumero(string numero)
        {
            if (lbl_storico.Text == "0")
            {
                lbl_storico.Text = numero;
            }
            else
            {
                lbl_storico.Text += numero;
            }
        }
        private void AggiungiOperatore(string operatore)
        {
            if (string.IsNullOrEmpty(lbl_storico.Text))
                return;

            char ultimoCarattere = lbl_storico.Text[lbl_storico.Text.Length - 1];
            if (ultimoCarattere != '+' && ultimoCarattere != '-' && ultimoCarattere != '*' && ultimoCarattere != '/')
            {
                lbl_storico.Text += operatore;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AggiungiNumero("7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AggiungiNumero("8");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AggiungiNumero("9");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AggiungiNumero("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AggiungiNumero("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AggiungiNumero("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AggiungiNumero("1");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AggiungiNumero("2");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AggiungiNumero("3");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                double num = Convert.ToDouble(lbl_storico.Text);
                if (num > 0)
                {
                    lbl_storico.Text = "-" + lbl_storico.Text;
                }
                else
                {
                    lbl_storico.Text = (num * -1).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore! Operazione non valida!", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_storico.Text = "";
                lbl_risultato.Text = "";
            }
            
                
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AggiungiNumero("0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AggiungiOperatore(".");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            AggiungiOperatore("+");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AggiungiOperatore("-");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AggiungiOperatore("÷");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AggiungiOperatore("*");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbl_storico.Text = "";
            lbl_risultato.Text = "";
        }

        private void btn_calcola_Click(object sender, EventArgs e)
        {
            if(lbl_storico.Text != "")
            {
                try
                {
                    string expression = lbl_storico.Text;

                    expression = expression.Replace("÷", "/");

                    DataTable tempTable = new DataTable();
                    var result = tempTable.Compute(expression, "");

                    lbl_risultato.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    lbl_risultato.Text = "Errore";
                }
            }
            else
            {
                MessageBox.Show("Controllare l'operazione desiderata!");
            }
            
        }

        private void btn_type_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Non disponibile ancora!", "Messaggio da Sabaudo", MessageBoxButtons.OK);
        }

            private void btn_radice_Click(object sender, EventArgs e)
        {
            try
            {
                double numero = Convert.ToDouble(lbl_storico.Text);
                double ris = Math.Sqrt(numero);
                lbl_risultato.Text = ris.ToString();

                lbl_storico.Text = "√" + lbl_storico.Text;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Devi prima inserire un numero e poi cliccare sulla radice per ottenerla!", "Errore!", MessageBoxButtons.OK);
            }
            
        }

        private void btn_elevato_Click(object sender, EventArgs e)
        {

            try
            {
                double numero = Convert.ToDouble(lbl_storico.Text);
                double ris = Math.Pow(numero, 2);
                lbl_risultato.Text = ris.ToString();

                lbl_storico.Text = lbl_storico.Text + "²";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Devi prima inserire un numero e poi cliccare sull'elevazione per ottenerla!", "Errore!", MessageBoxButtons.OK);
            }
            
        }

        private void btn_frazione_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Non disponibile ancora!", "Messaggio da Sabaudo", MessageBoxButtons.OK);

        }


        private void btn_percentuale_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Non disponibile ancora!", "Messaggio da Sabaudo", MessageBoxButtons.OK);
        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            lbl_storico.Text = "";
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            if (lbl_storico.Text.Length > 0)
            {
                lbl_storico.Text = lbl_storico.Text.Substring(0, lbl_storico.Text.Length - 1);
            }

        }
    }
}
