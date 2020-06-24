using N2___Animais.ANIMAIS;
using N2___Animais.ESTRUTURA_DADOS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace N2___Animais
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        ArvoreBinaria arvore = new ArvoreBinaria();
        

        /// <summary>
        /// Carrega o nome do animal no topo e seleciona no combobox invisivel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            label8.Text = $"CADASTRANDO UM(A) {PegaAnimalSelecionado.ToUpper()}";
            foreach (string linha in cmbTipoAnimal.Items)
            {
                if (linha.ToUpper() == PegaAnimalSelecionado.ToUpper())
                {
                    cmbTipoAnimal.SelectedItem = linha;
                    break;
                }
            }
        }
        
        /// <summary>
        /// Validação de Espécie do Animal e libera o componente certo para cada um
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTipoAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoAnimal.SelectedIndex == 0)
            {
                grpMamifero.Enabled = true;
                txtCorPelo.Enabled = false;
                grpAve.Enabled = false;
            }
            else if (cmbTipoAnimal.SelectedIndex > 0 && cmbTipoAnimal.SelectedIndex < 7)
            {
                grpMamifero.Enabled = true;
                grpAve.Enabled = false;
                txtCorPelo.Enabled = true;
            }
            else if (cmbTipoAnimal.SelectedIndex > 6 && cmbTipoAnimal.SelectedIndex < 11)
            {
                grpMamifero.Enabled = false;
                grpAve.Enabled = true;
                txtCorPena.Enabled = true;
            }

            else if (cmbTipoAnimal.SelectedIndex > 10 && cmbTipoAnimal.SelectedIndex < 13)
            {
                grpMamifero.Enabled = false;
                grpAve.Enabled = true;
                txtCorPena.Enabled = true;
                nmrAlturaMax.Enabled = false;
                nmrVelocidadeMAx.Enabled = false;
            }
            else
            {
                grpMamifero.Enabled = false;
                grpAve.Enabled = false;
            }
        }
        
        /// <summary>
        /// Validações para cadastrar o animal e chama método de instanciamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoAnimal.SelectedIndex >= 0 && cmbTipoAnimal.SelectedIndex < 7)
                    InstanciaMamifero(PegaAnimalSelecionado, txtNome.Text, txtCorPelo.Text, DateTime.Parse(txtDataNascimento.Text), char.Parse(cmbSexo.SelectedItem.ToString()), int.Parse(nmrQtdMamas.Text));

                else if (cmbTipoAnimal.SelectedIndex >= 7 && cmbTipoAnimal.SelectedIndex < 13)
                    InstanciaAve(PegaAnimalSelecionado, txtNome.Text, txtCorPena.Text, DateTime.Parse(txtDataNascimento.Text), char.Parse(cmbSexo.SelectedItem.ToString()), int.Parse(nmrAlturaMax.Text), int.Parse(nmrVelocidadeMAx.Text));

                else if (cmbTipoAnimal.SelectedIndex == 13)
                    InstanciaReptil(PegaAnimalSelecionado, txtNome.Text, DateTime.Parse(txtDataNascimento.Text), char.Parse(cmbSexo.SelectedItem.ToString()));


                LimpaComponentes();

                MessageBox.Show("Sucesso", "CONCLUÍDO");
            }
            catch
            {
                MessageBox.Show("Algum dado inválido");
            }

        }

        /// <summary>
        /// Limpa os componentes do form após o cadastro concluído
        /// </summary>
        public void LimpaComponentes()
        {
            txtNome.Text = String.Empty;
            cmbSexo.SelectedIndex = -1;
            txtDataNascimento.Text = String.Empty;
            txtCorPelo.Text = String.Empty;
            txtCorPena.Text = String.Empty;
            nmrQtdMamas.Value = 0;
            nmrAlturaMax.Value = 0;
            nmrVelocidadeMAx.Value = 0;
        }

        /// <summary>
        /// Pega o animal que foi selecionado pelo usuário 
        /// </summary>
        public string PegaAnimalSelecionado { get; set; }


        #region Métodos de Instanciamento
        /// <summary>
        /// Método para instanciar um mamífero
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public void InstanciaMamifero(string animal, string nome, string corpelo, DateTime nascimento, char sexo, int qtdemamas)
        {
            switch (animal)
            {
                case "baleia":
                    try
                    {
                        Baleia baleia = new Baleia(false, true, false, false, true, false);
                        baleia.Nome = nome;
                        baleia.DataNascimento = nascimento;
                        baleia.Sexo = sexo;
                        baleia.QtdeMamas = qtdemamas;
                        //Adicionar na lista
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Algum dado inválido");
                        break;
                    }

                case "cachorro":
                    try
                    {
                        Cachorro cachorro = new Cachorro(true, false, true);
                        cachorro.Nome = nome;
                        cachorro.CorPelo = corpelo;
                        cachorro.DataNascimento = nascimento;
                        cachorro.Sexo = sexo;
                        cachorro.QtdeMamas = qtdemamas;

                        //Adicionar na lista
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Algum dado inválido");
                        break;
                    }

                case "elefante":
                    try
                    {
                        Elefante elefante = new Elefante(false, false, true);
                        elefante.Nome = nome;
                        elefante.CorPelo = corpelo;
                        elefante.DataNascimento = nascimento;
                        elefante.Sexo = sexo;
                        elefante.QtdeMamas = qtdemamas;
                        //Adicionar na lista
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Algum dado inválido");
                        break;
                    }

                case "gato":
                    try
                    {
                        Gato gato = new Gato(true, false, true);
                        gato.Nome = nome;
                        gato.CorPelo = corpelo;
                        gato.DataNascimento = nascimento;
                        gato.Sexo = sexo;
                        gato.QtdeMamas = qtdemamas;
                        //Adicionar na lista
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Algum dado inválido");
                        break;
                    }

                case "leao":
                    try
                    {
                        Leao leao = new Leao(true, false, true);
                        leao.Nome = nome;
                        leao.CorPelo = corpelo;
                        leao.DataNascimento = nascimento;
                        leao.Sexo = sexo;
                        leao.QtdeMamas = qtdemamas;
                        //Adicionar na lista
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Algum dado inválido");
                        break;
                    }

                case "morcego":
                    try
                    {
                        Morcego morcego = new Morcego(false, false, true);
                        morcego.Nome = nome;
                        morcego.CorPelo = corpelo;
                        morcego.DataNascimento = nascimento;
                        morcego.Sexo = sexo;
                        morcego.QtdeMamas = qtdemamas;
                        //Adicionar na lista
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Algum dado inválido");
                        break;
                    }

                case "ornitorrinco":
                    try
                    {
                        Ornitorrinco ornitorrinco = new Ornitorrinco(true, false, true, true, true, true);
                        ornitorrinco.Nome = nome;
                        ornitorrinco.CorPelo = corpelo;
                        ornitorrinco.DataNascimento = nascimento;
                        ornitorrinco.Sexo = sexo;
                        ornitorrinco.QtdeMamas = qtdemamas;
                        //Adicionar na lista
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Algum dado inválido");
                        break;
                    }
            }
        }

        /// <summary>
        /// Instanciar uma ave
        /// </summary>
        /// <param name="animal"></param>
        /// <param name="nome"></param>
        /// <param name="corpena"></param>
        /// <param name="nascimento"></param>
        /// <param name="sexo"></param>
        /// <param name="altura"></param>
        /// <param name="velocidade"></param>
        public void InstanciaAve(string animal, string nome, string corpena, DateTime nascimento, char sexo, int altura, int velocidade)
        {
            switch (animal)
            {
                case "galinha":
                    try
                    {
                        Galinha galinha = new Galinha(false, false, false);
                        galinha.Nome = nome;
                        galinha.CorPena = corpena;
                        galinha.DataNascimento = nascimento;
                        galinha.Sexo = sexo;
                        //Adicionar na lista
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Algum dado inválido");
                        break;
                    }


                case "coruja":
                    try
                    {
                        Coruja coruja = new Coruja(true, true, false);
                        coruja.Nome = nome;
                        coruja.CorPena = corpena;
                        coruja.DataNascimento = nascimento;
                        coruja.Sexo = sexo;
                        coruja.AlturaMaximaM = altura;
                        coruja.VelocidadeVoo = velocidade;
                        int idade = coruja.Idade;
                        //Adicionar na lista
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Algum dado inválido");
                        break;
                    }

                case "gaviao":
                    try
                    {
                        Gaviao gaviao = new Gaviao(true, true, false);
                        gaviao.Nome = nome;
                        gaviao.CorPena = corpena;
                        gaviao.DataNascimento = nascimento;
                        gaviao.Sexo = sexo;
                        gaviao.AlturaMaximaM = altura;
                        gaviao.VelocidadeVoo = velocidade;
                        //Adicionar na lista
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Algum dado inválido");
                        break;
                    }




                case "pato":
                    try
                    {
                        Pato pato = new Pato(false, false, false, true, true, true);
                        pato.Nome = nome;
                        pato.CorPena = corpena;
                        pato.DataNascimento = nascimento;
                        pato.Sexo = sexo;
                        pato.AlturaMaximaM = altura;
                        pato.VelocidadeVoo = velocidade;
                        //Adicionar na lista
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Algum dado inválido");
                        break;
                    }


                case "pinguim":
                    try
                    {
                        Pinguim pinguim = new Pinguim(true, false, false);
                        pinguim.Nome = nome;
                        pinguim.CorPena = corpena;
                        pinguim.DataNascimento = nascimento;
                        pinguim.Sexo = sexo;
                        //Adicionar na lista
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Algum dado inválido");
                        break;
                    }


                case "pombo":
                    try
                    {
                        Pombo pombo = new Pombo(false, false, false);
                        pombo.Nome = nome;
                        pombo.CorPena = corpena;
                        pombo.DataNascimento = nascimento;
                        pombo.Sexo = sexo;
                        pombo.AlturaMaximaM = altura;
                        pombo.VelocidadeVoo = velocidade;
                        //Adicionar na lista
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Algum dado inválido");
                        break;
                    }

            }
        }

        /// <summary>
        /// Instanciar um Réptil
        /// </summary>
        /// <param name="animal"></param>
        /// <param name="nome"></param>
        /// <param name="nascimento"></param>
        /// <param name="sexo"></param>
        public void InstanciaReptil(string animal, string nome, DateTime nascimento, char sexo)
        {
            try
            {
                Tartaruga tartaruga = new Tartaruga(false, false, true, true, true, true, true);
                tartaruga.Nome = nome;
                tartaruga.DataNascimento = nascimento;
                tartaruga.Sexo = sexo;
            }
            catch
            {
                MessageBox.Show("Algum dado inválido");
            }
        }
        #endregion
    }
}
