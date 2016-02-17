using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AntSimulation
{
    public class Ant
    {
        #region Private Member Variables
        /// <summary>
        /// used to contain the randomising object used by the ant class.
        /// </summary>
        Random randomObject;

        List<Nest> availableNests;

        List<Food> availableFoods;

        List<Ant> antsInWorld;
        #endregion

        #region Private Methods
        /// <summary>
        /// Memory management method to keep the amount of memory the LifeHistory array uses. Not a problem for a small amount of ants but the CPU really feels it if there is a large amount of ants.
        /// </summary>
        private void CropLifeHistory()
        {
            if (LifeHistory.Count > 10)
            {
                for (int i = 0; i < LifeHistory.Count - 10; i++)
                    LifeHistory.Remove(LifeHistory[i]);
            }
        }

        /// <summary>
        /// As a part of the brief we are supposed to allow the ants to forget where their home or food is or both.
        /// This function provdies currently a 1% chance for the ant to forget something, 
        /// Then a further 1 in 3 cance of forgetting their home or food or both.
        /// </summary>
        private void ForgetLocations()
        {
            int rndNum = randomObject.Next(1, 100);
            if (rndNum < 1)
            {
                rndNum = randomObject.Next(1, 4);
                if (rndNum == 1 || rndNum == 3)
                {
                    if (!RememberedFoodLocation.IsEmpty)
                    {
                        RememberedFoodLocation = new Point();
                        LifeHistory.Add("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " + "I forgot where food is.");
                    }
                }

                if (rndNum == 2 || rndNum == 3)
                {
                    if (RememberedHome != null)
                    {
                        RememberedHome = null;
                        LifeHistory.Add("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " + "I forgot where home is.");
                    }
                }
            }
        }

        private void MoveInDirectionOf(Point loc)
        {
            if (Location.X < loc.X && Location.Y > loc.Y)
                Move(Direction.UpRight);
            else if (Location.X < loc.X && Location.Y < loc.Y)
                Move(Direction.DownRight);
            else if (Location.X > loc.X && Location.Y < loc.Y)
                Move(Direction.DownLeft);
            else if (Location.X > loc.X && Location.Y > loc.Y)
                Move(Direction.UpLeft);
            else if (Location.Y > loc.Y)
                Move(Direction.Up);
            else if (Location.X < loc.X)
                Move(Direction.Right);
            else if (Location.Y < loc.Y)
                Move(Direction.Down);
            else if (Location.X > loc.X)
                Move(Direction.Left);
        }

        private void DeliverFoodHome()
        {
            MoveInDirectionOf(RememberedHome.Location);

            if (RememberedHome.Location == Location)
            {
                RememberedHome.FoodCount += 1;
                FoodCollected += 1;
                HasFood = false;

                LifeHistory.Add("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " + "I delivered food home to " + RememberedHome.Location.X + ", " + RememberedHome.Location.Y + ".");
            }
        }

        private bool HasSameFamily(Ant ant)
        {
            if (ant.Family == this.Family) return true;
            else return false;
        }

        private void AskFoodLocation()
        {
            foreach (Ant ant in antsInWorld)
            {
                if ((ant != this) && (ant.Location == Location) && HasSameFamily(ant))
                {
                    if (RememberedFoodLocation.IsEmpty && !ant.RememberedFoodLocation.IsEmpty)
                    {
                        RememberedFoodLocation = ant.RememberedFoodLocation;
                        LifeHistory.Add("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " + ant.Name + " gave me knowledge of where food is.");
                    }

                    if (RememberedHome == null && ant.RememberedHome != null)
                    {
                        RememberedHome = ant.RememberedHome;
                        LifeHistory.Add("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " + ant.Name + " gave me knowledge of where home is.");
                    }
                }
            }
        }

        private bool IsPointInRectangle(Rectangle rect, Point point)
        {
            if ((point.X >= rect.Left && point.X < rect.Right) &&
                (point.Y >= rect.Top && point.Y < rect.Bottom))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void HandleCivilianMove()
        {
            if (!HasFood && !RememberedFoodLocation.IsEmpty)
            {
                foreach (Food food in availableFoods)
                {
                    // if the ant can see the food but all has been claimed by master :(
                    if (IsPointInRectangle(ViewingRectangle, RememberedFoodLocation))
                    {
                        if (food.Location == RememberedFoodLocation && food.Remaining == 0)
                        {
                            RememberedFoodLocation = new Point();
                            LifeHistory.Add("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " + "I forgot where food was because the pile was empty.");
                        }
                    }

                    if (food.Location == Location && !HasFood)
                    {
                        if (food.Remaining > 0)
                        {
                            HasFood = true;
                            food.Remaining -= 1;
                            LifeHistory.Add("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " + "I obtained food.");
                        }
                        else
                        {
                            RememberedFoodLocation = new Point();
                            LifeHistory.Add("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " + "I forgot where food was because the pile was empty.");
                        }
                    }
                }
            }

            if (RememberedFoodLocation.IsEmpty)
            {
                CheckForFood();
            }
        }

        private void HandleRobberMove()
        {
            if (!HasFood && !RememberedFoodLocation.IsEmpty && Location == RememberedFoodLocation)
            {
                Ant tempAnt = null;
                foreach (Ant ant in antsInWorld)
                {
                    if (ant != this && !HasSameFamily(ant) && ant.Location == Location && !HasFood)
                    {
                        tempAnt = ant;
                        if (ant.HasFood)
                        {
                            ant.HasFood = false;
                            HasFood = true;
                            LifeHistory.Add("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " + "I stole food from " + ant.Name + " MWUHAHAHAHAHAH.");
                        }
                        else
                        {
                            RememberedFoodLocation = new Point();
                            LifeHistory.Add("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " + "I forgot where food was because the ant I tried to steal from had no food :(.");
                        }
                        break;
                    }
                }

                if (tempAnt == null)
                {
                    RememberedFoodLocation = new Point();
                    LifeHistory.Add("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " + "I forgot where food was because the ant I mugged before isn't here :(.");
                }
            }

            if (RememberedFoodLocation.IsEmpty)
            {
                CheckForAntToRob();
            }
        }

        private void MoveRandom()
        {
            // wander around until it's found some food
            // ask other ants if they have any idea of where there's food
            Direction[] validDirections = new Direction[5];
            if (Facing == Direction.Up) { validDirections = new Direction[] { Direction.Left, Direction.UpLeft, Direction.Up, Direction.UpRight, Direction.Right }; }
            else if (Facing == Direction.UpRight) { validDirections = new Direction[] { Direction.UpLeft, Direction.Up, Direction.UpRight, Direction.Right, Direction.DownRight }; }
            else if (Facing == Direction.Right) { validDirections = new Direction[] { Direction.Up, Direction.UpRight, Direction.Right, Direction.DownRight, Direction.Down }; }
            else if (Facing == Direction.DownRight) { validDirections = new Direction[] { Direction.UpRight, Direction.Right, Direction.DownRight, Direction.Down, Direction.DownLeft }; }
            else if (Facing == Direction.Down) { validDirections = new Direction[] { Direction.Right, Direction.DownRight, Direction.Down, Direction.DownLeft, Direction.Left }; }
            else if (Facing == Direction.DownLeft) { validDirections = new Direction[] { Direction.DownRight, Direction.Down, Direction.DownLeft, Direction.Left, Direction.UpLeft }; }
            else if (Facing == Direction.Left) { validDirections = new Direction[] { Direction.Down, Direction.DownLeft, Direction.Left, Direction.UpLeft, Direction.Up }; }
            else if (Facing == Direction.UpLeft) { validDirections = new Direction[] { Direction.DownLeft, Direction.Left, Direction.UpLeft, Direction.Up, Direction.UpRight }; }

            Move(validDirections[randomObject.Next(0, 4)]);
        }

        private void CheckIfAntHasGoneOffScreen()
        {
            // off of the screen to the right
            if (Location.X + Settings.CellSize > SizeOfWorld.Width)
            {
                Location = new Point(0, Location.Y);
            }

            // off the bottom of the screen
            if (Location.Y + Settings.CellSize > SizeOfWorld.Height)
            {
                Location = new Point(Location.X, 0);
            }

            // off the left side of the screen
            if (Location.X < 0)
            {
                Location = Utils.FitToGrid(new Point(SizeOfWorld.Width - Settings.CellSize, Location.Y));
            }

            // off the top of the screen
            if (Location.Y < 0)
            {
                Location = Utils.FitToGrid(new Point(Location.X, SizeOfWorld.Height - Settings.CellSize));
            }
        }

        private void Move(Direction inDirection)
        {
            Facing = inDirection;
            if (Facing == Direction.Up) { Location = new Point(Location.X, Location.Y - Settings.CellSize); }
            else if (Facing == Direction.UpRight) { Location = new Point(Location.X + Settings.CellSize, Location.Y - Settings.CellSize); }
            else if (Facing == Direction.Right) { Location = new Point(Location.X + Settings.CellSize, Location.Y); }
            else if (Facing == Direction.DownRight) { Location = new Point(Location.X + Settings.CellSize, Location.Y + Settings.CellSize); }
            else if (Facing == Direction.Down) { Location = new Point(Location.X, Location.Y + Settings.CellSize); }
            else if (Facing == Direction.DownLeft) { Location = new Point(Location.X - Settings.CellSize, Location.Y + Settings.CellSize); }
            else if (Facing == Direction.Left) { Location = new Point(Location.X - Settings.CellSize, Location.Y); }
            else if (Facing == Direction.UpLeft) { Location = new Point(Location.X - Settings.CellSize, Location.Y - Settings.CellSize); }

            CheckIfAntHasGoneOffScreen();

            UpdateViewingRectangle();
        }

        private void UpdateViewingRectangle()
        {
            if (Facing == Direction.Up) { ViewingRectangle = new Rectangle(Utils.FitToGrid(new Point(Location.X - ((ViewRange / 2) * Settings.CellSize), Location.Y - (ViewRange * Settings.CellSize))), new Size(ViewRange * Settings.CellSize, ViewRange * Settings.CellSize)); }
            else if (Facing == Direction.UpRight) { ViewingRectangle = new Rectangle(Utils.FitToGrid(new Point(Location.X + Settings.CellSize, Location.Y - (ViewRange * Settings.CellSize))), new Size(ViewRange * Settings.CellSize, ViewRange * Settings.CellSize)); }
            else if (Facing == Direction.Right) { ViewingRectangle = new Rectangle(Utils.FitToGrid(new Point(Location.X + Settings.CellSize, Location.Y - ((ViewRange / 2) * Settings.CellSize))), new Size(ViewRange * Settings.CellSize, ViewRange * Settings.CellSize)); }
            else if (Facing == Direction.DownRight) { ViewingRectangle = new Rectangle(Utils.FitToGrid(new Point(Location.X + Settings.CellSize, Location.Y + Settings.CellSize)), new Size(ViewRange * Settings.CellSize, ViewRange * Settings.CellSize)); }
            else if (Facing == Direction.Down) { ViewingRectangle = new Rectangle(Utils.FitToGrid(new Point(Location.X - ((ViewRange / 2) * Settings.CellSize), Location.Y + Settings.CellSize)), new Size(ViewRange * Settings.CellSize, ViewRange * Settings.CellSize)); }
            else if (Facing == Direction.DownLeft) { ViewingRectangle = new Rectangle(Utils.FitToGrid(new Point(Location.X - (ViewRange * Settings.CellSize), Location.Y + Settings.CellSize)), new Size(ViewRange * Settings.CellSize, ViewRange * Settings.CellSize)); }
            else if (Facing == Direction.Left) { ViewingRectangle = new Rectangle(Utils.FitToGrid(new Point(Location.X - (Settings.CellSize * ViewRange), Location.Y - ((ViewRange / 2) * Settings.CellSize))), new Size(ViewRange * Settings.CellSize, ViewRange * Settings.CellSize)); }
            else if (Facing == Direction.UpLeft) { ViewingRectangle = new Rectangle(new Point(Location.X - (ViewRange * Settings.CellSize), Location.Y - (ViewRange * Settings.CellSize)), new Size(ViewRange * Settings.CellSize, ViewRange * Settings.CellSize)); }
        }

        private void CheckForNests()
        {
            foreach (Nest nest in availableNests)
            {
                if (RememberedHome == null && nest.Family == this.Family)
                {
                    if ((nest.Location.X > ViewingRectangle.Left && nest.Location.X < ViewingRectangle.Right) &&
                        (nest.Location.Y > ViewingRectangle.Top && nest.Location.Y < ViewingRectangle.Bottom))
                    {
                        RememberedHome = nest;
                        LifeHistory.Add("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " + "I found a new home!");
                        break;
                    }
                }
            }
        }

        private void CheckForFood()
        {
            foreach (Food food in availableFoods)
            {
                if (RememberedFoodLocation.IsEmpty && food.Remaining > 0)
                {
                    if (IsPointInRectangle(ViewingRectangle, food.Location))
                    {
                        RememberedFoodLocation = food.Location;
                        LifeHistory.Add("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " + "I found some food!");
                        break;
                    }
                }
            }
        }

        private void CheckForAntToRob()
        {
            foreach (Ant ant in antsInWorld)
            {
                if (RememberedFoodLocation.IsEmpty && ant.HasFood && ant.Family != this.Family)
                {
                    if (IsPointInRectangle(ViewingRectangle, ant.Location))
                    {
                        RememberedFoodLocation = ant.Location;
                        LifeHistory.Add("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " + " I found an ant to steal from");
                        break;
                    }
                }
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="location"></param>
        /// <param name="sizeOfWorld"></param>
        /// <param name="name"></param>
        /// <param name="family"></param>
        /// <param name="rndObject">A random object created outside of the class so that each number will be truely random.</param>
        public Ant(Point location, Size sizeOfWorld, string name, Family family, Random rndObject, List<Nest> availableNests, List<Food> availableFoods, List<Ant> antsInWorld)
        {
            randomObject = rndObject;
            Location = location;
            Age = 0;
            Name = name;
            ViewRange = Settings.AntVisionRange;
            Facing = Direction.Up;
            SizeOfWorld = sizeOfWorld;
            HasFood = false;
            ViewingRectangle = new Rectangle();
            LifeHistory = new List<string>();
            Family = family;
            this.availableFoods = availableFoods;
            this.availableNests = availableNests;
            this.antsInWorld = antsInWorld;
            RememberedFoodLocation = new Point();

            LifeHistory.Add("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " +"I was born at x:" + Location.X + " y:" + Location.Y + " as a " + family.ToString() + " ant");
            UpdateViewingRectangle();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Read Only property. Used so that when the ant gains age, it becomes more forgetful and can possibly die. Not implemented
        /// </summary>
        public int Age { get; private set; }

        /// <summary>
        /// Read only property for the distance the ant can see.
        /// </summary>
        public int ViewRange { get; private set; }

        /// <summary>
        /// Gets and sets the life history of the ant. Should only be used to add life events such as forgetting/getting information aboout food/housing or obtaining food
        /// </summary>
        public List<string> LifeHistory { get; private set; }

        /// <summary>
        /// Read only property storing the amount of food the ant has collected.
        /// </summary>
        public int FoodCollected { get; private set; }

        /// <summary>
        /// Read only property storing the name of the ant.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Denotes that the Ant is currently carrying food.
        /// </summary>
        public bool HasFood { get; private set; }

        /// <summary>
        /// Gets the size of the ant
        /// </summary>
        public Size Size
        {
            get { return new Size(Settings.CellSize, Settings.CellSize); }
        }

        /// <summary>
        /// Gets or sets whether the ant should be hiden as it's under some food or a nest.
        /// </summary>
        public bool IsCurrentlyUnderANestOrFood
        {
            get
            {
                foreach (Food food in availableFoods)
                {
                    if (food.Location == Location)
                    {
                        if (!food.Exhausted)
                        {
                            return true;
                        }
                    }
                }
                foreach (Nest nest in availableNests)
                {
                    if (nest.Location == Location)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// Current relative location of the ant.
        /// </summary>
        public Point Location { get; private set; }

        /// <summary>
        /// Gets and locally the direction that the Ant is currently facing in.
        /// </summary>
        public Direction Facing { get; private set; }

        /// <summary>
        /// The location of food which the ant currently collects from.
        /// </summary>
        public Point RememberedFoodLocation { get; private set; }

        /// <summary>
        /// The nest which the ant currently deems as "Home".
        /// </summary>
        public Nest RememberedHome { get; private set; }

        /// <summary>
        /// Essentially this is just a box which the ant will look through cell by cell to see if there's anything inside of it
        /// </summary>
        public Rectangle ViewingRectangle { get; private set; }

        /// <summary>
        /// Gets and Sets the boundaries of which the ant will move inside.
        /// </summary>
        public Size SizeOfWorld { get; set; }

        /// <summary>
        /// Gets and Sets the family that the ant belongs to
        /// </summary>
        public Family Family { get; private set; }
        #endregion

        #region Public Methods
        /// <summary>
        /// Moves the ant and documents in its LifeHistory property what has happened during this movement.
        /// </summary>
        public void Move()
        {
            ForgetLocations();

            if (HasFood && RememberedHome != null)
            {
                DeliverFoodHome();
            }
            else if ((!HasFood && RememberedFoodLocation.IsEmpty) || (HasFood && RememberedHome == null))
            {
                MoveRandom();
                AskFoodLocation();
            }
            else if (!HasFood && !RememberedFoodLocation.IsEmpty)
            {
                MoveInDirectionOf(RememberedFoodLocation);
            }
            
            if (Family == Family.Yellow)
            {
                HandleCivilianMove();
            }
            else if (Family != Family.Yellow)
            {
                HandleRobberMove();
            }

            if (RememberedHome == null)
            {
                CheckForNests();
            }

            CropLifeHistory();
        }
        #endregion
    }
}
