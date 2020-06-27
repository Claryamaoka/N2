using N2___Animais.ANIMAIS;
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
        
        //Desativar botoes
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
            btnAtaque.Enabled = false;
        }

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

            pctAnimal.Location = new Point(300, 236);
            pctAnimal.Size = new Size(200, 200);

            ApagaImagens();
            pnlFundoAcao.BackgroundImage = Resources.praia;
            pctAnimal.BackgroundImage = Resources.baleiaapagada;

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

            txtCarac.Text = "";
        }

        private void btnCachorro_Click(object sender, EventArgs e)
        {
            EventoClique(btnCachorro.Tag.ToString(), btnCachorro);
            btnCachorro.BackgroundImage = Resources.cachorrolaranja;
            btnCachorro.BackColor = Color.Orange;

            pctAnimal.Location = new Point(278, 292);
            pctAnimal.Size = new Size(200, 200);
            ApagaImagens();
            pnlFundoAcao.BackgroundImage = Resources.gramado;
            pctAnimal.BackgroundImage = Resources.cachorroapagado;


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
            txtCarac.Text = "";
        }

        private void btnCoruja_Click(object sender, EventArgs e)
        {
            EventoClique(btnCoruja.Tag.ToString(), btnCoruja);
            btnCoruja.BackgroundImage = Resources.corujalaranja;
            btnCoruja.BackColor = Color.Orange;

            pctAnimal.Location = new Point(33, 238);
            pctAnimal.Size = new Size(150, 150);
            ApagaImagens();
            pnlFundoAcao.BackgroundImage = Resources.noite;
            pctAnimal.BackgroundImage = Resources.corujaapagada;

            DesativaBotoes();
            btnBotar.Enabled = true;
            btnChocar.Enabled = true;
            btnVoar.Enabled = true;
            btnMovimentar.Enabled = true;
            btnAtaque.Enabled = true;

            string[] nomes = ArvoreBinaria.ListagemInterfixada().VetorPorAnimal("coruja");
            cmbAnimais.Items.Clear();
            foreach (string linha in nomes)
            {
                if (linha != null)
                    cmbAnimais.Items.Add(linha);
            }
            txtCarac.Text = "";
        }

        private void btnElefante_Click(object sender, EventArgs e)
        {
            EventoClique(btnElefante.Tag.ToString(), btnElefante);
            btnElefante.BackgroundImage = Resources.elefantelaranja;
            btnElefante.BackColor = Color.Orange;

            pctAnimal.Size = new Size(250, 250);
            pctAnimal.Location = new Point(278, 280);

            ApagaImagens();
            pnlFundoAcao.BackgroundImage = Resources.lago;
            pctAnimal.BackgroundImage = Resources.elefanteapagado;

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
            txtCarac.Text = "";
        }

        private void btnGalinha_Click(object sender, EventArgs e)
        {
            EventoClique(btnGalinha.Tag.ToString(), btnGalinha);
            btnGalinha.BackgroundImage = Resources.galinhalaranja;
            btnGalinha.BackColor = Color.Orange;

            pctAnimal.Location = new Point(278, 292);
            pctAnimal.Size = new Size(150, 150);
            ApagaImagens();
            pnlFundoAcao.BackgroundImage = Resources.lago;
            pctAnimal.BackgroundImage = Resources.galinhaapagada;

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
            txtCarac.Text = "";
        }

        private void btnGato_Click(object sender, EventArgs e)
        {
            EventoClique(btnGato.Tag.ToString(), btnGato);
            btnGato.BackgroundImage = Resources.gatolaranja;
            btnGato.BackColor = Color.Orange;

            pctAnimal.Location = new Point(278, 292);
            pctAnimal.Size = new Size(200, 200);

            ApagaImagens();
            pnlFundoAcao.BackgroundImage = Resources.gramado;
            pctAnimal.BackgroundImage = Resources.gatoapagado;

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
            txtCarac.Text = "";
        }

        private void btnGaviao_Click(object sender, EventArgs e)
        {
            EventoClique(btnGaviao.Tag.ToString(), btnGaviao);
            btnGaviao.BackgroundImage = Resources.gaviaolarajna;
            btnGaviao.BackColor = Color.Orange;

            pctAnimal.Location = new Point(278, 292);
            pctAnimal.Size = new Size(200, 200);

            ApagaImagens();
            pnlFundoAcao.BackgroundImage = Resources.gramado;
            pctAnimal.BackgroundImage = Resources.gaviaoapagado;

            DesativaBotoes();
            btnCiscar.Enabled = true;
            btnChocar.Enabled = true;
            btnBotar.Enabled = true;
            btnVoar.Enabled = true;
            btnMovimentar.Enabled = true;
            btnAtaque.Enabled = true;

            string[] nomes = ArvoreBinaria.ListagemInterfixada().VetorPorAnimal("gaviao");
            cmbAnimais.Items.Clear();
            foreach (string linha in nomes)
            {
                if (linha != null)
                    cmbAnimais.Items.Add(linha);
            }
            txtCarac.Text = "";
        }

        private void btnLeao_Click(object sender, EventArgs e)
        {
            EventoClique(btnLeao.Tag.ToString(), btnLeao);
            btnLeao.BackgroundImage = Resources.leaolaranja;
            btnLeao.BackColor = Color.Orange;

            pctAnimal.Size = new Size(250, 250);
            pctAnimal.Location = new Point(278, 280);

            ApagaImagens();
            pnlFundoAcao.BackgroundImage = Resources.lago;
            pctAnimal.BackgroundImage = Resources.leaoapagado;

            DesativaBotoes();
            btnAmamentar.Enabled = true;
            btnMovimentar.Enabled = true;
            btnAtaque.Enabled = true;

            string[] nomes = ArvoreBinaria.ListagemInterfixada().VetorPorAnimal("leao");
            cmbAnimais.Items.Clear();
            foreach (string linha in nomes)
            {
                if (linha != null)
                    cmbAnimais.Items.Add(linha);
            }
            txtCarac.Text = "";
        }

        private void btnMorcego_Click(object sender, EventArgs e)
        {
            EventoClique(btnMorcego.Tag.ToString(), btnMorcego);
            btnMorcego.BackgroundImage = Resources.morcegolaranja;
            btnMorcego.BackColor = Color.Orange;

            pctAnimal.Location = new Point(33, 238);
            pctAnimal.Size = new Size(150, 150);

            ApagaImagens();
            pnlFundoAcao.BackgroundImage = Resources.noite;
            pctAnimal.BackgroundImage = Resources.morcegoapagado;

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
            txtCarac.Text = "";
        }

        private void btnOrnitorrinco_Click(object sender, EventArgs e)
        {
            EventoClique(btnOrnitorrinco.Tag.ToString(), btnOrnitorrinco);
            btnOrnitorrinco.BackgroundImage = Resources.ornitorrincolaranja;
            btnOrnitorrinco.BackColor = Color.Orange;

            pctAnimal.Location = new Point(278, 292);
            pctAnimal.Size = new Size(200, 200);

            ApagaImagens();
            pnlFundoAcao.BackgroundImage = Resources.lago;
            pctAnimal.BackgroundImage = Resources.ornitorrincoapagado;

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
            txtCarac.Text = "";
        }

        private void btnPato_Click(object sender, EventArgs e)
        {
            EventoClique(btnPato.Tag.ToString(), btnPato);
            btnPato.BackgroundImage = Resources.patolaranja;
            btnPato.BackColor = Color.Orange;

            pctAnimal.Location = new Point(278, 292);
            pctAnimal.Size = new Size(200, 200);

            ApagaImagens();
            pnlFundoAcao.BackgroundImage = Resources.lago;
            pctAnimal.BackgroundImage = Resources.patoapagado;

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
            txtCarac.Text = "";
        }

        private void btnPinguim_Click(object sender, EventArgs e)
        {
            EventoClique(btnPinguim.Tag.ToString(), btnPinguim);
            btnPinguim.BackgroundImage = Resources.pinguimlaranja;
            btnPinguim.BackColor = Color.Orange;

            pctAnimal.Size = new Size(200, 200);
            pctAnimal.Location = new Point(278, 280);

            ApagaImagens();
            pnlFundoAcao.BackgroundImage = Resources.gelo;
            pctAnimal.BackgroundImage = Resources.pinguimapagado;

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
            txtCarac.Text = "";
        }

        private void btnPombo_Click(object sender, EventArgs e)
        {
            EventoClique(btnPombo.Tag.ToString(), btnPombo);
            btnPombo.BackgroundImage = Resources.pombolaranja;
            btnPombo.BackColor = Color.Orange;

            pctAnimal.Location = new Point(278, 292);
            pctAnimal.Size = new Size(150, 150);

            ApagaImagens();
            pnlFundoAcao.BackgroundImage = Resources.gramado;
            pctAnimal.BackgroundImage = Resources.pomboapagado;

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
            txtCarac.Text = "";
        }

        private void btnTartaruga_Click(object sender, EventArgs e)
        {
            EventoClique(btnTartaruga.Tag.ToString(), btnTartaruga);
            btnTartaruga.BackgroundImage = Resources.tartarugalarajna;
            btnTartaruga.BackColor = Color.Orange;

            pctAnimal.Location = new Point(300, 236);
            pctAnimal.Size = new Size(200, 200);

            ApagaImagens();
            pnlFundoAcao.BackgroundImage = Resources.praia;
            pctAnimal.BackgroundImage = Resources.tartarugaapagada;

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
            txtCarac.Text = "";
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
            //pnlFundoAcao.BackgroundImage = null;
            pctAnimal.BackgroundImage = null;
        }

        //Volta ao tamanho padrão sem ser Leão e Elefante
        private void VoltaTamanho()
        {
            pctAnimal.Width = 200;
            pctAnimal.Height = 200;
            pctAnimal.Location = new Point(276, 286);
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
            tmrApagalbl.Start();
        }

        //Evento pra fechar o jogo
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Botões de ação
        #region BOTÕES DE AÇÃO
        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            Lista lista = ArvoreBinaria.ListagemInterfixada();
            Animal[] animais = lista.RetornaAnimais();

            if (cmbAnimais.SelectedIndex == -1)
            {
                MessageBox.Show("Cadastre um animal", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var animal in animais)
            {
                if (animal is Baleia)
                    (animal as Animal).Alimentar("baleia", ref pctAnimal);

                if (animal is Cachorro)
                    (animal as Animal).Alimentar("cachorro", ref pctAnimal);

                if (animal is Coruja)
                    (animal as Animal).Alimentar("coruja", ref pctAnimal);

                if (animal is Elefante)
                    (animal as Animal).Alimentar("elefante", ref pctAnimal);

                if (animal is Galinha)
                    (animal as Animal).Alimentar("galinha", ref pctAnimal);

                if (animal is Gato)
                    (animal as Animal).Alimentar("gato", ref pctAnimal);

                if (animal is Gaviao)
                    (animal as Animal).Alimentar("gaviao", ref pctAnimal);

                if (animal is Leao)
                    (animal as Animal).Alimentar("leao", ref pctAnimal);

                if (animal is Morcego)
                    (animal as Animal).Alimentar("morcego", ref pctAnimal);

                if (animal is Ornitorrinco)
                    (animal as Animal).Alimentar("ornitorrinco", ref pctAnimal);

                if (animal is Pato)
                    (animal as Animal).Alimentar("pato", ref pctAnimal);

                if (animal is Pinguim)
                    (animal as Animal).Alimentar("pinguim", ref pctAnimal);

                if (animal is Pombo)
                    (animal as Animal).Alimentar("pombo", ref pctAnimal);

                if (animal is Tartaruga)
                    (animal as Animal).Alimentar("tartaruga", ref pctAnimal);
            }


        }

        private void btnMovimentar_Click(object sender, EventArgs e)
        {
            Lista lista = ArvoreBinaria.ListagemInterfixada();
            Animal[] animais = lista.RetornaAnimais();

            if (cmbAnimais.SelectedIndex == -1)
            {
                MessageBox.Show("Cadastre um animal", "ERRO", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            foreach (var animal in animais)
            {
                if (animal is Baleia)
                    (animal as Animal).Movimentar("baleia", ref pctAnimal);

                if (animal is Cachorro)
                    (animal as Animal).Movimentar("cachorro", ref pctAnimal);

                if (animal is Coruja)
                    (animal as Animal).Movimentar("coruja", ref pctAnimal);

                if (animal is Elefante)
                    (animal as Animal).Movimentar("elefante", ref pctAnimal);

                if (animal is Galinha)
                    (animal as Animal).Movimentar("galinha", ref pctAnimal);

                if (animal is Gato)
                    (animal as Animal).Movimentar("gato", ref pctAnimal);

                if (animal is Gaviao)
                    (animal as Animal).Movimentar("gaviao", ref pctAnimal);

                if (animal is Leao)
                    (animal as Animal).Movimentar("leao", ref pctAnimal);

                if (animal is Morcego)
                    (animal as Animal).Movimentar("morcego", ref pctAnimal);

                if (animal is Ornitorrinco)
                    (animal as Animal).Movimentar("ornitorrinco", ref pctAnimal);

                if (animal is Pato)
                    (animal as Animal).Movimentar("pato", ref pctAnimal);

                if (animal is Pinguim)
                    (animal as Animal).Movimentar("pinguim", ref pctAnimal);

                if (animal is Pombo)
                    (animal as Animal).Movimentar("pombo", ref pctAnimal);

                if (animal is Tartaruga)
                    (animal as Animal).Movimentar("tartaruga", ref pctAnimal);
            }
        }

        private void btnVoar_Click(object sender, EventArgs e)
        {
            Voar(RetornaAnimal());
            btnMovimentar.Enabled = false;
        }

        private void btnAmamentar_Click(object sender, EventArgs e)
        {
            Lista lista = ArvoreBinaria.ListagemInterfixada();
            Animal[] animais = lista.RetornaAnimais();

            if (cmbAnimais.SelectedIndex == -1)
            {
                MessageBox.Show("Cadastre um animal", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var animal in animais)
            {
                if (animal is Baleia)
                    (animal as Mamifero).Amamentar("baleia", ref pctAnimal, ref btnMovimentar);

                if (animal is Cachorro)
                    (animal as Mamifero).Amamentar("cachorro", ref pctAnimal, ref btnMovimentar);

                if (animal is Elefante)
                    (animal as Mamifero).Amamentar("elefante", ref pctAnimal, ref btnMovimentar);

                if (animal is Gato)
                    (animal as Mamifero).Amamentar("gato", ref pctAnimal, ref btnMovimentar);

                if (animal is Leao)
                    (animal as Mamifero).Amamentar("leao", ref pctAnimal, ref btnMovimentar);

                if (animal is Morcego)
                    (animal as Mamifero).Amamentar("morcego", ref pctAnimal, ref btnMovimentar);
            }
        }

        private void btnComunicar_Click(object sender, EventArgs e)
        {
            Lista lista = ArvoreBinaria.ListagemInterfixada();
            Animal[] animais = lista.RetornaAnimais();

            if (cmbAnimais.SelectedIndex == -1)
            {
                MessageBox.Show("Cadastre um animal", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var animal in animais)
            {
                if (animal is Baleia)
                    (animal as Animal).Comunicar("baleia", ref lblComunica);

                if (animal is Cachorro)
                    (animal as Animal).Comunicar("cachorro", ref lblComunica);

                if (animal is Coruja)
                    (animal as Animal).Comunicar("coruja", ref lblComunica);

                if (animal is Elefante)
                    (animal as Animal).Comunicar("elefante", ref lblComunica);

                if (animal is Galinha)
                    (animal as Animal).Comunicar("galinha", ref lblComunica);

                if (animal is Gato)
                    (animal as Animal).Comunicar("gato", ref lblComunica);

                if (animal is Gaviao)
                    (animal as Animal).Comunicar("gaviao", ref lblComunica);

                if (animal is Leao)
                    (animal as Animal).Comunicar("leao", ref lblComunica);

                if (animal is Morcego)
                    (animal as Animal).Comunicar("morcego", ref lblComunica);

                if (animal is Ornitorrinco)
                    (animal as Animal).Comunicar("ornitorrinco", ref lblComunica);

                if (animal is Pato)
                    (animal as Animal).Comunicar("pato", ref lblComunica);

                if (animal is Pinguim)
                    (animal as Animal).Comunicar("pinguim", ref lblComunica);

                if (animal is Pombo)
                    (animal as Animal).Comunicar("pombo", ref lblComunica);

                if (animal is Tartaruga)
                    (animal as Animal).Comunicar("tartaruga", ref lblComunica);
            }

        }

        private void btnCiscar_Click(object sender, EventArgs e)
        {

        }

        private void btnChocar_Click(object sender, EventArgs e)
        {
            Chocar(RetornaAnimal());
            btnMovimentar.Enabled = false;
        }

        private void btnBotar_Click(object sender, EventArgs e)
        {
            Botar(RetornaAnimal());
            btnMovimentar.Enabled = false;
        }
        #endregion

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
        
        private void Voar(string tag)
        {
            pctAnimal.BackgroundImage = null;
            switch (tag)
            {
                case "coruja":
                    ApagaImagens();
                    pctAnimal.BackgroundImage = Resources.corujaapagada;
                    pnlFundoAcao.BackgroundImage = Resources.noite;
                    break;

                case "gaviao":
                    ApagaImagens();
                    pctAnimal.BackgroundImage = Resources.gaviaoapagado;
                    pnlFundoAcao.BackgroundImage = Resources.ceu;
                    break;

                case "morcego":
                    ApagaImagens();
                    pctAnimal.BackgroundImage = Resources.morcegoapagado;
                    pnlFundoAcao.BackgroundImage = Resources.noite;
                    break;

                case "pato":
                    ApagaImagens();
                    pctAnimal.BackgroundImage = Resources.patoapagado;
                    pnlFundoAcao.BackgroundImage = Resources.ceu;
                    break;

                case "pombo":
                    ApagaImagens();
                    pctAnimal.BackgroundImage = Resources.pomboapagado;
                    pnlFundoAcao.BackgroundImage = Resources.ceu;
                    break;
            }

        }
        
        private void cmbAnimais_SelectedIndexChanged(object sender, EventArgs e)
        {
            Animal animal = ArvoreBinaria.ListagemInterfixada().PesquisaAnimal(cmbAnimais.SelectedItem.ToString());
            string texto = $"Nome: {animal.Nome}\t Data de nascimento: {animal.DataNascimento.ToShortDateString()}\t Idade: {animal.Idade}\t Sexo: {animal.Sexo}";

            if (animal is Mamifero)
            {
                if (!(animal as Mamifero).Pelos)
                    texto += Environment.NewLine + $"Qtde Mamas: {(animal as Mamifero).QtdeMamas}\t Não tem pelos";

                else
                    texto += Environment.NewLine + $"Qtde Mamas: {(animal as Mamifero).QtdeMamas}\t Cor dos Pelos: {(animal as Mamifero).CorPelo}";
            }

            if (animal is Ave)
                texto += Environment.NewLine + $"Cor da Pena: {(animal as Ave).CorPena}";

            if (animal is Reptil)
                texto += Environment.NewLine + $"Tem casco\t Tem escama";

            if (animal is IOviparo)
                texto += "\t É oviparo";

            if (animal is IVoar)
                texto += "\t Voa";

            if (animal is IPredador)
                texto += "\t É predador";

            txtCarac.Text = texto;




        }
        
        private void Chocar(string tag)
        {
            switch (tag)
            {
                case "coruja":
                    ApagaImagens();
                    pctAnimal.BackgroundImage = Resources.corujachocando;
                    pnlFundoAcao.BackgroundImage = Resources.noite;
                    break;

                case "galinha":
                    ApagaImagens();
                    //pctAnimal.BackgroundImage = Resources.galinha;
                    pnlFundoAcao.BackgroundImage = Resources.lago;
                    break;
                case "gaviao":
                    ApagaImagens();
                    pctAnimal.BackgroundImage = Resources.gaviaochocando;
                    pnlFundoAcao.BackgroundImage = Resources.gramado;
                    break;

                case "pato":
                    ApagaImagens();
                    pctAnimal.BackgroundImage = Resources.patochocando;
                    pnlFundoAcao.BackgroundImage = Resources.lago;
                    break;

                case "pinguim":
                    ApagaImagens();
                    pctAnimal.BackgroundImage = Resources.pinguimchocando;
                    pnlFundoAcao.BackgroundImage = Resources.gelo;
                    break;

                case "pombo":
                    ApagaImagens();
                    pctAnimal.BackgroundImage = Resources.pombochocando;
                    pnlFundoAcao.BackgroundImage = Resources.gramado;
                    break;
            }
        }
        
        private void Botar(string tag)
        {
            switch (tag)
            {
                case "coruja":
                    ApagaImagens();
                    pctAnimal.BackgroundImage = Resources.corujaovo;
                    pnlFundoAcao.BackgroundImage = Resources.noite;
                    break;

                case "galinha":
                    ApagaImagens();
                    //pctAnimal.BackgroundImage = Resources.galinha;
                    pnlFundoAcao.BackgroundImage = Resources.lago;
                    break;
                case "gaviao":
                    ApagaImagens();
                    pctAnimal.BackgroundImage = Resources.gaviaoovo;
                    pnlFundoAcao.BackgroundImage = Resources.gramado;
                    break;

                case "pato":
                    ApagaImagens();
                    pctAnimal.BackgroundImage = Resources.patoovo;
                    pnlFundoAcao.BackgroundImage = Resources.lago;
                    break;

                case "pinguim":
                    ApagaImagens();
                    pctAnimal.BackgroundImage = Resources.pinguim_ovo;
                    pnlFundoAcao.BackgroundImage = Resources.gelo;
                    break;

                case "pombo":
                    ApagaImagens();
                    pctAnimal.BackgroundImage = Resources.pomboovo;
                    pnlFundoAcao.BackgroundImage = Resources.gramado;
                    break;
            }
        }

        private void AnimalEscolhido(string tag)
        {
            switch (tag)
            {
                case "baleia":
                    ApagaImagens();
                    //pnlFundoAcao.BackgroundImage = Resources.praia;
                    pctAnimal.BackgroundImage = Resources.baleiaapagada;
                    break;

                case "cachorro":
                    ApagaImagens();
                    //pnlFundoAcao.BackgroundImage = Resources.gramado;
                    pctAnimal.BackgroundImage = Resources.cachorroapagado;
                    break;

                case "coruja":
                    ApagaImagens();
                    // pnlFundoAcao.BackgroundImage = Resources.noite;
                    pctAnimal.BackgroundImage = Resources.corujaapagada;
                    break;

                case "elefante":
                    ApagaImagens();
                    //pnlFundoAcao.BackgroundImage = Resources.lago;
                    pctAnimal.BackgroundImage = Resources.elefanteapagado;
                    break;

                case "galinha":
                    ApagaImagens();
                    //pnlFundoAcao.BackgroundImage = Resources.lago;
                    pctAnimal.BackgroundImage = Resources.galinhaapagada;
                    break;

                case "gato":
                    ApagaImagens();
                    //pnlFundoAcao.BackgroundImage = Resources.gramado;
                    pctAnimal.BackgroundImage = Resources.gatoapagado;
                    break;

                case "gaviao":
                    ApagaImagens();
                    //pnlFundoAcao.BackgroundImage = Resources.lago;
                    pctAnimal.BackgroundImage = Resources.gaviaoapagado;
                    break;

                case "leao":
                    ApagaImagens();
                    //pnlFundoAcao.BackgroundImage = Resources.lago;
                    pctAnimal.BackgroundImage = Resources.leaoapagado;
                    break;

                case "morcego":
                    ApagaImagens();
                    //pnlFundoAcao.BackgroundImage = Resources.noite;
                    pctAnimal.BackgroundImage = Resources.morcegoapagado;
                    break;

                case "ornitorrinco":
                    ApagaImagens();
                    //pnlFundoAcao.BackgroundImage = Resources.lago;
                    pctAnimal.BackgroundImage = Resources.ornitorrincoapagado;
                    break;

                case "pato":
                    ApagaImagens();
                    //pnlFundoAcao.BackgroundImage = Resources.lago;
                    pctAnimal.BackgroundImage = Resources.patoapagado;
                    break;

                case "pinguim":
                    ApagaImagens();
                    //pnlFundoAcao.BackgroundImage = Resources.gelo;
                    pctAnimal.BackgroundImage = Resources.pinguimapagado;
                    break;

                case "pombo":
                    ApagaImagens();
                    //pnlFundoAcao.BackgroundImage = Resources.lago;
                    pctAnimal.BackgroundImage = Resources.pomboapagado;
                    break;

                case "tartaruga":
                    ApagaImagens();
                    // pnlFundoAcao.BackgroundImage = Resources.praia;
                    pctAnimal.BackgroundImage = Resources.tartarugaapagada;
                    break;
            }
        }

        private void tmrApagalbl_Tick(object sender, EventArgs e)
        {
            lblComunica.Text = "";
        }
    }
}
