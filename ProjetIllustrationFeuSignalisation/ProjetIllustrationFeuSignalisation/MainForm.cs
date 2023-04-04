using FeuxSignalisations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProjetIllustrationFeuSignalisation
{
    public partial class MainForm : Form
    {
        int nbFeux;
        List<FeuSignalisation> feux;
        public MainForm()
        {
            InitializeComponent();
            nbFeux = 1;
            feux = new();
            
        }

        private void ajouterFeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfoFeu fif = new FormInfoFeu();
            fif.MdiParent = this;
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
            nbFeux++;
        }
        private void GenererPasserRouge(FeuSignalisation f)
        {
            ToolStripItem added = rougeToolStripMenuItem.DropDownItems.Add(String.Format("feu{0} {1}", (nbFeux > 1 ? "x":""), nbFeux));
            f.Event_OnStateChanged += ((p, e) => {
                bool expression = e != EnumEtatFeuSignalisation.Rouge;
                if (InvokeRequired)
                    Invoke(() => UpdateMenu(added, expression));
                else
                    UpdateMenu(added, expression);
            });

        }

        private void UpdateMenu(ToolStripItem t, bool b)
        {
            t.Enabled = b;
        }

        private void GenererPasserVert(FeuSignalisation f)
        {
            ToolStripItem added = orangeToolStripMenuItem.DropDownItems.Add(String.Format("feu{0} {1}", (nbFeux > 1 ? "x" : ""), nbFeux));
            f.Event_OnStateChanged += ((p, e) => {
                bool expression = e != EnumEtatFeuSignalisation.Vert;
                if (InvokeRequired)
                    Invoke(() => UpdateMenu(added, expression));
                else
                    UpdateMenu(added, expression);
            });
        }

        private void GenererPasserOrange(FeuSignalisation f)
        {
            ToolStripItem added = vertToolStripMenuItem.DropDownItems.Add(String.Format("feu{0} {1}", (nbFeux > 1 ? "x" : ""), nbFeux));
            f.Event_OnStateChanged += ((p, e) => {
                bool expression = e != EnumEtatFeuSignalisation.Orange;
                if (InvokeRequired)
                    Invoke(() => UpdateMenu(added, expression));
                else
                     UpdateMenu(added, expression);
            });
        }
    }
}
