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
            double n1 = 0, n2 = 0, n3 = 0, n4 = 0, media = 0;

            //CONVERTER STRING DA CAIXAS DE TEXTO PARA O TIPO DOUBLE
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            n3 = double.Parse(textBox3.Text);
            n4 = double.Parse(textBox4.Text);

            //CALCULA AS 4 NOTAS INFORMADAS PELO USUÁRIO
            media = (n1 + n2 + n3 + n4) / 4;
            mostramedia.Text = Convert.ToString(media);
        }
    }
}
