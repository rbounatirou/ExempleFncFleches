using FeuxSignalisations;

namespace BibliControles
{
    public partial class UserControlFeuSignalisationEtat : UserControl
    {

        private FeuSignalisation? feuAssocie;

        public FeuSignalisation? FeuAssocie { get => feuAssocie; private set => ChangerFeu(value); }
        public UserControlFeuSignalisationEtat()
        {
            InitializeComponent();

        }

        public UserControlFeuSignalisationEtat(FeuSignalisation? f, int v)
        {
            InitializeComponent();
            FeuAssocie = f;
            labelFeu.Text = "Feu " + v;
        }

        private void ChangerFeu(FeuSignalisation f)
        {
            if (f != null)
            {
                feuAssocie = f;
                feuAssocie.Event_OnStateChanged += OnStateChanged;
                MettreAJourIHM();
            }
        }

        private void OnStateChanged(FeuSignalisation f, EnumEtatFeuSignalisation e)
        {
            MettreAJourIHM();
        }

        private void MettreAJourIHM()
        {
            switch (feuAssocie.SonEtat)
            {
                case EnumEtatFeuSignalisation.Rouge:
                    panelCouleur.BackColor = Color.Red;
                    break;
                case EnumEtatFeuSignalisation.Orange:
                    panelCouleur.BackColor = Color.Orange;
                    break;
                case EnumEtatFeuSignalisation.Vert:
                    panelCouleur.BackColor = Color.Green;
                    break;
            }
        }
    }

   
}