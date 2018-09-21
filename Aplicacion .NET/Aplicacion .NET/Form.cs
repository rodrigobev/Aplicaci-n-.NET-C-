using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculos;

namespace Aplicacion.NET {
    public partial class Form : System.Windows.Forms.Form {

        calculos calc = new calculos();

        public Form() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        // Verifica que la referencia esté compuesta únicamente por dígitos. 
        private bool digitsOnly (string str) {

            foreach (char c in str) {
                if (c < '0' || c > '9') {
                    return false;
                }
            }

            return true;
        }

        private void button_Click(object sender, EventArgs e) {

            string referencia = inputTextBox.Text;


            if (digitsOnly(referencia) && (referencia.Length >= 1 && referencia.Length <= 19)) {
                outputTextBox.Text = calc.calcular(referencia);
            }
            else {
                inputTextBox.Text = "";
                MessageBox.Show("Valor inválido. Favor de introducir una referencia de 1 a 19 dígitos.");
            }

        }
    }
}
