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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            Settings.FoodPiles = (int)txtFoodPiles.Value;
            Settings.CellSize = (int)txtCellSize.Value;
            Settings.NumberOfAnts = (int)txtAntCount.Value;
            Settings.FamilyCount = (int)txtFamiles.Value;
            Settings.IsViewingRectangleShown = chkViewingRectangle.Checked;
            Settings.AntVisionRange = (int)txtAntVisionRange.Value;
            FrmMain main = new FrmMain();
            main.Show();
            this.Hide();
        }
    }
}
