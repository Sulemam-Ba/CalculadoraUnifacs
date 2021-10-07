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
            //DECLARAÇÃO DE VARIÁVEIS, DETERMINANDO SEU TIPO DOUBLE.
            double at1 = 0, at2 = 0, at3 = 0, at4 = 0, n1 = 0, prvn2 = 0, c1 = 0, c2 = 0, mediaat = 0, media = 0;

            //CONVERTER STRING DA CAIXAS DE TEXTO PARA O TIPO DOUBLE.
            at1 = double.Parse(ATV1.Text);
            at2 = double.Parse(ATV2.Text);
            at3 = double.Parse(ATV3.Text);
            at4 = double.Parse(ATV4.Text);
            prvn2 = double.Parse(PROVA.Text);

            //CALCULA AS NOTAS DAS 4 ATIVIDADES.
            mediaat = (at1 + at2 + at3 + at4) / 4 ;

            //CALCULO MULTIPLICA AS NOTAS A OS PESOS DE VALORES.
            c1 = mediaat * 0.4;
            c2 = prvn2 * 0.6;


            //CALCULA AS A NOTA DAS ATIVIDADES COM AS DA PROVA. 
            media = c1 + c2;

            //MOSTRA O RESULTADO
            mostramedia.Text = Convert.ToString(media);

            //ESTRUTURA CONDICIONAL
            if (media >= 6)
            {
                
                RESULTADO.Text = "APROVADO";
            }
            else
            {
                RESULTADO.Text = "REPROVADO";
            }
           

            //LIMPAR TEXTBOX
            ATV1.Clear();
            ATV2.Clear();
            ATV3.Clear();
            ATV4.Clear();
            PROVA.Clear();


        }
    }
}
