namespace FeuxSignalisations
{
    public class FeuSignalisation
    {

        private int tempsRougeMilliseconds;
        private int tempsOrangeMilliseconds;
        private int tempsVertMilliseconds;
        private bool estAllimente;
        private Thread sonThread;
        public EnumEtatFeuSignalisation sonEtat;  

        public delegate void OnStateChanged(FeuSignalisation sender, EnumEtatFeuSignalisation nouvelEtat);
        public event OnStateChanged Event_OnStateChanged;
        public EnumEtatFeuSignalisation SonEtat
        {
            get => sonEtat; private set => changerEtatFeuSignalisation(value);
        }


        public FeuSignalisation(int tempsRouge, int tempsOrange, int tempsVert, EnumEtatFeuSignalisation etatInitial)
        {
            tempsRougeMilliseconds = tempsRouge;
            tempsOrangeMilliseconds = tempsOrange;
            tempsVertMilliseconds = tempsVert;
            sonEtat = etatInitial;
            estAllimente = true;
            sonThread = new Thread(new ThreadStart(AlternerSignalisation));
            sonThread.Start();
        }

        public FeuSignalisation(): this(20000, 5000, 20000, EnumEtatFeuSignalisation.Rouge){ } 
        
        private void changerEtatFeuSignalisation(EnumEtatFeuSignalisation nouvelEtat)
        {
            if (nouvelEtat == sonEtat)
                return;
            sonEtat = nouvelEtat;
            if (Event_OnStateChanged != null)
                Event_OnStateChanged(this, nouvelEtat);
        }

        public void AlternerSignalisation()
        {
            
            while (estAllimente)
            {
                if (sonEtat == EnumEtatFeuSignalisation.Rouge)
                {
                    Thread.Sleep(tempsRougeMilliseconds);
                    SonEtat = EnumEtatFeuSignalisation.Orange;
                }
                else if (sonEtat == EnumEtatFeuSignalisation.Orange)
                {
                    Thread.Sleep(tempsOrangeMilliseconds);
                    SonEtat = EnumEtatFeuSignalisation.Vert;
                } else
                {
                    Thread.Sleep(tempsVertMilliseconds);
                    SonEtat = EnumEtatFeuSignalisation.Rouge;
                }

            }
        }

    }
}