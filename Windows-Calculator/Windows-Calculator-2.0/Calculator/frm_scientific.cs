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
    public partial class frm_scientific : Form
    {
        public frm_scientific()
        {
            InitializeComponent();
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

        private void btn_type_Click(object sender, EventArgs e)
        {
            new frm_main().Show();
            this.Hide();
        }

        private void btn_radicex_Click(object sender, EventArgs e)
        {
            try
            {
                double num = Convert.ToDouble(lbl_storico.Text);
                double ris = Math.Sqrt(num);
                lbl_risultato.Text = ris.ToString();

                lbl_storico.Text = "√" + lbl_storico.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Devi prima inserire un numero e poi cliccare sulla radice per ottenerla!", "Errore!", MessageBoxButtons.OK);
            }
        }

        private void btn_elevato_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Non disponibile ancora!", "Messaggio da Sabaudo", MessageBoxButtons.OK);
        }

        private void btn_second_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Non disponibile ancora!", "Messaggio da Sabaudo", MessageBoxButtons.OK);
        }

        private void btn_elevato2_Click(object sender, EventArgs e)
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

        private void btn_elevato10_Click(object sender, EventArgs e)
        {
            try
            {
                double num = Convert.ToDouble(lbl_storico.Text);
                double ris = Math.Pow(10, num);
                lbl_risultato.Text = ris.ToString();

                lbl_storico.Text =  "10^" + lbl_storico.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Devi prima inserire un numero e poi cliccare sull'elevazione per ottenerla!", "Errore!", MessageBoxButtons.OK);
            }
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            try
            {
                double num = Convert.ToDouble(lbl_storico.Text);
                double ris = Math.Log10(num);
                lbl_risultato.Text = ris.ToString();

                lbl_storico.Text = "log (" + lbl_storico.Text + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Devi prima inserire un numero e poi cliccare sul log per ottenerlo!", "Errore!", MessageBoxButtons.OK);
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            AggiungiNumero("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            AggiungiNumero("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            AggiungiNumero("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            AggiungiNumero("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            AggiungiNumero("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            AggiungiNumero("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            AggiungiNumero("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            AggiungiNumero("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            AggiungiNumero("9");
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            AggiungiNumero("0");
        }

        private void btn_meno1_Click(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show("Errore! Operazione non valida!", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_storico.Text = "";
                lbl_risultato.Text = "";
            }
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            AggiungiOperatore(".");
        }

        private void btn_piu_Click(object sender, EventArgs e)
        {
            AggiungiOperatore("+");
        }

        private void btn_meno_Click(object sender, EventArgs e)
        {
            AggiungiOperatore("-");
        }

        private void btn_per_Click(object sender, EventArgs e)
        {
            AggiungiOperatore("*");
        }

        private void btn_diviso_Click(object sender, EventArgs e)
        {
            AggiungiOperatore("÷");
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Non disponibile ancora!", "Messaggio da Sabaudo", MessageBoxButtons.OK);
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Non disponibile ancora!", "Messaggio da Sabaudo", MessageBoxButtons.OK);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                double num = Convert.ToDouble(lbl_storico.Text);
                if (num == 0)
                {
                    MessageBox.Show("Divisione per 0 = infinito!", "Errore!", MessageBoxButtons.OK);
                }
                else
                {
                    double ris = 1 / num;
                    lbl_risultato.Text = ris.ToString();

                    lbl_storico.Text = "1/" + lbl_storico.Text;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Devi prima inserire un numero e poi cliccare sull'divisione!", "Errore!", MessageBoxButtons.OK);
            }
        }

        private void btn_modulo_Click(object sender, EventArgs e)
        {
            if (lbl_storico.Text != "")
            {
                try
                {
                    string expression = lbl_storico.Text;

                    expression = expression.Replace("-", "+");

                    DataTable tempTable = new DataTable();
                    var result = tempTable.Compute(expression, "");

                    lbl_risultato.Text = result.ToString();

                    lbl_storico.Text = expression;
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

        private void btn_calcola_Click(object sender, EventArgs e)
        {
            if (lbl_storico.Text != "")
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

        private void btn_ln_Click(object sender, EventArgs e)
        {
            try
            {
                double num = Convert.ToDouble(lbl_storico.Text);
                double ris = Math.Log(num);
                lbl_risultato.Text = ris.ToString();

                lbl_storico.Text = "ln (" + lbl_storico.Text + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Devi prima inserire un numero e poi cliccare sul ln per ottenerlo!", "Errore!", MessageBoxButtons.OK);
            }
        }

        private void btn_ps_Click(object sender, EventArgs e)
        {
            AggiungiOperatore("(");
        }

        private void btn_pd_Click(object sender, EventArgs e)
        {
            AggiungiOperatore(")");
        }

        private void btn_n_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(lbl_storico.Text);

                if (num < 0)
                {
                    MessageBox.Show("Il fattoriale è definito solo per numeri non negativi.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    long risultato = 1;

                    for (int i = 1; i <= num; i++)
                    {
                        risultato *= i;
                    }

                    lbl_risultato.Text = risultato.ToString();
                    lbl_storico.Text = num + "!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Devi prima inserire un numero intero e poi cliccare sul fattoriale.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            lbl_storico.Text = "";
            lbl_risultato.Text = "";
        }

        private void btn_pi_Click(object sender, EventArgs e)
        {
            lbl_storico.Text = "3.1415";
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Non disponibile ancora!", "Messaggio da Sabaudo", MessageBoxButtons.OK);
        }
    }
}
