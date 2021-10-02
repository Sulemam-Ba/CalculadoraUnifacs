using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unifacs_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            //DECLARAÇÃO DE VARIÁVEIS, DETERMINANDO SEU TIPO DOUBLE
            double n1 = 0, n2 = 0, media = 0, c1 = 0, c2 = 0;

            //CONVERTER STRING DA CAIXAS DE TEXTO PARA O TIPO DOUBLE
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);

            c1 = n1 * 0.4;
            c2 = n2 * 0.6;


            //CALCULA AS 4 NOTAS INFORMADAS PELO USUÁRIO
            media = c1 + c2;
            mostramedia.Text = Convert.ToString(media);
        }
    }
}
