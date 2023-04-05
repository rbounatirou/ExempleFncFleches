using BibliControles;
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

namespace ProjetIllustrationFeuSignalisation
{
    public partial class MainFormSansFncFlechees : Form
    {
        List<FeuSignalisation> feux;
        public MainFormSansFncFlechees()
        {
            InitializeComponent();
            feux = new();

        }

        private void ajouterFeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfoFeu fif = new FormInfoFeu();
            fif.Show();
            fif.FormClosing += OnCloseFormInfoFeu;
        }

        private void OnCloseFormInfoFeu(object sender, FormClosingEventArgs e)
        {
            FormInfoFeu f = sender as FormInfoFeu;
            if (f.MonFeu != null)
            {
                feux.Add(f.MonFeu);
                GenererPasser(f.MonFeu);
            }
        }


        private void GenererPasser(FeuSignalisation f)
        {
            GenererPasserRouge(f);
            GenererPasserOrange(f);
            GenererPasserVert(f);
            AjouterFeuIHM(f);
            f.Event_OnStateChanged += OnStateChanged;
        }

        private void AjouterFeuIHM(FeuSignalisation f)
        {
            UserControlFeuSignalisationEtat uc = new UserControlFeuSignalisationEtat(f, f.NumeroUnique);
            uc.Dock = DockStyle.Top;
            panelControle.Controls.Add(uc);
        }
        private void GenererPasserRouge(FeuSignalisation f)
        {
            ToolStripItem added = rougeToolStripMenuItem.DropDownItems.Add(String.Format("feu{0} {1}", (f.NumeroUnique > 1 ? "x" : ""), f.NumeroUnique));
            added.Tag = f;
        }

        private void UpdateMenu(ToolStripItem t, bool b)
        {
            t.Enabled = b;
        }

        private void GenererPasserVert(FeuSignalisation f)
        {
            ToolStripItem added = orangeToolStripMenuItem.DropDownItems.Add(String.Format("feu{0} {1}", (f.NumeroUnique > 1 ? "x" : ""), f.NumeroUnique));
            added.Tag = f;
        }

        private void GenererPasserOrange(FeuSignalisation f)
        {
            ToolStripItem added = vertToolStripMenuItem.DropDownItems.Add(String.Format("feu{0} {1}", (f.NumeroUnique > 1 ? "x" : ""), f.NumeroUnique));
            added.Tag = f;
        }

        private void OnStateChanged(FeuSignalisation sender, EnumEtatFeuSignalisation ne)
        {
            ToolStripItem? rouge = Find(rougeToolStripMenuItem, sender);
            ToolStripItem? orange = Find(orangeToolStripMenuItem, sender);
            ToolStripItem? vert = Find(vertToolStripMenuItem, sender);

            if (rouge != null)
                Invoke(() => rouge.Enabled = ne != EnumEtatFeuSignalisation.Rouge);
            if (orange != null)
                Invoke(() => orange.Enabled = ne != EnumEtatFeuSignalisation.Orange);
            if (vert != null)
                Invoke(() => vert.Enabled = ne != EnumEtatFeuSignalisation.Vert);
        }

        private ToolStripItem? Find(ToolStripMenuItem tsmi, FeuSignalisation f)
        {
            ToolStripItem? it = null;
            int i = 0;

            while (it == null && i< tsmi.DropDownItems.Count)
            {
                if (((FeuSignalisation)tsmi.DropDownItems[i].Tag).NumeroUnique == f.NumeroUnique)
                {
                    it = tsmi.DropDownItems[i];
                }
                i++;
            }
            return it;
        }
    }
}

