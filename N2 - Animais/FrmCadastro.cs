using System;
using System.Windows.Forms;

namespace N2___Animais
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        char sexo;
        int qtdMamas;
        bool carnivoro = false, peconhento = false, pelos = false, rapina = false, escama = false, casco = false;

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            label8.Text = PegaAnimalSelecionado;
        }

        private void txtDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// <summary>
        /// Validação de Espécie do Animal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTipoAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoAnimal.SelectedIndex == 0)
            {
                btnCadastrar.Enabled = true;
                grpMamifero.Enabled = true;
                grpAve.Enabled = false;
                grpReptil.Enabled = false;
            }
            else if (cmbTipoAnimal.SelectedIndex == 1)
            {
                grpMamifero.Enabled = false;
                grpAve.Enabled = true;
                grpReptil.Enabled = false;
                btnCadastrar.Enabled = true;
            }
            else if (cmbTipoAnimal.SelectedIndex == 2)
            {
                btnCadastrar.Enabled = true;
                grpMamifero.Enabled = false;
                grpAve.Enabled = false;
                grpReptil.Enabled = true;
            }
        }
        
        
        
        /// <summary>
        /// Validações para cadastrar o animal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                Convert.ToDateTime(txtDataNascimento.Text);

                if (rdbMasc.Checked)
                    sexo = 'M';
                else if (rdbFem.Checked)
                    sexo = 'F';


                if (rdbCarnivoroSim.Checked)
                    carnivoro = true;

                if (rdbPeconhencoSim.Checked)
                    peconhento = true;

                int nmr = cmbTipoAnimal.SelectedIndex;
                switch (nmr)
                {
                    case 0: // Mamífero
                        qtdMamas = int.Parse(nmrQtdMamas.Value.ToString());
                        if (rdbPelosSim.Checked)
                            pelos = true;

                        /*INSTANCIAR O ANIMAL E ADD NA LISTA
                         * nome = txtNome.Text
                         * data nasc = txtDataNascimento
                         * sexo da classe = variavel sexo
                         * carnivoro = variavel carnivoro 
                         * peçonhento = variavel peçonhento
                         * espécie = cmbTipoAnimal.SelectedIntem.ToString()
                         * qtd mamas 
                         *pelos = variavel pelos
                         * cor do pelo = txtCorPelo
                        */
                        break;

                    case 1: // Ave
                        if (rdbRapinaSim.Checked)
                            rapina = true;

                        /*INSTANCIAR E ADD NA LISTA
                         * nome = txtNome.Text
                         * data nasc = txtDataNascimento
                         * sexo da classe = variavel sexo
                         * * carnivoro = variavel carnivoro 
                         * peçonhento = variavel peçonhento
                         * espécie = cmbTipoAnimal.SelectedIntem.ToString()
                         * rapina = variavel rapina
                         * cor da pena = txtCorPena
                         */
                        break;

                    case 2: // Réptil
                        if (rdbEscamaSim.Checked)
                            escama = true;
                        if (rdbCascoSim.Checked)
                            casco = true;
                        break;

                        /*INSTANCIAR E ADD NA LISTA
                          * nome = txtNome.Text
                          * data nasc = txtDataNascimento
                          * sexo da classe = variavel sexo
                          * * carnivoro = variavel carnivoro 
                          * peçonhento = variavel peçonhento
                          * espécie = cmbTipoAnimal.SelectedIntem.ToString()
                          * escama = variavel escama 
                          * casco = variavel casco
                          */
                }
            }
            catch
            {
                MessageBox.Show("Preencha os campos corretamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string PegaAnimalSelecionado { get; set; }
    }
}
