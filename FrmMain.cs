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
    public partial class FrmMain : Form
    {
        #region Private Member Variables
        List<Ant> antFarm;
        List<Food> availibleFood;
        List<Nest> availibleNests;
        Family droppingBaseFor;
        Random rndObject;
        Bitmap[] bmpAnt;
        Bitmap[] bmpAntCarryingFood;
        Bitmap[] bmpAntNest;
        Bitmap bmpFood;
        FrmAntJournal frmAntJournal;
        bool hasLoaded;
        #endregion

        #region Private Methods
        private void radioBaseDrop_CheckChanged(object sender, EventArgs e)
        {
            if (rdoYellow.Checked)
            {
                droppingBaseFor = Family.Yellow;
            }
            else if (rdoRed.Checked)
            {
                droppingBaseFor = Family.Red;
            }
            else if (rdoBlue.Checked)
            {
                droppingBaseFor = Family.Blue;
            }
            else if (rdoOrange.Checked)
            {
                droppingBaseFor = Family.Orange;
            }
        }

        private void HideRedundantInformation()
        {

            if (Settings.FamilyCount < 4)
            {
                grpKey.Size = new Size(167, 277);
                grpDropBase.Size = new Size(161, 90);
                grpKey.Top = grpDropBase.Bottom + 5;
                grpStats.Top = grpKey.Bottom + 5;
                grpStats.Size = new Size(161, 57);
                pboOrangeAnt.Visible = false;
                lblOrangeAnts.Visible = false;
                pboOrangeAntFood.Visible = false;
                lblOrangeAntsFood.Visible = false;
                pboOrangeNest.Visible = false;
                lblOrangeNest.Visible = false;
            }
            if (Settings.FamilyCount < 3)
            {
                grpKey.Size = new Size(167, 200);
                grpDropBase.Size = new Size(161, 69);
                grpKey.Top = grpDropBase.Bottom + 5;
                grpStats.Top = grpKey.Bottom + 5;
                grpStats.Size = new Size(161, 44);
                pboBlueAnt.Visible = false;
                lblBlueAnts.Visible = false;
                pboBlueAntFood.Visible = false;
                lblBlueAntsFood.Visible = false;
                pboBlueNest.Visible = false;
                lblBlueNest.Visible = false;
            }
            if (Settings.FamilyCount < 2)
            {
                grpKey.Size = new Size(167, 122);
                grpDropBase.Visible = false;
                grpKey.Top = grpSettings.Top + 15;
                grpStats.Top = grpKey.Bottom + 5;
                grpStats.Size = new Size(161, 29);
                pboRedAnt.Visible = false;
                lblRedAnts.Visible = false;
                pboRedAntFood.Visible = false;
                lblRedAntsFood.Visible = false;
                pboRedNest.Visible = false;
                lblRedNest.Visible = false;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                bmpAnt[i] = (Bitmap)Image.FromFile(@"Images\" + i + ".png");
                bmpAnt[i].MakeTransparent(bmpAnt[i].GetPixel(1, 1));
                bmpAntCarryingFood[i] = (Bitmap)Image.FromFile(@"Images\" + i + "-food.png");
                bmpAntCarryingFood[i].MakeTransparent(bmpAnt[i].GetPixel(1, 1));
                bmpAntNest[i] = (Bitmap)Image.FromFile(@"Images\" + i + "-nest.png");
            }

            HideRedundantInformation();

            bmpFood = (Bitmap)Image.FromFile(@"Images\Food.png");
            bmpFood.MakeTransparent(bmpFood.GetPixel(1, 1));

            frmAntJournal = new FrmAntJournal(antFarm);
            frmAntJournal.Show();
            MorphForm(frmAntJournal, Right - 14, Top - 1, Height);
            frmAntJournal.Height = Height;
            tmrWorld.Start();
            hasLoaded = true;
        }

        private void MorphForm(Form form, int left, int top, int height)
        {
            if (form != null)
            {
                form.Left = left;
                form.Top = top;
                form.Height = height;
            }
        }

        public Bitmap GetBitmapForAnt(Ant ant)
        {
            if (ant.HasFood) return bmpAntCarryingFood[(int)ant.Family];
            else return bmpAnt[(int)ant.Family];
        }

        public void DrawAnt(Ant ant, Graphics gfx)
        {
            Bitmap rotatedBitmap = GetBitmapForAnt(ant);
            if (ant.Facing == Direction.UpRight)
                rotatedBitmap = RotateImage(GetBitmapForAnt(ant), 45);
            else if (ant.Facing == Direction.Right)
                rotatedBitmap = RotateImage(GetBitmapForAnt(ant), 90);
            else if (ant.Facing == Direction.DownRight)
                rotatedBitmap = RotateImage(GetBitmapForAnt(ant), 135);
            else if (ant.Facing == Direction.Down)
                rotatedBitmap = RotateImage(GetBitmapForAnt(ant), 180);
            else if (ant.Facing == Direction.DownLeft)
                rotatedBitmap = RotateImage(GetBitmapForAnt(ant), 225);
            else if (ant.Facing == Direction.Left)
                rotatedBitmap = RotateImage(GetBitmapForAnt(ant), 270);
            else if (ant.Facing == Direction.UpLeft)
                rotatedBitmap = RotateImage(GetBitmapForAnt(ant), 315);
            gfx.DrawImage(rotatedBitmap, new Rectangle(ant.Location, ant.Size));
        }

        private void tmrWorld_Tick(object sender, EventArgs e)
        {
            if (frmAntJournal.Visible)
                frmAntJournal.CheckHistory();

            using (Graphics pnlWorldGraphics = pnlWorld.CreateGraphics())
            {
                foreach (Ant ant in antFarm)
                {
                    if (!ant.IsCurrentlyUnderANestOrFood)
                        pnlWorldGraphics.FillRectangle(Brushes.White, new Rectangle(ant.Location, new Size(Settings.CellSize, Settings.CellSize)));

                    if (Settings.IsViewingRectangleShown)
                        pnlWorldGraphics.DrawRectangle(Pens.White, ant.ViewingRectangle);
                }

                foreach (Ant ant in antFarm)
                { 
                    ant.Move();

                    if (!ant.IsCurrentlyUnderANestOrFood) DrawAnt(ant, pnlWorldGraphics);

                    if (Settings.IsViewingRectangleShown)
                        pnlWorldGraphics.DrawRectangle(Pens.Green, ant.ViewingRectangle);
                }
            }

            int civilianCount = 0;
            int redCount = 0;
            int blueCount = 0;
            int orangeCount = 0;
            foreach(Nest nest in availibleNests)
            {
                if (nest.Family == Family.Yellow) civilianCount += nest.FoodCount;
                else if (nest.Family == Family.Red) redCount += nest.FoodCount;
                else if (nest.Family == Family.Blue) blueCount += nest.FoodCount;
                else if (nest.Family == Family.Orange) orangeCount += nest.FoodCount;
            }
            lblCivilianStats.Text = "Civilians Food Collected: " + civilianCount;
            lblRedStats.Text = "Red Ants Food Collected: " + redCount;
            lblBlueStats.Text = "Blue Ants Food Collected: " + blueCount;
            lblOrangeStats.Text = "Orange Ants Food Collected: " + orangeCount;
        }

        private Bitmap RotateImage(Bitmap bmp, float angle)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            rotatedImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform((float)Settings.CellSize / 2, (float)Settings.CellSize / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-(float)Settings.CellSize / 2, -(float)Settings.CellSize / 2);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(bmp, new Point(0, 0));
            }
            return rotatedImage;
        }

        private bool IsNestOrFoodAtLocation(Point loc)
        {
            foreach (Nest nest in availibleNests)
            {
                if ((nest.Location == Utils.FitToGrid(loc)) ||
                    (nest.Location.X == loc.X + Settings.CellSize && nest.Location.Y == loc.Y) ||
                    (nest.Location.X == loc.X + Settings.CellSize && nest.Location.Y == loc.Y - Settings.CellSize) ||
                    (nest.Location.X == loc.X + Settings.CellSize && nest.Location.Y == loc.Y + Settings.CellSize) ||
                    (nest.Location.X == loc.X && nest.Location.Y == loc.Y - Settings.CellSize) ||
                    (nest.Location.X == loc.X && nest.Location.Y == loc.Y + Settings.CellSize))
                {
                    return true;
                }
            }

            foreach (Food food in availibleFood)
            {
                if (food.Location == loc && !food.Exhausted) return true;
            }

            return false;
        }

        private void BuildNest(Point loc)
        {
            availibleNests.Add(new Nest(loc, droppingBaseFor));
            availibleNests.Add(new Nest(Utils.FitToGrid(new Point(loc.X + Settings.CellSize, loc.Y + Settings.CellSize)), droppingBaseFor));
            availibleNests.Add(new Nest(Utils.FitToGrid(new Point(loc.X + Settings.CellSize, loc.Y)), droppingBaseFor));
            availibleNests.Add(new Nest(Utils.FitToGrid(new Point(loc.X, loc.Y + Settings.CellSize)), droppingBaseFor));
        }

        private bool CanPlaceNest(Point loc)
        {
            if (loc.X + (Settings.CellSize * 2) > pnlWorld.Right && loc.Y + (Settings.CellSize * 2) > pnlWorld.Bottom)
            {
                return false;
            }

            foreach (Food food in availibleFood)
            {
                if (food.Location == loc)
                    return false;
                if (food.Location.X == loc.X && food.Location.Y == loc.Y + Settings.CellSize)
                    return false;
                if (food.Location.X == loc.X + Settings.CellSize && food.Location.Y == loc.Y)
                    return false;
                if (food.Location.X == loc.X + Settings.CellSize && food.Location.Y == loc.Y + Settings.CellSize)
                    return false;
            }

            return true;
        }

        private void panelWorld_MouseClick(object sender, MouseEventArgs e)
        {
            // in case the user moves the cursor so fast that the computer places the nests out of formation.
            Point cursorPosition = Utils.FitToGrid(PointToClient(Cursor.Position));

            if (!IsNestOrFoodAtLocation(cursorPosition))
            {
                using (Graphics pnlWorldGraphics = pnlWorld.CreateGraphics())
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        if (CanPlaceNest(cursorPosition))
                        {
                            BuildNest(cursorPosition);

                            pnlWorldGraphics.DrawImage((bmpAntNest[(int)droppingBaseFor]),
                                new Rectangle(availibleNests[availibleNests.Count - 4].Location,
                                new Size(Settings.CellSize * 2, Settings.CellSize * 2)));
                        }
                    }
                    else if (e.Button == MouseButtons.Left)
                    {
                        if (cursorPosition.X + Settings.CellSize < pnlWorld.Right && cursorPosition.Y + Settings.CellSize < pnlWorld.Bottom)
                        {
                            availibleFood.Add(new Food(cursorPosition, Settings.FoodPiles));
                            pnlWorldGraphics.DrawImage(bmpFood, availibleFood[availibleFood.Count - 1].Location);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Updates the world to remove food if it's off screen when you resize the panel.
        /// </summary>
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            
            MorphForm(frmAntJournal, Right - 14, Top - 1, Height);

            if (hasLoaded)
            {
                foreach (Ant ant in antFarm)
                {
                    ant.SizeOfWorld = pnlWorld.Size;
                }


                List<Food> toRemove = new List<Food>();
                foreach (Food food in availibleFood)
                {
                    if (food.Location.X > pnlWorld.Size.Width || food.Location.Y > pnlWorld.Size.Height)
                        toRemove.Add(food);
                }
                foreach (Food food in toRemove)
                {
                    availibleFood.Remove(food);
                }
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Constructors
        public FrmMain()
        {
            InitializeComponent();
            antFarm = new List<Ant>();
            availibleFood = new List<Food>();
            availibleNests = new List<Nest>();
            bmpAnt = new Bitmap[4];
            bmpAntCarryingFood = new Bitmap[4];
            bmpAntNest = new Bitmap[4];
            rndObject = new Random();

            for (int i = 0; i < Settings.NumberOfAnts; i++)
            {
                for (int j = 0; j < Settings.FamilyCount; j++)
                {
                    antFarm.Add(new Ant(Utils.FitToGrid(new Point(rndObject.Next(0, ((pnlWorld.Width / Settings.CellSize) - 1)) * Settings.CellSize, rndObject.Next(0, ((pnlWorld.Height / Settings.CellSize) - 1)) * Settings.CellSize)), pnlWorld.Size, ((Family)j).ToString() + " [" + i.ToString() + "]", (Family)j, rndObject, availibleNests, availibleFood, antFarm));
                }
            }
        }

        private void FrmMain_LocationChanged(object sender, EventArgs e)
        {
            MorphForm(frmAntJournal, Right - 14, Top - 1, Height);
        }
    }
    #endregion
}
