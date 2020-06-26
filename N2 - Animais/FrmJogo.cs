using N2___Animais.ESTRUTURA_DADOS;
using N2___Animais.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace N2___Animais
{
    public partial class FrmJogo : Form
    {
        public FrmJogo()
        {
            InitializeComponent();
            DicionarioBotoes();
        }

        SortedDictionary<string, bool> selecionados = new SortedDictionary<string, bool>();


        /// <summary>
        /// Volta a imagem para seu modo original
        /// </summary>
        /// <param name="animalclicado"></param>
        public void VoltaImagem(string animalclicado)
        {
            foreach (Control botao in Controls)
            {
                if (botao is Button)
                {
                    string animal = Convert.ToString(botao.Tag);
                    switch (animal)
                    {
                        case "baleia":
                            if (animal == animalclicado)
                                break;
                            selecionados["baleia"] = false;
                            botao.BackgroundImage = Resources.baleiaapagada;
                            btnBaleia.BackColor = Color.LightYellow;
                            break;

                        case "cachorro":
                            if (animal == animalclicado)
                                break;
                            selecionados["cachorro"] = false;
                            botao.BackgroundImage = Resources.cachorroapagado;
                            btnCachorro.BackColor = Color.LightYellow;
                            break;

                        case "coruja":
                            if (animal == animalclicado)
                                break;
                            selecionados["coruja"] = false;
                            botao.BackgroundImage = Resources.corujaapagada;
                            btnCoruja.BackColor = Color.LightYellow;
                            break;

                        case "elefante":
                            if (animal == animalclicado)
                                break;
                            selecionados["elefante"] = false;
                            botao.BackgroundImage = Resources.elefanteapagado;
                            btnElefante.BackColor = Color.LightYellow;
                            break;

                        case "galinha":
                            if (animal == animalclicado)
                                break;
                            selecionados["galinha"] = false;
                            botao.BackgroundImage = Resources.galinhaapagada;
                            btnGalinha.BackColor = Color.LightYellow;
                            break;

                        case "gato":
                            if (animal == animalclicado)
                                break;
                            selecionados["gato"] = false;
                            botao.BackgroundImage = Resources.gatoapagado;
                            btnGato.BackColor = Color.LightYellow;
                            break;

                        case "gaviao":
                            if (animal == animalclicado)
                                break;
                            selecionados["gaviao"] = false;
                            botao.BackgroundImage = Resources.gaviaoapagado;
                            btnGaviao.BackColor = Color.LightYellow;
                            break;

                        case "leao":
                            if (animal == animalclicado)
                                break;
                            selecionados["leao"] = false;
                            botao.BackgroundImage = Resources.leaoapagado;
                            btnLeao.BackColor = Color.LightYellow;
                            break;


                        case "morcego":
                            if (animal == animalclicado)
                                break;
                            selecionados["morcego"] = false;
                            botao.BackgroundImage = Resources.morcegoapagado;
                            btnMorcego.BackColor = Color.LightYellow;
                            break;

                        case "ornitorrinco":
                            if (animal == animalclicado)
                                break;
                            selecionados["ornitorrinco"] = false;
                            botao.BackgroundImage = Resources.ornitorrincoapagado;
                            btnOrnitorrinco.BackColor = Color.LightYellow;
                            break;

                        case "pato":
                            if (animal == animalclicado)
                                break;
                            selecionados["pato"] = false;
                            botao.BackgroundImage = Resources.patoapagado;
                            btnPato.BackColor = Color.LightYellow;
                            break;

                        case "pinguim":
                            if (animal == animalclicado)
                                break;
                            selecionados["pinguim"] = false;
                            botao.BackgroundImage = Resources.pinguimapagado;
                            btnPinguim.BackColor = Color.LightYellow;
                            break;

                        case "pombo":
                            if (animal == animalclicado)
                                break;
                            selecionados["pombo"] = false;
                            botao.BackgroundImage = Resources.pomboapagado;
                            btnPombo.BackColor = Color.LightYellow;
                            break;

                        case "tartaruga":
                            if (animal == animalclicado)
                                break;
                            selecionados["tartaruga"] = false;
                            botao.BackgroundImage = Resources.tartarugaapagada;
                            btnTartaruga.BackColor = Color.LightYellow;
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Adicionar os animais no dicíonário para seleção
        /// </summary>
        public void DicionarioBotoes()
        {
            selecionados.Add("baleia", false);
            selecionados.Add("cachorro", false);
            selecionados.Add("coruja", false);
            selecionados.Add("elefante", false);
            selecionados.Add("galinha", false);
            selecionados.Add("gato", false);
            selecionados.Add("gaviao", false);
            selecionados.Add("leao", false);
            selecionados.Add("morcego", false);
            selecionados.Add("ornitorrinco", false);
            selecionados.Add("pato", false);
            selecionados.Add("pinguim", false);
            selecionados.Add("pombo", false);
            selecionados.Add("tartaruga", false);
        }

        /// <summary>
        /// Método usado quando seleciona um animal
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="botao"></param>
        public void EventoClique(string tag, Control botao)
        {
            selecionados[tag] = true;
            VoltaImagem(botao.Tag.ToString());
        }

        //Todos os eventos dos botões
        #region EVENTOS BOTÕES

        //Botões dos animais
        #region ANIMAIS
        private void btnBaleia_Click(object sender, EventArgs e)
        {
            EventoClique(btnBaleia.Tag.ToString(), btnBaleia);
            btnBaleia.BackgroundImage = Resources.baleialaranja;
            btnBaleia.BackColor = Color.Orange;
            ApagaImagens();
            pnlFundoAcao.BackgroundImage = Resources.praia;
            pctAgua.BackgroundImage = Resources.baleiaapagada;

            //Botoes de ação 
            DesativaBotoes();
            btnAmamentar.Enabled = true;
            btnMovimentar.Enabled = true;
            string[] nomes = ArvoreBinaria.ListagemInterfixada().VetorPorAnimal("baleia");
            cmbAnimais.Items.Clear();
            foreach (string linha in nomes)
            {
                if (linha != null)
                    cmbAnimais.Items.Add(linha);
            }
        }

        private void btnCachorro_Click(object sender, EventArgs e)
        {
            EventoClique(btnCachorro.Tag.ToString(), btnCachorro);
            btnCachorro.BackgroundImage = Resources.cachorrolaranja;
            btnCachorro.BackColor = Color.Orange;
            ApagaImagens();
            VoltaTamanho();
            pnlFundoAcao.BackgroundImage = Resources.gramado;
            pctChao.BackgroundImage = Resources.cachorroapagado;

            DesativaBotoes();
            btnAmamentar.Enabled = true;
            btnMovimentar.Enabled = true;

            string[] nomes = ArvoreBinaria.ListagemInterfixada().VetorPorAnimal("cachorro");
            cmbAnimais.Items.Clear();

            foreach (string linha in nomes)
            {
                if (linha != null)
                    cmbAnimais.Items.Add(linha);
            }
        }

        private void btnCoruja_Click(object sender, EventArgs e)
        {
            EventoClique(btnCoruja.Tag.ToString(), btnCoruja);
            btnCoruja.BackgroundImage = Resources.corujalaranja;
            btnCoruja.BackColor = Color.Orange;
            ApagaImagens();
            pnlFundoAcao.BackgroundImage = Resources.noite;
            pctArvore.BackgroundImage = Resources.corujaapagada;

            DesativaBotoes();
            btnBotar.Enabled = true;
            btnChocar.Enabled = true;
            btnVoar.Enabled = true;
            btnMovimentar.Enabled = true;

            string[] nomes = ArvoreBinaria.ListagemInterfixada().VetorPorAnimal("coruja");
            cmbAnimais.Items.Clear();
            foreach (string linha in nomes)
            {
                if (linha != null)
                    cmbAnimais.Items.Add(linha);
            }
        }

        private void btnElefante_Click(object sender, EventArgs e)
        {
            EventoClique(btnElefante.Tag.ToString(), btnElefante);
            btnElefante.BackgroundImage = Resources.elefantelaranja;
            btnElefante.BackColor = Color.Orange;
            ApagaImagens();
            pctChao.Width = 250;
            pctChao.Height = 250;
            pctChao.Location = new Point(254, 248);
            pnlFundoAcao.BackgroundImage = Resources.lago;
            pctChao.BackgroundImage = Resources.elefanteapagado;

            DesativaBotoes();
            btnAmamentar.Enabled = true;
            btnMovimentar.Enabled = true;

            string[] nomes = ArvoreBinaria.ListagemInterfixada().VetorPorAnimal("elefante");
            cmbAnimais.Items.Clear();
            foreach (string linha in nomes)
            {
                if (linha != null)
                    cmbAnimais.Items.Add(linha);
            }
        }

        private void btnGalinha_Click(object sender, EventArgs e)
        {
            EventoClique(btnGalinha.Tag.ToString(), btnGalinha);
            btnGalinha.BackgroundImage = Resources.galinhalaranja;
            btnGalinha.BackColor = Color.Orange;
            ApagaImagens();
            VoltaTamanho();
            pnlFundoAcao.BackgroundImage = Resources.lago;
            pctChao.BackgroundImage = Resources.galinhaapagada;

            DesativaBotoes();
            btnCiscar.Enabled = true;
            btnBotar.Enabled = true;
            btnChocar.Enabled = true;
            btnMovimentar.Enabled = true;

            string[] nomes = ArvoreBinaria.ListagemInterfixada().VetorPorAnimal("galinha");
            cmbAnimais.Items.Clear();
            foreach (string linha in nomes)
            {
                if (linha != null)
                    cmbAnimais.Items.Add(linha);
            }
        }

        private void btnGato_Click(object sender, EventArgs e)
        {
            EventoClique(btnGato.Tag.ToString(), btnGato);
            btnGato.BackgroundImage = Resources.gatolaranja;
            btnGato.BackColor = Color.Orange;
            ApagaImagens();
            VoltaTamanho();
            pnlFundoAcao.BackgroundImage = Resources.gramado;
            pctChao.BackgroundImage = Resources.gatoapagado;

            DesativaBotoes();
            btnAmamentar.Enabled = true;
            btnMovimentar.Enabled = true;

            string[] nomes = ArvoreBinaria.ListagemInterfixada().VetorPorAnimal("gato");
            cmbAnimais.Items.Clear();
            foreach (string linha in nomes)
            {
                if (linha != null)
                    cmbAnimais.Items.Add(linha);
            }
        }

        private void btnGaviao_Click(object sender, EventArgs e)
        {
            EventoClique(btnGaviao.Tag.ToString(), btnGaviao);
            btnGaviao.BackgroundImage = Resources.gaviaolarajna;
            btnGaviao.BackColor = Color.Orange;
            ApagaImagens();
            VoltaTamanho();
            pnlFundoAcao.BackgroundImage = Resources.gramado;
            pctChao.BackgroundImage = Resources.gaviaoapagado;

            DesativaBotoes();
            btnCiscar.Enabled = true;
            btnChocar.Enabled = true;
            btnVoar.Enabled = true;
            btnMovimentar.Enabled = true;

            string[] nomes = ArvoreBinaria.ListagemInterfixada().VetorPorAnimal("gaviao");
            cmbAnimais.Items.Clear();
            foreach (string linha in nomes)
            {
                if (linha != null)
                    cmbAnimais.Items.Add(linha);
            }
        }

        private void btnLeao_Click(object sender, EventArgs e)
        {
            EventoClique(btnLeao.Tag.ToString(), btnLeao);
            btnLeao.BackgroundImage = Resources.leaolaranja;
            btnLeao.BackColor = Color.Orange;
            ApagaImagens();
            pctChao.Width = 250;
            pctChao.Height = 250;
            pctChao.Location = new Point(254, 248);
            pnlFundoAcao.BackgroundImage = Resources.lago;
            pctChao.BackgroundImage = Resources.leaoapagado;

            DesativaBotoes();
            btnAmamentar.Enabled = true;
            btnMovimentar.Enabled = true;

            string[] nomes = ArvoreBinaria.ListagemInterfixada().VetorPorAnimal("leao");
            cmbAnimais.Items.Clear();
            foreach (string linha in nomes)
            {
                if (linha != null)
                    cmbAnimais.Items.Add(linha);
            }
        }

        private void btnMorcego_Click(object sender, EventArgs e)
        {
            EventoClique(btnMorcego.Tag.ToString(), btnMorcego);
            btnMorcego.BackgroundImage = Resources.morcegolaranja;
            btnMorcego.BackColor = Color.Orange;
            ApagaImagens();
            pnlFundoAcao.BackgroundImage = Resources.noite;
            pctArvore.BackgroundImage = Resources.morcegoapagado;

            DesativaBotoes();
            btnAmamentar.Enabled = true;
            btnVoar.Enabled = true;
            btnMovimentar.Enabled = true;

            string[] nomes = ArvoreBinaria.ListagemInterfixada().VetorPorAnimal("morcego");
            cmbAnimais.Items.Clear();
            foreach (string linha in nomes)
            {
                if (linha != null)
                    cmbAnimais.Items.Add(linha);
            }
        }

        private void btnOrnitorrinco_Click(object sender, EventArgs e)
        {
            EventoClique(btnOrnitorrinco.Tag.ToString(), btnOrnitorrinco);
            btnOrnitorrinco.BackgroundImage = Resources.ornitorrincolaranja;
            btnOrnitorrinco.BackColor = Color.Orange;
            ApagaImagens();
            VoltaTamanho();
            pnlFundoAcao.BackgroundImage = Resources.lago;
            pctChao.BackgroundImage = Resources.ornitorrincoapagado;

            DesativaBotoes();
            btnAmamentar.Enabled = true;
            btnBotar.Enabled = true;
            btnMovimentar.Enabled = true;

            string[] nomes = ArvoreBinaria.ListagemInterfixada().VetorPorAnimal("ornitorrinco");
            cmbAnimais.Items.Clear();
            foreach (string linha in nomes)
            {
                if (linha != null)
                    cmbAnimais.Items.Add(linha);
            }
        }

        private void btnPato_Click(object sender, EventArgs e)
        {
            EventoClique(btnPato.Tag.ToString(), btnPato);
            btnPato.BackgroundImage = Resources.patolaranja;
            btnPato.BackColor = Color.Orange;
            ApagaImagens();
            VoltaTamanho();
            pnlFundoAcao.BackgroundImage = Resources.lago;
            pctChao.BackgroundImage = Resources.patoapagado;

            DesativaBotoes();
            btnCiscar.Enabled = true;
            btnBotar.Enabled = true;
            btnVoar.Enabled = true;
            btnMovimentar.Enabled = true;

            string[] nomes = ArvoreBinaria.ListagemInterfixada().VetorPorAnimal("pato");
            cmbAnimais.Items.Clear();
            foreach (string linha in nomes)
            {
                if (linha != null)
                    cmbAnimais.Items.Add(linha);
            }
        }

        private void btnPinguim_Click(object sender, EventArgs e)
        {
            EventoClique(btnPinguim.Tag.ToString(), btnPinguim);
            btnPinguim.BackgroundImage = Resources.pinguimlaranja;
            btnPinguim.BackColor = Color.Orange;
            ApagaImagens();
            VoltaTamanho();
            pnlFundoAcao.BackgroundImage = Resources.gelo;
            pctChao.BackgroundImage = Resources.pinguimapagado;

            DesativaBotoes();
            btnCiscar.Enabled = true;
            btnBotar.Enabled = true;
            btnChocar.Enabled = true;
            btnMovimentar.Enabled = true;

            string[] nomes = ArvoreBinaria.ListagemInterfixada().VetorPorAnimal("pinguim");
            cmbAnimais.Items.Clear();
            foreach (string linha in nomes)
            {
                if (linha != null)
                    cmbAnimais.Items.Add(linha);
            }
        }

        private void btnPombo_Click(object sender, EventArgs e)
        {
            EventoClique(btnPombo.Tag.ToString(), btnPombo);
            btnPombo.BackgroundImage = Resources.pombolaranja;
            btnPombo.BackColor = Color.Orange;
            ApagaImagens();
            VoltaTamanho();
            pnlFundoAcao.BackgroundImage = Resources.gramado;
            pctChao.BackgroundImage = Resources.pomboapagado;

            DesativaBotoes();
            btnCiscar.Enabled = true;
            btnBotar.Enabled = true;
            btnChocar.Enabled = true;
            btnVoar.Enabled = true;
            btnMovimentar.Enabled = true;

            string[] nomes = ArvoreBinaria.ListagemInterfixada().VetorPorAnimal("pombo");
            cmbAnimais.Items.Clear();
            foreach (string linha in nomes)
            {
                if (linha != null)
                    cmbAnimais.Items.Add(linha);
            }
        }

        private void btnTartaruga_Click(object sender, EventArgs e)
        {
            EventoClique(btnTartaruga.Tag.ToString(), btnTartaruga);
            btnTartaruga.BackgroundImage = Resources.tartarugalarajna;
            btnTartaruga.BackColor = Color.Orange;
            ApagaImagens();
            VoltaTamanho();
            pnlFundoAcao.BackgroundImage = Resources.praia;
            pctChao.BackgroundImage = Resources.tartarugaapagada;

            DesativaBotoes();
            btnBotar.Enabled = true;
            btnMovimentar.Enabled = true;

            string[] nomes = ArvoreBinaria.ListagemInterfixada().VetorPorAnimal("tartaruga");
            cmbAnimais.Items.Clear();
            foreach (string linha in nomes)
            {
                if (linha != null)
                    cmbAnimais.Items.Add(linha);
            }
        }

        #endregion

        //Chama o form de cadastro
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FrmCadastro Cadastro = new FrmCadastro();
            foreach (var animal in selecionados)
            {
                if (animal.Value)
                {
                    Cadastro.PegaAnimalSelecionado = animal.Key;
                    Cadastro.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Selecione um animal", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;


        }

        //Chama o form de Listagem
        private void BtnListar_Click(object sender, EventArgs e)
        {
            FrmListagem listagem = new FrmListagem();
            listagem.ShowDialog();
        }

        //Eventos Mouse Leave e Enter
        #region"Evento  MouseEnter e MouseLeave"
        private void btnBaleia_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["baleia"])
                return;
            else if (!selecionados["baleia"])
                btnBaleia.BackgroundImage = Resources.baleiaverde;
        }

        private void btnBaleia_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["baleia"])
                return;

            btnBaleia.BackgroundImage = Resources.baleiaapagada;
        }

        private void btnCachorro_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["cachorro"])
                return;
            else if (!selecionados["cachorro"])
                btnCachorro.BackgroundImage = Resources.cachorroverde;
        }

        private void btnCachorro_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["cachorro"])
                return;

            btnCachorro.BackgroundImage = Resources.cachorroapagado;
        }

        private void btnCoruja_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["coruja"])
                return;
            else if (!selecionados["coruja"])
                btnCoruja.BackgroundImage = Resources.corujaverde;
        }

        private void btnCoruja_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["coruja"])
                return;

            btnCoruja.BackgroundImage = Resources.corujaapagada;
        }

        private void btnElefante_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["elefante"])
                return;
            else if (!selecionados["elefante"])
                btnElefante.BackgroundImage = Resources.elefanteverde;
        }

        private void btnElefante_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["elefante"])
                return;

            btnElefante.BackgroundImage = Resources.elefanteapagado;
        }

        private void btnGalinha_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["galinha"])
                return;
            else if (!selecionados["galinha"])
                btnGalinha.BackgroundImage = Resources.galinhaverde;
        }

        private void btnGalinha_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["galinha"])
                return;

            btnGalinha.BackgroundImage = Resources.galinhaapagada;
        }

        private void btnGato_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["gato"])
                return;
            else if (!selecionados["gato"])
                btnGato.BackgroundImage = Resources.gatoverde;
        }

        private void btnGato_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["gato"])
                return;

            btnGato.BackgroundImage = Resources.gatoapagado;
        }

        private void btnGaviao_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["gaviao"])
                return;
            else if (!selecionados["gaviao"])
                btnGaviao.BackgroundImage = Resources.gaviaoverde;
        }

        private void btnGaviao_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["gaviao"])
                return;

            btnGaviao.BackgroundImage = Resources.gaviaoapagado;
        }

        private void btnLeao_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["leao"])
                return;
            else if (!selecionados["leao"])
                btnLeao.BackgroundImage = Resources.leaoverde;
        }

        private void btnLeao_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["leao"])
                return;

            btnLeao.BackgroundImage = Resources.leaoapagado;
        }

        private void btnMorcego_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["morcego"])
                return;
            else if (!selecionados["morcego"])
                btnMorcego.BackgroundImage = Resources.mocegoverde;
        }

        private void btnMorcego_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["morcego"])
                return;

            btnMorcego.BackgroundImage = Resources.morcegoapagado;
        }

        private void btnOrnitorrinco_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["ornitorrinco"])
                return;
            else if (!selecionados["ornitorrinco"])
                btnOrnitorrinco.BackgroundImage = Resources.ornitorrincoverde;
        }

        private void btnOrnitorrinco_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["ornitorrinco"])
                return;

            btnOrnitorrinco.BackgroundImage = Resources.ornitorrincoapagado;
        }

        private void btnPato_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["pato"])
                return;
            else if (!selecionados["pato"])
                btnPato.BackgroundImage = Resources.patoverde;
        }

        private void btnPato_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["pato"])
                return;

            btnPato.BackgroundImage = Resources.patoapagado;
        }

        private void btnPinguim_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["pinguim"])
                return;
            else if (!selecionados["pinguim"])
                btnPinguim.BackgroundImage = Resources.pinguimverde;
        }

        private void btnPinguim_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["pinguim"])
                return;

            btnPinguim.BackgroundImage = Resources.pinguimapagado;
        }

        private void btnPombo_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["pombo"])
                return;
            else if (!selecionados["pombo"])
                btnPombo.BackgroundImage = Resources.pomboverde;
        }

        private void btnPombo_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["pombo"])
                return;

            btnPombo.BackgroundImage = Resources.pomboapagado;
        }

        private void btnTartaruga_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["tartaruga"])
                return;
            else if (!selecionados["tartaruga"])
                btnTartaruga.BackgroundImage = Resources.tartarugaverde;
        }

        private void btnTartaruga_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["tartaruga"])
                return;

            btnTartaruga.BackgroundImage = Resources.tartarugaapagada;
        }
        #endregion

        #endregion

        //Apaga as imagens quando troca o animal
        private void ApagaImagens()
        {
            pnlFundoAcao.BackgroundImage = null;
            pctCeu.BackgroundImage = null;
            pctArvore.BackgroundImage = null;
            pctChao.BackgroundImage = null;
            pctAgua.BackgroundImage = null;
        }

        //Volta ao tamanho padrão sem ser Leão e Elefante
        private void VoltaTamanho()
        {
            pctChao.Width = 200;
            pctChao.Height = 200;
            pctChao.Location = new Point(276, 286);
        }


        //Verificador pra fechar o form
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                DialogResult result = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    this.Close();
            }
        }

        //Mensagem de como fechar o jogo
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Para sair pressione ESC", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Evento pra fechar o jogo
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void DesativaBotoes()
        {
            btnAmamentar.Enabled = false;
            btnAmamentar.Enabled = false;
            btnAmamentar.Enabled = false;
            btnAmamentar.Enabled = false;
            btnAmamentar.Enabled = false;
            btnCiscar.Enabled = false;
            btnBotar.Enabled = false;
            btnChocar.Enabled = false;
            btnVoar.Enabled = false;
        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            if (RetornaAnimal() == "")
            {
                MessageBox.Show("Selecione um animal");
                return;
            }
            else
            {
                Alimentacao(RetornaAnimal());
            }


        }

        private string RetornaAnimal()
        {
            foreach (var item in selecionados)
            {
                if (item.Value)
                {
                    return item.Key;
                }
            }
            return "";
        }

        private void Alimentacao(string tag)
        {
            switch (tag)
            {
                case "baleia":
                    pctAgua.BackgroundImage = Resources.baleiacomendo;
                    break;

                case "cachorro":
                    pctAgua.BackgroundImage = Resources.baleiacomendo;
                    break;

                case "coruja":
                    pctAgua.BackgroundImage = Resources.baleiacomendo;
                    break;

                case "elefante":
                    pctAgua.BackgroundImage = Resources.baleiacomendo;
                    break;

                case "galinha":
                    pctAgua.BackgroundImage = Resources.baleiacomendo;
                    break;

                case "gato":
                    pctAgua.BackgroundImage = Resources.baleiacomendo;
                    break;

                case "gaviao":
                    pctAgua.BackgroundImage = Resources.baleiacomendo;
                    break;

                case "leao":
                    pctAgua.BackgroundImage = Resources.baleiacomendo;
                    break;

                case "morcego":
                    pctAgua.BackgroundImage = Resources.baleiacomendo;
                    break;

                case "ornitorrinco":
                    pctAgua.BackgroundImage = Resources.baleiacomendo;
                    break;

                case "pato":
                    pctAgua.BackgroundImage = Resources.baleiacomendo;
                    break;

                case "pinguim":
                    pctAgua.BackgroundImage = Resources.baleiacomendo;
                    break;

                case "pombo":
                    pctAgua.BackgroundImage = Resources.baleiacomendo;
                    break;

                case "tartaruga":
                    pctAgua.BackgroundImage = Resources.baleiacomendo;
                    break;
            }
        }

        //Método que faz a movimentação
        private void Movimentacao(string tag)
        {
            switch (tag)
            {
                case "baleia":
                    pctChao.Left = 129;
                    if (pctAgua.Left > 350)
                    {
                        pctAgua.Left -= 2;
                    }
                    else
                    {
                        pctAgua.Location = new Point(514, 178);
                        pctAgua.Left -= 2;
                    }
                    break;

                case "cachorro":
                    if (pctChao.Left > 130)
                    {
                        pctChao.Left -= 2;
                    }
                    else
                    {
                        pctChao.Location = new Point(276, 286);
                        pctChao.Left -= 2;
                    }
                    break;


                case "coruja":
                    if (pctArvore.Left < 160)
                    {
                        pctArvore.Left += 2;
                    }
                    else
                    {
                        pctArvore.Location = new Point(39, 221);
                        pctArvore.Left += 2;
                    }
                    break;

                case "elefante":
                    if (pctChao.Left > 130)
                    {
                        pctChao.Left -= 2;
                    }
                    else
                    {
                        pctChao.Location = new Point(276, 286);
                        pctChao.Left -= 2;
                    }
                    break;

                case "galinha":
                    if (pctChao.Left > 130)
                    {
                        pctChao.Left -= 2;
                    }
                    else
                    {
                        pctChao.Location = new Point(276, 286);
                        pctChao.Left -= 2;
                    }
                    break;

                case "gato":
                    if (pctChao.Left > 130)
                    {
                        pctChao.Left -= 2;
                    }
                    else
                    {
                        pctChao.Location = new Point(276, 286);
                        pctChao.Left -= 2;
                    }
                    break;

                case "gaviao":
                    if (pctChao.Left > 130)
                    {
                        pctChao.Left -= 2;
                    }
                    else
                    {
                        pctChao.Location = new Point(276, 286);
                        pctChao.Left -= 2;
                    }
                    break;

                case "leao":
                    if (pctChao.Left > 130)
                    {
                        pctChao.Left -= 2;
                    }
                    else
                    {
                        pctChao.Location = new Point(276, 286);
                        pctChao.Left -= 2;
                    }
                    break;

                case "morcego":
                    if (pctArvore.Left < 160)
                    {
                        pctArvore.Left += 2;
                    }
                    else
                    {
                        pctArvore.Location = new Point(39, 221);
                        pctArvore.Left += 2;
                    }
                    break;

                case "ornitorrinco":
                    if (pctChao.Left > 130)
                    {
                        pctChao.Left -= 2;
                    }
                    else
                    {
                        pctChao.Location = new Point(276, 286);
                        pctChao.Left -= 2;
                    }
                    break;

                case "pato":
                    if (pctChao.Left > 130)
                    {
                        pctChao.Left -= 2;
                    }
                    else
                    {
                        pctChao.Location = new Point(276, 286);
                        pctChao.Left -= 2;
                    }
                    break;

                case "pinguim":
                    if (pctChao.Left > 130)
                    {
                        pctChao.Left -= 2;
                    }
                    else
                    {
                        pctChao.Location = new Point(276, 286);
                        pctChao.Left -= 2;
                    }
                    break;

                case "pombo":
                    if (pctChao.Left > 130)
                    {
                        pctChao.Left -= 2;
                    }
                    else
                    {
                        pctChao.Location = new Point(276, 286);
                        pctChao.Left -= 2;
                    }
                    break;

                case "tartaruga":
                    if (pctChao.Left > 130)
                    {
                        pctChao.Left -= 2;
                    }
                    else
                    {
                        pctChao.Location = new Point(276, 286);
                        pctChao.Left -= 2;
                    }
                    break;
            }
        }

        private void Voar(string tag)
        {
            pctChao.BackgroundImage = null;
            switch (tag)
            {
                case "coruja":
                    ApagaImagens();
                    pctCeu.BackgroundImage = Resources.corujaapagada;
                    pnlFundoAcao.BackgroundImage = Resources.noite;
                    break;

                case "gaviao":
                    ApagaImagens();
                    pctCeu.BackgroundImage = Resources.gaviaoapagado;
                    pnlFundoAcao.BackgroundImage = Resources.ceu;
                    break;

                case "morcego":
                    ApagaImagens();
                    pctCeu.BackgroundImage = Resources.morcegoapagado;
                    pnlFundoAcao.BackgroundImage = Resources.noite;
                    break;

                case "pato":
                    ApagaImagens();
                    pctCeu.BackgroundImage = Resources.patoapagado;
                    pnlFundoAcao.BackgroundImage = Resources.ceu;
                    break;

                case "pombo":
                    ApagaImagens();
                    pctCeu.BackgroundImage = Resources.pomboapagado;
                    pnlFundoAcao.BackgroundImage = Resources.ceu;
                    break;
            }

        }

        private void btnMovimentar_Click(object sender, EventArgs e)
        {
            if (RetornaAnimal() == "")
            {
                MessageBox.Show("Selecione um animal");
                return;
            }
            else
            {

                Movimentacao(RetornaAnimal());
            }
        }

        private void btnVoar_Click(object sender, EventArgs e)
        {
            Voar(RetornaAnimal());
            btnMovimentar.Enabled = false;
        }
        
        private void cmbAnimais_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArvoreBinaria.Pesquisa()
        }
    }
}
