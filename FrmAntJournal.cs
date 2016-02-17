using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntSimulation
{
    public partial class FrmAntJournal : Form
    {
        #region Private Member Variables
        List<string> cachedList;
        Ant ant;
        List<Ant> antFarm;
        #endregion

        #region Private Methods
        private void ChangeAnt(Ant ant)
        {
            this.ant = ant;
            Text = "Viewing the life of: " + ant.Name;
            txtAntHistory.Clear();
            cachedList.Clear();
            CheckHistory();
        }

        private void antSelector_ValueChanged(object sender, EventArgs e)
        {
            if (antSelector.Value > antFarm.Count - 1)
                antSelector.Value = 0;
            else if (antSelector.Value < 0)
                antSelector.Value = antFarm.Count - 1;

            ChangeAnt(antFarm[(int)antSelector.Value]);
        }
        #endregion

        #region Constructors
        public FrmAntJournal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Class constructor of the form
        /// </summary>
        /// <param name="antFarm">the list of ants to cycle through</param>
        public FrmAntJournal(List<Ant> antFarm)
        {
            InitializeComponent();

            antSelector.Maximum = antFarm.Count;
            cachedList = new List<string>();
            ant = antFarm[0];
            this.antFarm = antFarm;
            Text = "Viewing the life of: " + ant.Name;
            foreach (string lifeEvent in ant.LifeHistory)
            {
                txtAntHistory.Text += lifeEvent + Environment.NewLine;
                txtAntHistory.SelectionStart = txtAntHistory.Text.Length;
                txtAntHistory.ScrollToCaret();
                cachedList.Add(lifeEvent);
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Display any un-displayed history entries
        /// </summary>
        public void CheckHistory()
        {
            foreach (string lifeEvent in ant.LifeHistory)
            {
                StringBuilder sb = new StringBuilder();
                if (!cachedList.Contains(lifeEvent))
                {
                    txtAntHistory.Text += lifeEvent + Environment.NewLine;
                    txtAntHistory.SelectionStart = txtAntHistory.Text.Length;
                    txtAntHistory.ScrollToCaret();
                    cachedList.Add(lifeEvent);
                }
            }
        }
        #endregion
    }
}
