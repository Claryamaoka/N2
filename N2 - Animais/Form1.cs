using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DicionarioBotoes();
        }

        SortedDictionary<string, bool> selecionados = new SortedDictionary<string, bool>();
        public string animalselecionado;

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
                            botao.BackgroundImage = Properties.Resources.baleiaapagada;
                            break;

                        case "cachorro":
                            if (animal == animalclicado)
                                break;
                            selecionados["cachorro"] = false;
                            botao.BackgroundImage = Properties.Resources.cachorroapagado;
                            break;

                        case "coruja":
                            if (animal == animalclicado)
                                break;
                            selecionados["coruja"] = false;
                            botao.BackgroundImage = Properties.Resources.corujaapagada;
                            break;

                        case "elefante":
                            if (animal == animalclicado)
                                break;
                            selecionados["elefante"] = false;
                            botao.BackgroundImage = Properties.Resources.elefanteapagado;
                            break;

                        case "galinha":
                            if (animal == animalclicado)
                                break;
                            selecionados["galinha"] = false;
                            botao.BackgroundImage = Properties.Resources.galinhaapagada;
                            break;

                        case "gato":
                            if (animal == animalclicado)
                                break;
                            selecionados["gato"] = false;
                            botao.BackgroundImage = Properties.Resources.gatoapagado;
                            break;

                        case "gaviao":
                            if (animal == animalclicado)
                                break;
                            selecionados["gavio"] = false;
                            botao.BackgroundImage = Properties.Resources.gaviaoapagado;
                            break;

                        case "leao":
                            if (animal == animalclicado)
                                break;
                            selecionados["leao"] = false;
                            botao.BackgroundImage = Properties.Resources.leaoapagado;
                            break;


                        case "morcego":
                            if (animal == animalclicado)
                                break;
                            selecionados["morcego"] = false;
                            botao.BackgroundImage = Properties.Resources.morcegoapagado;
                            break;

                        case "ornitorrinco":
                            if (animal == animalclicado)
                                break;
                            selecionados["ornitorrinco"] = false;
                            botao.BackgroundImage = Properties.Resources.ornitorrincoapagado;
                            break;

                        case "pato":
                            if (animal == animalclicado)
                                break;
                            selecionados["pato"] = false;
                            botao.BackgroundImage = Properties.Resources.patoapagado;
                            break;

                        case "pinguim":
                            if (animal == animalclicado)
                                break;
                            selecionados["pinguim"] = false;
                            botao.BackgroundImage = Properties.Resources.pinguimapagado;
                            break;

                        case "pombo":
                            if (animal == animalclicado)
                                break;
                            selecionados["pombo"] = false;
                            botao.BackgroundImage = Properties.Resources.pomboapagado;
                            break;

                        case "tartaruga":
                            if (animal == animalclicado)
                                break;
                            selecionados["tartaruga"] = false;
                            botao.BackgroundImage = Properties.Resources.tartarugaapagada;
                            break;
                    }
                }
            }
        }

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

        public void EventoClique(string tag, Control botao)
        {
            selecionados[tag] = true;
            VoltaImagem(botao.Tag.ToString());
        }


        #region"Eventos cliques dos botoes"
        private void btnBaleia_Click(object sender, EventArgs e)
        {
            EventoClique(btnBaleia.Tag.ToString(), btnBaleia);
            btnBaleia.BackgroundImage = Properties.Resources.baleialaranja;
            rdbBaleia.Checked = true;
          
        }

        private void btnCachorro_Click(object sender, EventArgs e)
        {
            EventoClique(btnCachorro.Tag.ToString(), btnCachorro);
            btnCachorro.BackgroundImage = Properties.Resources.cachorrolaranja;
            rdbCachorro.Checked = true;
        }

        private void btnCoruja_Click(object sender, EventArgs e)
        {
            EventoClique(btnCoruja.Tag.ToString(), btnCoruja);
            btnCoruja.BackgroundImage = Properties.Resources.corujalaranja;
            rdbCoruja.Checked = true;
        }

        private void btnElefante_Click(object sender, EventArgs e)
        {
            EventoClique(btnElefante.Tag.ToString(), btnElefante);
            btnElefante.BackgroundImage = Properties.Resources.elefantelaranja;
            rdbElefante.Checked = true;
        }

        private void btnGalinha_Click(object sender, EventArgs e)
        {
            EventoClique(btnGalinha.Tag.ToString(), btnGalinha);
            btnGalinha.BackgroundImage = Properties.Resources.galinhalaranja;
            rdbGalinha.Checked = true;
        }

        private void btnGato_Click(object sender, EventArgs e)
        {
            EventoClique(btnGato.Tag.ToString(), btnGato);
            btnGato.BackgroundImage = Properties.Resources.gatolaranja;
            rdbGato.Checked = true;
        }

        private void btnGaviao_Click(object sender, EventArgs e)
        {
            EventoClique(btnGaviao.Tag.ToString(), btnGaviao);
            btnGaviao.BackgroundImage = Properties.Resources.gaviaolarajna;
            rdbGaviao.Checked = true;
        }

        private void btnLeao_Click(object sender, EventArgs e)
        {
            EventoClique(btnLeao.Tag.ToString(), btnLeao);
            btnLeao.BackgroundImage = Properties.Resources.leaolaranja;
            rdbLeao.Checked = true;
        }

        private void btnMorcego_Click(object sender, EventArgs e)
        {
            EventoClique(btnMorcego.Tag.ToString(), btnMorcego);
            btnMorcego.BackgroundImage = Properties.Resources.morcegolaranja;
            rdbMorcego.Checked = true;
        }

        private void btnOrnitorrinco_Click(object sender, EventArgs e)
        {
            EventoClique(btnOrnitorrinco.Tag.ToString(), btnOrnitorrinco);
            btnOrnitorrinco.BackgroundImage = Properties.Resources.ornitorrincolaranja;
            rdbOrnitorrinco.Checked = true;
        }

        private void btnPato_Click(object sender, EventArgs e)
        {
            EventoClique(btnPato.Tag.ToString(), btnPato);
            btnPato.BackgroundImage = Properties.Resources.patolaranja;
            rdbPato.Checked = true;
        }

        private void btnPinguim_Click(object sender, EventArgs e)
        {
            EventoClique(btnPinguim.Tag.ToString(), btnPinguim);
            btnPinguim.BackgroundImage = Properties.Resources.pinguimlaranja;
            rdbPinguim.Checked = true;
        }

        private void btnPombo_Click(object sender, EventArgs e)
        {
            EventoClique(btnPombo.Tag.ToString(), btnPombo);
            btnPombo.BackgroundImage = Properties.Resources.pombolaranja;
            rdbPombo.Checked = true;
        }

        private void btnTartaruga_Click(object sender, EventArgs e)
        {
            EventoClique(btnTartaruga.Tag.ToString(), btnTartaruga);
            btnTartaruga.BackgroundImage = Properties.Resources.tartarugalarajna;
            rdbTartaruga.Checked = true;
        }
        #endregion Eventos


        #region"Evento  MouseEnter e MouseLeave"
        private void btnBaleia_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["baleia"])
                return;
            else if (!selecionados["baleia"])
                btnBaleia.BackgroundImage = Properties.Resources.baleiaverde;
        }

        private void btnBaleia_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["baleia"])
                return;

            btnBaleia.BackgroundImage = Properties.Resources.baleiaapagada;
        }

        private void btnCachorro_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["cachorro"])
                return;
            else if (!selecionados["cachorro"])
                btnCachorro.BackgroundImage = Properties.Resources.cachorroverde;
        }

        private void btnCachorro_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["cachorro"])
                return;

            btnCachorro.BackgroundImage = Properties.Resources.cachorroapagado;
        }

        private void btnCoruja_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["coruja"])
                return;
            else if (!selecionados["coruja"])
                btnCoruja.BackgroundImage = Properties.Resources.corujaverde;
        }

        private void btnCoruja_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["coruja"])
                return;

            btnCoruja.BackgroundImage = Properties.Resources.corujaapagada;
        }

        private void btnElefante_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["elefante"])
                return;
            else if (!selecionados["elefante"])
                btnElefante.BackgroundImage = Properties.Resources.elefanteverde;
        }

        private void btnElefante_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["elefante"])
                return;

            btnElefante.BackgroundImage = Properties.Resources.elefanteapagado;
        }

        private void btnGalinha_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["galinha"])
                return;
            else if (!selecionados["galinha"])
                btnGalinha.BackgroundImage = Properties.Resources.galinhaverde;
        }

        private void btnGalinha_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["galinha"])
                return;

            btnGalinha.BackgroundImage = Properties.Resources.galinhaapagada;
        }

        private void btnGato_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["gato"])
                return;
            else if (!selecionados["gato"])
                btnGato.BackgroundImage = Properties.Resources.gatoverde;
        }

        private void btnGato_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["gato"])
                return;

            btnGato.BackgroundImage = Properties.Resources.gatoapagado;
        }

        private void btnGaviao_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["gaviao"])
                return;
            else if (!selecionados["gaviao"])
                btnGaviao.BackgroundImage = Properties.Resources.gaviaoverde;
        }

        private void btnGaviao_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["gaviao"])
                return;

            btnGaviao.BackgroundImage = Properties.Resources.gaviaoapagado;
        }

        private void btnLeao_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["leao"])
                return;
            else if (!selecionados["leao"])
                btnLeao.BackgroundImage = Properties.Resources.leaoverde;
        }

        private void btnLeao_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["leao"])
                return;

            btnLeao.BackgroundImage = Properties.Resources.leaoapagado;
        }

        private void btnMorcego_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["morcego"])
                return;
            else if (!selecionados["morcego"])
                btnMorcego.BackgroundImage = Properties.Resources.mocegoverde;
        }

        private void btnMorcego_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["morcego"])
                return;

            btnMorcego.BackgroundImage = Properties.Resources.morcegoapagado;
        }

        private void btnOrnitorrinco_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["ornitorrinco"])
                return;
            else if (!selecionados["ornitorrinco"])
                btnOrnitorrinco.BackgroundImage = Properties.Resources.ornitorrincoverde;
        }

        private void btnOrnitorrinco_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["ornitorrinco"])
                return;

            btnOrnitorrinco.BackgroundImage = Properties.Resources.ornitorrincoapagado;
        }

        private void btnPato_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["pato"])
                return;
            else if (!selecionados["pato"])
                btnPato.BackgroundImage = Properties.Resources.patoverde;
        }

        private void btnPato_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["pato"])
                return;

            btnPato.BackgroundImage = Properties.Resources.patoapagado;
        }

        private void btnPinguim_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["pinguim"])
                return;
            else if (!selecionados["pinguim"])
                btnPinguim.BackgroundImage = Properties.Resources.pinguimverde;
        }

        private void btnPinguim_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["pinguim"])
                return;

            btnPinguim.BackgroundImage = Properties.Resources.pinguimapagado;
        }

        private void btnPombo_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["pombo"])
                return;
            else if (!selecionados["pombo"])
                btnPombo.BackgroundImage = Properties.Resources.pomboverde;
        }

        private void btnPombo_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["pombo"])
                return;

            btnPombo.BackgroundImage = Properties.Resources.pomboapagado;
        }

        private void btnTartaruga_MouseEnter(object sender, EventArgs e)
        {
            if (selecionados["tartaruga"])
                return;
            else if (!selecionados["tartaruga"])
                btnTartaruga.BackgroundImage = Properties.Resources.tartarugaverde;
        }

        private void btnTartaruga_MouseLeave(object sender, EventArgs e)
        {
            if (selecionados["tartaruga"])
                return;

            btnTartaruga.BackgroundImage = Properties.Resources.tartarugaapagada;
        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadastro Cadastro = new FrmCadastro();
            
            foreach (Control rdb in groupBox1.Controls)
            {
                if (rdb is RadioButton && (rdb as RadioButton).Checked)
                {
                    animalselecionado = rdb.Text;
                    break;
                }
            }
            // fazer a alteração utilizando a tag (nao esquecer)
            Cadastro.PegaAnimalSelecionado = animalselecionado;
            Cadastro.ShowDialog();

        }

    }
}
