using System;
using N2___Animais.ANIMAIS;
using N2___Animais.ESTRUTURA_DADOS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2___Animais
{
    public partial class Listagem : Form
    {
        public Listagem()
        {
            InitializeComponent();
        }

        
        Lista listar = new Lista();

        //listar = ArvoreBinaria.ListagemInterfixada();
        //textBox1.Text = ArvoreBinaria.ListagemInterfixada().Listar();

    }
}
