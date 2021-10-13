using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TratamentoErro
{
    public partial class TelaErro : Form
    {
        public TelaErro()
        {
            InitializeComponent();
        }

        private void buttonTeste_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = 10;
                int n2 = 5;
                int result = n1 / n2;

                labelResultado.Text = string.Format("{0} / {1} = {2}", n1.ToString(), n2.ToString(), result.ToString());
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Erro ao tentar executar o programa", "Alertar de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonThrow_Click(object sender, EventArgs e)
        {
            try {
                int n1 = 80;
                int n2 = 10;

                if (n2 == 10)
                {
                    throw new Exception("Divisão por dez não pode!!");
                }
                int result = n1 / n2;
                labelResultado.Text = string.Format("{0} / {1} = {2}", n1.ToString(), n2.ToString(), result.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção");
            }
            finally
            {
                MessageBox.Show("Sempre passa por aqui");
            }
    }
    }
}
