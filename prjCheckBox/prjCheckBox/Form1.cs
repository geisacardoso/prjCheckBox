using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // declara a matriz com os valores
            string[] linguagens = new string[] { "Cobo", "Assembler", "Java", "C Sharp" };
            // percorre a lista e preenche o listbox
            foreach (var linguagem in linguagens)
            {
                lista.Items.Add(linguagem);
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string linguagens = "voce selecionou: \n";
            for(int i = 0; i < lista.Items.Count; i++)
            {
                CheckState estado = lista.GetItemCheckState(i);
                if (estado == CheckState.Checked) linguagens += lista.Items[i].ToString() + "\n";
            }
            MessageBox.Show(linguagens);
        }
    }
}
