using FeuxSignalisations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerificationSaisie;

namespace ProjetIllustrationFeuSignalisation
{

    
    public partial class FormInfoFeu : Form
    {
        private FeuSignalisation? monFeu;

        public FeuSignalisation? MonFeu { get => monFeu; }
        public FormInfoFeu()
        {
            InitializeComponent();
            List<EnumEtatFeuSignalisation> typeremboursements = Enum.GetValues(typeof(EnumEtatFeuSignalisation)).Cast<EnumEtatFeuSignalisation>().ToList();
            foreach (EnumEtatFeuSignalisation t in typeremboursements)
            {
                comboBoxEtat.Items.Add(t);
            }
            comboBoxEtat.SelectedIndex = 0;
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (VerifierSaisie.MatchForInt(textBoxVert.Text) &&
                VerifierSaisie.MatchForInt(textBoxOrange.Text) &&
                VerifierSaisie.MatchForInt(textBoxRouge.Text))
            {
                monFeu = new FeuSignalisation(int.Parse(textBoxRouge.Text), int.Parse(textBoxRouge.Text), int.Parse(textBoxOrange.Text), (EnumEtatFeuSignalisation)comboBoxEtat.SelectedItem);
                this.Close();
            }
        }
    }
}
