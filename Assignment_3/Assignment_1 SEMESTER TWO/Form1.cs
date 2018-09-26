using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1_SEMESTER_TWO
{
    public partial class Form1 : Form
    {
        int timeMs, timeSec, timeMin; //variables for the time controler. Stopwatch.
        bool isActive;
        public Button[,] arrayMap = new Button[20, 20];
        Unit[] redFaction = new Unit[0];
        Unit[] blueFaction = new Unit[0];
        GameEngine MainGame;
        //Function to generate the map
        public void generateMap()
        {
            //Belowe line clears the map on the grid
            this.Grid.Controls.Clear();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Button btn = new Button();
                    //Empty e = new Empty();
                    arrayMap[i, j] = btn;
                    //arrayMap[i, j].Name = "E";
                    //arrayMap[i, j] = btn;
                    /*
                * I got the Melee unit image from the site belowe 
               https://thecodexonline.com/cropped-1157b6fd85f1ff2-1-jpg/
               */    
                    btn.BackgroundImage = Assignment_1_SEMESTER_TWO.Properties.Resources.background; // Nice bit of code to fill my buttons with my background image
                    btn.Height = 65;
                    btn.Width = 65;
                    btn.Click += new EventHandler(BG_Click);
                    this.Grid.Controls.Add(btn);    
                }
            }
        }

        public void BG_Click(object sender, EventArgs e)
        {
            info_txb.Text = "There is nothing here";
        }
        //Function to randomly place Units in Map
        public void generateUnits()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int x = rand.Next(0, 19);
            int y = rand.Next(0, 19);
            int team = rand.Next(0, 3); // 0 == neutral, 1 == blue, 2 == red
            int unitSelect = rand.Next(0, 5);
            Unit unit;

            if (unitSelect == 0)
            {
                unit = new MeleeUnit(this);
                unit.Name = "M";
                /* I got the Melee unit image from the site belowe 
               https://gameartpartners.com/chibi-collection/
               */
                unit.BackgroundImage = Assignment_1_SEMESTER_TWO.Properties.Resources.Titan; // Another bit op code for when unit is placed use allocated image
                unit.Click += new EventHandler(MeleeUnit_Click);
            }

            else if (unitSelect == 1)
            {
                unit = new RangedUnit();
                unit.Name = "R";
                /*
                I got the Range unit image from the site belowe 
                https://gameartpartners.com/downloads/evil-bot/
                */
                unit.BackgroundImage = Assignment_1_SEMESTER_TWO.Properties.Resources.Nanobots; // Another bit op code for when unit is placed use allocated image
                unit.Click += new EventHandler(RangedUnit_Click);
            }

            else if (unitSelect == 2)
            {
                unit = new TankUnit();
                unit.Name = "T";
                /*
                I got the Tank unit image from the site belowe 
                https://gameartpartners.com
                */
                unit.BackgroundImage = Assignment_1_SEMESTER_TWO.Properties.Resources.Mega_Bot; // Another bit op code for when unit is placed use allocated image
                unit.Click += new EventHandler(TankUnit_Click);
            }
            else if (unitSelect == 3)
            {
                unit = new RogueUnit();
                unit.Name = "RO";
                /*
                I got the Range unit image from the site belowe 
                https://gameartpartners.com
                */
                unit.BackgroundImage = Assignment_1_SEMESTER_TWO.Properties.Resources.Mili_bot; // Another bit op code for when unit is placed use allocated image
                unit.Click += new EventHandler(RogueUnit_Click);
            }
            else 
            {
                unit = new NeutralUnit();
                unit.Name = "N";
                /*
                I got the Range unit image from the site belowe 
                https://gameartpartners.com
                */
                unit.BackgroundImage = Assignment_1_SEMESTER_TWO.Properties.Resources.Neautral; // Another bit op code for when unit is placed use allocated image
                unit.Click += new EventHandler(NeutralUnit_Click);
            }

            unit.Height = 65;
            unit.Width = 65;
            unit.AutoSizeMode = AutoSizeMode; //Tried to fit picture to buttons
            unit.positionX = x;
            unit.positionY = y;

            unit.team = team;

            if (team == 0)
            {
                unit.TeamName = "Hunters";
            }
            else if (team == 1)
            {
                unit.TeamName = "Rebels";
            }
            else
            {
                unit.TeamName = "Helvellic’s syndicate";
            }
            //Random position

            arrayMap[x, y] = unit;
            Grid.Controls.Add((unit), x, y); 
        }
        /*  public void Save()
{
string Filename = @"D:\\arrayMap.txt";
IFormatter formatter = new BinaryFormatter();
Stream stream = new FileStream(Filename, FileMode.Create, FileAccess.Write);

formatter.Serialize(stream, arrayMap);
stream.Close();
}

public void Load()
{
string Filename = @"D:\\arrayMap.txt";

IFormatter formatter = new BinaryFormatter();
Stream stream = new FileStream(Filename, FileMode.Open, FileAccess.Read);

arrayMap = (String[,])formatter.Deserialize(stream);
stream.Close();
generateMap();
}
*/
        //Code to gererate the Factory Buildings
        public void generateFactoryBuilding()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            Building building;
            building = new Building();
            building.Name = "F";
            /*
             * I got the Factory building image from the site belowe 
            https://twitter.com/dokodonmystery
            */
            building.BackgroundImage = Assignment_1_SEMESTER_TWO.Properties.Resources.FactoryBuilding;
            building.Click += new EventHandler(FactoryBuilding_Click);
            //}
            building.Height = 65;
            building.Width = 65;
            building.AutoSizeMode = AutoSizeMode; //Tried to fit picture to buttons
            //Random position
            int x = rand.Next(1, 20);
            int y = rand.Next(1, 20);
            Grid.Controls.Add((building), x, y);
        }
        //Code to gererate the Resource Buildings
        public void generateResourceBuilding()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            Building building;
            building = new Building();
            building.Name = "R";
            /*
            * I got the Resource building  image from the site belowe 
            https://aminoapps.com/c/cartoon/page/blog/the-phineas-and-ferb-formula/g0JU_6uqjQRZx6aNbWDGWEMwd34EJap
            */
            building.BackgroundImage = Assignment_1_SEMESTER_TWO.Properties.Resources.ResourceBuilding;
            building.Click += new EventHandler(ResourcesBuilding_Click);

            building.Height = 65;
            building.Width = 65;
            building.AutoSizeMode = AutoSizeMode; //Tried to fit picture to buttons
            //Random position
            int x = rand.Next(1, 20);
            int y = rand.Next(1, 20);
            Grid.Controls.Add((building), x, y);
        }
        //Code to gererate the Hunters Buildings
        public void generateHuntersBuilding()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            Building building;
            building = new Building();
            building.Name = "H";
            /*
            * I got the Hunters building  image from the site belowe 
            http://phineasandferb.wikia.com/wiki/World%27s_Tallest_Building
            */
            building.BackgroundImage = Assignment_1_SEMESTER_TWO.Properties.Resources.Neutral_building;
            building.Click += new EventHandler(HuntersBuilding_Click);
            building.Height = 65;
            building.Width = 65;
            building.AutoSizeMode = AutoSizeMode; //Tried to fit picture to buttons
            //Random position
            int x = rand.Next(1, 20);
            int y = rand.Next(1, 20);
            Grid.Controls.Add((building), x, y);
        }

        public Form1()
        {
            InitializeComponent();
            int width = this.Width;
            int height = this.Height;
            width = 1000;
            height = 1000;
            generateMap(); // Initializing Map
            //Generate Units after map has been rest
            for (int i = 0; i < 40; i++)
            {
                generateUnits();  
            }
            //Generates Buildings
            for (int j = 0; j < 2; j++)
            {
                generateFactoryBuilding();
                generateResourceBuilding();
                generateHuntersBuilding();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainGame = new GameEngine(this);

            ResetTime(); //Rest Function
            isActive = false;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            isActive = true; 
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            isActive = false;
            generateMap();// Generate new map
            ResetTime();
            MainGame.ResourceB.I = 1;
            scrapCount_lbl.Text = "00";
            scrapCounter2_lbl.Text = "00";
            //GenerateUnits units
            for (int i = 0; i < 30; i++)
            {
                generateUnits();
            }
            //Gereates Buildings
            for (int j = 0; j < 2; j++)
            {
                generateFactoryBuilding();
                generateResourceBuilding();
            }
        }

        private void ResetTime()
        {
            timeMs = 0;
            timeSec = 0;
            timeMin = 0;
        }

        ResourceBuilding r = new ResourceBuilding();

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Code to activate stopwatch to show correct time
            if (isActive)
            {
                timeMs++; 
                if (timeMs >= 100)
                {
                    timeSec++;
                    timeMs = 0;
                    MainGame.ResourceB.generateResources();
                    if (timeSec >= 60 )
                    {
                        timeMin++;
                        timeSec = 0;
                    }
                }
            }    
            DrawTime();
        }

        private void Grid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void MeleeUnit_Click(object sender, EventArgs e)
        {
            MeleeUnit melee = new MeleeUnit(this);
            info_txb.Text = melee.ToString();
        }

        void TankUnit_Click(object sender, EventArgs e)
        {
            TankUnit tank = new TankUnit(this);
            info_txb.Text = tank.ToString();
        }

        private void RogueUnit_Click(object sender, EventArgs e)
        {
            RogueUnit rogue = new RogueUnit(this);
            info_txb.Text = rogue.ToString();
        }

        private void NeutralUnit_Click(object sender, EventArgs e)
        {
            NeutralUnit neutral = new NeutralUnit(this);
            info_txb.Text = neutral.ToString();
        }

        private void titan_pic_Click(object sender, EventArgs e)
        { 
            
        }

        void RangedUnit_Click(object sender, EventArgs e)
        {
            RangedUnit ranged = new RangedUnit();
            info_txb.Text = ranged.ToString();
        }

        private void nano_pic_Click(object sender, EventArgs e)
        {

        }

        void FactoryBuilding_Click(object sender, EventArgs e)
        {
            FactoryBuilding factory = new FactoryBuilding();
            info_txb.Text = factory.ToString();
        }

        void ResourcesBuilding_Click(object sender, EventArgs e)
        {
            ResourceBuilding resource = new ResourceBuilding();
            info_txb.Text = resource.ToString();
        }

        private void HuntersBuilding_Click(object sender, EventArgs e)
        {
            HuntersBuilding hunters = new HuntersBuilding();
            info_txb.Text = hunters.ToString();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }

        private void read_btn_Click(object sender, EventArgs e)
        {

        }

        private void scrapCount_lbl_Click(object sender, EventArgs e)
        {

        }

        private void scrapCounter2_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void DrawTime()
        { //Timer Display
            mili_lbl.Text = String.Format("{0:00}", timeMs);
            second_lbl.Text = String.Format("{0:00}", timeSec);
            min_lbl.Text = String.Format("{0:00}", timeMin);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    /*public class Empty : Button
    {

    }*/

    public abstract class Unit : Button
    {
        public Form1 fm { get; set; }
        public int positionX { get; set; }
        public int positionY { get; set; }
        public int health { get; set; } 
        public int speed { get; set; }
        public int attack { get; set; }
        public int attackRange { get; set; }
        public int team { get; set; }
        public string TeamName { get; set; }
        public char image { get; set; }
        protected string name { get; set; }
        public int nextPositionX { get; set; }
        public int nextPositionY { get; set; }
        public Unit ClosestUnit { get; set; }

        public Unit()
        {
            health = 100;

        }

        public virtual void getClosestUnit()
        {
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    if (fm.arrayMap[x, y] is Unit)
                    {
                        /*double r = Math.Sqrt((x * positionX) + (y * positionY));
                        if (r < distance)
                        {
                            closestUnitX = x;
                            closestUnitY = y;
                            distance = Convert.ToInt32(r);
                        }*/
                    }
                }
            }
           
        }

        public virtual void move()
        {

        }

        public virtual void combat()
        {

        }

        public virtual void isRange()
        {

        }

        public virtual void returnUnit()
        {

        }

        public virtual void isDead()
        {

        }

        public virtual string ToString()
        {
            return " ";
        }

        public abstract void Save();
    }

    public class MeleeUnit : Unit
    {
        int distance = 100;
        protected int closestUnitX;
        protected int closestUnitY;
        
        public MeleeUnit(Form1 fm)
        {
            this.fm = fm;
            name = "Malee Unit";
            health = 100;
            attack = 3;
            speed = 2;
            attackRange = 1;
        }

        public override void getClosestUnit()
        {
            base.getClosestUnit();
        }

        public override void move()
        {
            if (health > health * 0.25)
            {
                if (positionY == closestUnitY)
                {
                    if (positionX < closestUnitX)
                    {
                        nextPositionX = closestUnitX - (positionX + 1);
                        if (fm.arrayMap[nextPositionX, positionY].Name == "E")
                        {
                            positionX = nextPositionX;
                        }
                    }
                    else if (positionX > closestUnitX)
                    {
                        nextPositionX = positionX - 1;
                        if (fm.arrayMap[nextPositionX, positionY].Name == "E")
                        {
                            positionX = nextPositionX;
                        }
                    }
                }
                else if (positionX == closestUnitX)
                {
                    if (positionY < closestUnitY)
                    {
                        nextPositionY = closestUnitY - (closestUnitY - 1);
                        if (fm.arrayMap[positionX, nextPositionY].Name == "E")
                        {
                            positionY = nextPositionY;
                        }
                    }
                    else if (positionY > closestUnitY)
                    {
                        nextPositionY = positionY - 1;
                        if (fm.arrayMap[positionX, nextPositionY].Name == "E")
                        {
                            positionY = nextPositionY;
                        }
                    }
                    else if (positionX == closestUnitX && positionY == closestUnitY)
                    {
                        if (positionX < closestUnitX && positionY < closestUnitY)
                        {
                            nextPositionX = closestUnitX - (positionX + 1);
                            nextPositionY = closestUnitY - (positionY + 1);
                            if (fm.arrayMap[nextPositionX, nextPositionY].Name == "E")
                            {
                                positionX = nextPositionX;
                                positionY = nextPositionY;
                            }
                        }
                        else if (positionX > closestUnitX && positionY > closestUnitY)
                        {
                            nextPositionX = positionX - 1;
                            nextPositionY = positionY - 1;
                            if (fm.arrayMap[nextPositionX, nextPositionY].Name == "E")
                            {
                                positionX = nextPositionX;
                                positionY = nextPositionY;
                            }
                        }
                    }
                    else if (positionX < closestUnitX && positionY > closestUnitY)
                    {
                        nextPositionX = closestUnitX - (positionX + 1);
                        nextPositionY = positionY;
                        if (fm.arrayMap[nextPositionX, nextPositionY].Name == "E")
                        {
                            positionX = nextPositionX;
                            positionY = nextPositionY;
                        }
                    }
                    else if (positionX > closestUnitX && positionY < closestUnitY)
                    {
                        nextPositionX = positionX - 1;
                        nextPositionY = closestUnitY - (positionY + 1);
                        if (fm.arrayMap[nextPositionX, nextPositionY].Name == "E")
                        {
                            positionX = nextPositionX;
                            positionY = nextPositionY;
                        }
                    }
                }
            }
        }

        public override void combat()
        {
            /*
             *   if (combat)
            {
                isRange(this.unitsList);
            }
            else
            {
                combat = true;
                isRange(this.unitsList);
            }

            /*Random random = new Random();
            int randomNumber;

            while (this.health <= 0 && health <= 0)
            {
                randomNumber = random.Next(0, 2);
                if(randomNumber == 0)
                {
                    this.health -= attack;
                }
                else
                {
                    health -= this.attack;
                }
            }*/
        }

        public override void isRange()
        {
            //implement search diagonal pitagoras. Internet is my friend.

            /* for (int i = 1; i <= this.attackRange; i++)
             {
                 //front
                 if(map[this.positionX][this.PositionY + i] != null)
                 {
                     return true;
                 }
                 //left
                 if (map[this.positionX - i][this.positionY] != null)
                 {
                     return true;
                 }
                 //back
                 if (map[this.positionX][this.positionY - i] != null)
                 {
                     return true;
                 }
                 //right
                 if (map[this.positionX + i][this.positionY] != null)
                 {
                     return true;
                 }
             }*/
        }

        public override void returnUnit()
        {

        }

        public override void isDead()
        {

        }

        public override string ToString()
        {   
            string str = "Team:" + TeamName + Environment.NewLine + "Health: "+ health + Environment.NewLine + "Attack:" + attack + Environment.NewLine + "Speed:" + speed+ Environment.NewLine + "Range:" + attackRange;
            return str;
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class RangedUnit : Unit
    {
        int distance = 100;
        protected int closestUnitX;
        protected int closestUnitY;

        public RangedUnit()
        {
            name = "Ranged Unit";
            health = 100;
            TeamName = "Nanobots";
            attack = 2;
            speed = 1;
            attackRange = 4;
        }

        public override void getClosestUnit()
        {
            base.getClosestUnit();
        }

        public override void move()
        {
              if (health>health*0.25)
              {
                 if ( positionY == closestUnitY)
                 {
                     if (positionX < closestUnitX)
                     {
                         nextPositionX = closestUnitX - (positionX + 1);
                         if (fm.arrayMap[nextPositionX, positionY].Name == "E")
                         {
                             positionX = nextPositionX;
                         }
                     }
                     else if (positionX > closestUnitX)
                     {
                         nextPositionX = positionX - 1;
                         if (fm.arrayMap[nextPositionX, positionY].Name == "E")
                         {
                             positionX = nextPositionX;
                         }
                     }
                 }
                 else if (positionX == closestUnitX)
                 {
                     if (positionY < closestUnitY)
                     {
                         nextPositionY = closestUnitY - (closestUnitY - 1);
                         if( fm.arrayMap[positionX, nextPositionY].Name == "E")
                         {
                             positionY = nextPositionY;
                         }
                     }
                     else if (positionY > closestUnitY)
                     {
                         nextPositionY = positionY - 1;
                         if( fm.arrayMap[positionX, nextPositionY].Name == "E")
                         {
                             positionY = nextPositionY;
                         }
                     }
                     else if (positionX == closestUnitX && positionY == closestUnitY)
                     {
                         if (positionX < closestUnitX && positionY < closestUnitY)
                         {
                             nextPositionX = closestUnitX - (positionX + 1);
                             nextPositionY = closestUnitY - (positionY + 1);
                             if (fm.arrayMap[nextPositionX, nextPositionY].Name == "E")
                             {
                                 positionX = nextPositionX;
                                 positionY = nextPositionY;
                             }
                         }
                         else if (positionX > closestUnitX && positionY > closestUnitY)
                         {
                             nextPositionX = positionX - 1;
                             nextPositionY = positionY - 1;
                             if (fm.arrayMap[nextPositionX,nextPositionY].Name == "E")
                             {
                                 positionX = nextPositionX;
                                 positionY = nextPositionY;
                             }
                         }
                     }
                     else if (positionX < closestUnitX && positionY > closestUnitY)
                     {
                         nextPositionX = closestUnitX - (positionX + 1);
                         nextPositionY = positionY;
                         if (fm.arrayMap[nextPositionX,nextPositionY].Name == "E")
                         {
                             positionX = nextPositionX;
                             positionY = nextPositionY;
                         }
                     }
                     else if (positionX > closestUnitX && positionY < closestUnitY)
                     {
                         nextPositionX = positionX - 1;
                         nextPositionY = closestUnitY - (positionY + 1);
                         if (fm.arrayMap[nextPositionX,nextPositionY].Name == "E")
                         {
                             positionX = nextPositionX;
                             positionY = nextPositionY;
                         }
                     }
                 }
              } 
        }

        public override void combat()
        {
            /*
            *   if (combat)
           {
               isRange(this.unitsList);
           }
           else
           {
               combat = true;
               isRange(this.unitsList);
           }

           /*Random random = new Random();
           int randomNumber;

           while (this.health <= 0 && health <= 0)
           {
               randomNumber = random.Next(0, 2);
               if(randomNumber == 0)
               {
                   this.health -= attack;
               }
               else
               {
                   health -= this.attack;
               }
           }*/
        }

        public override void isRange()
        {
            //implement search diagonal pitagoras. Internet is my friend.

            /* for (int i = 1; i <= this.attackRange; i++)
             {
                 //front
                 if(map[this.positionX][this.PositionY + i] != null)
                 {
                     return true;
                 }
                 //left
                 if (map[this.positionX - i][this.positionY] != null)
                 {
                     return true;
                 }
                 //back
                 if (map[this.positionX][this.positionY - i] != null)
                 {
                     return true;
                 }
                 //right
                 if (map[this.positionX + i][this.positionY] != null)
                 {
                     return true;
                 }
             }*/
        }

        public override void returnUnit()
        {

        }

        public override void isDead()
        {
           
        }

        public override string ToString()
        {
            string str = "Team:" + TeamName + Environment.NewLine + "Health: " + health + Environment.NewLine + "Attack:" + attack + Environment.NewLine + "Speed:" + speed + Environment.NewLine + "Range:" + attackRange;
            return str;
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class TankUnit : Unit
    {
        int distance = 100;
        protected int closestUnitX;
        protected int closestUnitY;

        public TankUnit(Form1 fm)
        {
            this.fm = fm;
            name = "Tank Unit";
            health = 100;
            TeamName = "Mega bot";
            attack = 2;
            speed = 1;
            attackRange = 2;
        }

        public TankUnit()
        {
        }

        public override void getClosestUnit()
        {
            base.getClosestUnit();
        }

        public override void move()
        {
            if (health > health * 0.25)
            {
                if (positionY == closestUnitY)
                {
                    if (positionX < closestUnitX)
                    {
                        nextPositionX = closestUnitX - (positionX + 1);
                        if (fm.arrayMap[nextPositionX, positionY].Name == "E")
                        {
                            positionX = nextPositionX;
                        }
                    }
                    else if (positionX > closestUnitX)
                    {
                        nextPositionX = positionX - 1;
                        if (fm.arrayMap[nextPositionX, positionY].Name == "E")
                        {
                            positionX = nextPositionX;
                        }
                    }
                }
                else if (positionX == closestUnitX)
                {
                    if (positionY < closestUnitY)
                    {
                        nextPositionY = closestUnitY - (closestUnitY - 1);
                        if (fm.arrayMap[positionX, nextPositionY].Name == "E")
                        {
                            positionY = nextPositionY;
                        }
                    }
                    else if (positionY > closestUnitY)
                    {
                        nextPositionY = positionY - 1;
                        if (fm.arrayMap[positionX, nextPositionY].Name == "E")
                        {
                            positionY = nextPositionY;
                        }
                    }
                    else if (positionX == closestUnitX && positionY == closestUnitY)
                    {
                        if (positionX < closestUnitX && positionY < closestUnitY)
                        {
                            nextPositionX = closestUnitX - (positionX + 1);
                            nextPositionY = closestUnitY - (positionY + 1);
                            if (fm.arrayMap[nextPositionX, nextPositionY].Name == "E")
                            {
                                positionX = nextPositionX;
                                positionY = nextPositionY;
                            }
                        }
                        else if (positionX > closestUnitX && positionY > closestUnitY)
                        {
                            nextPositionX = positionX - 1;
                            nextPositionY = positionY - 1;
                            if (fm.arrayMap[nextPositionX, nextPositionY].Name == "E")
                            {
                                positionX = nextPositionX;
                                positionY = nextPositionY;
                            }
                        }
                    }
                    else if (positionX < closestUnitX && positionY > closestUnitY)
                    {
                        nextPositionX = closestUnitX - (positionX + 1);
                        nextPositionY = positionY;
                        if (fm.arrayMap[nextPositionX, nextPositionY].Name == "E")
                        {
                            positionX = nextPositionX;
                            positionY = nextPositionY;
                        }
                    }
                    else if (positionX > closestUnitX && positionY < closestUnitY)
                    {
                        nextPositionX = positionX - 1;
                        nextPositionY = closestUnitY - (positionY + 1);
                        if (fm.arrayMap[nextPositionX, nextPositionY].Name == "E")
                        {
                            positionX = nextPositionX;
                            positionY = nextPositionY;
                        }
                    }
                }
            }
        }

        public override void combat()
        {
            /*
             *   if (combat)
            {
                isRange(this.unitsList);
            }
            else
            {
                combat = true;
                isRange(this.unitsList);
            }

            /*Random random = new Random();
            int randomNumber;

            while (this.health <= 0 && health <= 0)
            {
                randomNumber = random.Next(0, 2);
                if(randomNumber == 0)
                {
                    this.health -= attack;
                }
                else
                {
                    health -= this.attack;
                }
            }*/
        }

        public override void isRange()
        {
            //implement search diagonal pitagoras. Internet is my friend.

            /* for (int i = 1; i <= this.attackRange; i++)
             {
                 //front
                 if(map[this.positionX][this.PositionY + i] != null)
                 {
                     return true;
                 }
                 //left
                 if (map[this.positionX - i][this.positionY] != null)
                 {
                     return true;
                 }
                 //back
                 if (map[this.positionX][this.positionY - i] != null)
                 {
                     return true;
                 }
                 //right
                 if (map[this.positionX + i][this.positionY] != null)
                 {
                     return true;
                 }
             }*/
        }

        public override void returnUnit()
        {

        }

        public override void isDead()
        {

        }

        public override string ToString()
        {
            string str = "Team:" + TeamName + Environment.NewLine + "Health: " + health + Environment.NewLine + "Attack:" + attack + Environment.NewLine + "Speed:" + speed + Environment.NewLine + "Range:" + attackRange;
            return str;
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class RogueUnit : Unit
    {
        Form1 fm;
        int distance = 100;
        protected int closestUnitX;
        protected int closestUnitY;

        public RogueUnit(Form1 fm)
        {
            this.fm = fm;
            name = "Rogue Unit";
            health = 100;
            TeamName = "Mili-bot";
            attack = 3;
            speed = 2;
            attackRange = 4;
        }

        public RogueUnit()
        {
        }

        public override void getClosestUnit()
        {
            base.getClosestUnit();
        }

        public override void move()
        {
            if (health > health * 0.25)
            {
                if (positionY == closestUnitY)
                {
                    if (positionX < closestUnitX)
                    {
                        nextPositionX = closestUnitX - (positionX + 1);
                        if (fm.arrayMap[nextPositionX, positionY].Name == "E")
                        {
                            positionX = nextPositionX;
                        }
                    }
                    else if (positionX > closestUnitX)
                    {
                        nextPositionX = positionX - 1;
                        if (fm.arrayMap[nextPositionX, positionY].Name == "E")
                        {
                            positionX = nextPositionX;
                        }
                    }
                }
                else if (positionX == closestUnitX)
                {
                    if (positionY < closestUnitY)
                    {
                        nextPositionY = closestUnitY - (closestUnitY - 1);
                        if (fm.arrayMap[positionX, nextPositionY].Name == "E")
                        {
                            positionY = nextPositionY;
                        }
                    }
                    else if (positionY > closestUnitY)
                    {
                        nextPositionY = positionY - 1;
                        if (fm.arrayMap[positionX, nextPositionY].Name == "E")
                        {
                            positionY = nextPositionY;
                        }
                    }
                    else if (positionX == closestUnitX && positionY == closestUnitY)
                    {
                        if (positionX < closestUnitX && positionY < closestUnitY)
                        {
                            nextPositionX = closestUnitX - (positionX + 1);
                            nextPositionY = closestUnitY - (positionY + 1);
                            if (fm.arrayMap[nextPositionX, nextPositionY].Name == "E")
                            {
                                positionX = nextPositionX;
                                positionY = nextPositionY;
                            }
                        }
                        else if (positionX > closestUnitX && positionY > closestUnitY)
                        {
                            nextPositionX = positionX - 1;
                            nextPositionY = positionY - 1;
                            if (fm.arrayMap[nextPositionX, nextPositionY].Name == "E")
                            {
                                positionX = nextPositionX;
                                positionY = nextPositionY;
                            }
                        }
                    }
                    else if (positionX < closestUnitX && positionY > closestUnitY)
                    {
                        nextPositionX = closestUnitX - (positionX + 1);
                        nextPositionY = positionY;
                        if (fm.arrayMap[nextPositionX, nextPositionY].Name == "E")
                        {
                            positionX = nextPositionX;
                            positionY = nextPositionY;
                        }
                    }
                    else if (positionX > closestUnitX && positionY < closestUnitY)
                    {
                        nextPositionX = positionX - 1;
                        nextPositionY = closestUnitY - (positionY + 1);
                        if (fm.arrayMap[nextPositionX, nextPositionY].Name == "E")
                        {
                            positionX = nextPositionX;
                            positionY = nextPositionY;
                        }
                    }
                }
            }
        }

        public override void combat()
        {
            /*
             *   if (combat)
            {
                isRange(this.unitsList);
            }
            else
            {
                combat = true;
                isRange(this.unitsList);
            }

            /*Random random = new Random();
            int randomNumber;

            while (this.health <= 0 && health <= 0)
            {
                randomNumber = random.Next(0, 2);
                if(randomNumber == 0)
                {
                    this.health -= attack;
                }
                else
                {
                    health -= this.attack;
                }
            }*/
        }

        public override void isRange()
        {
            //implement search diagonal pitagoras. Internet is my friend.

            /* for (int i = 1; i <= this.attackRange; i++)
             {
                 //front
                 if(map[this.positionX][this.PositionY + i] != null)
                 {
                     return true;
                 }
                 //left
                 if (map[this.positionX - i][this.positionY] != null)
                 {
                     return true;
                 }
                 //back
                 if (map[this.positionX][this.positionY - i] != null)
                 {
                     return true;
                 }
                 //right
                 if (map[this.positionX + i][this.positionY] != null)
                 {
                     return true;
                 }
             }*/
        }

        public override void returnUnit()
        {

        }

        public override void isDead()
        {

        }

        public override string ToString()
        {
            string str = "Team:" + TeamName + Environment.NewLine + "Health: " + health + Environment.NewLine + "Attack:" + attack + Environment.NewLine + "Speed:" + speed + Environment.NewLine + "Range:" + attackRange;
            return str;
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class NeutralUnit : Unit
    {
        Form1 fm;
        int distance = 100;
        protected int closestUnitX;
        protected int closestUnitY;

        public NeutralUnit(Form1 fm)
        {
            this.fm = fm;
            name = "Neutral Unit";
            health = 80;
            TeamName = "Hunters";
            attack = 2;
            speed = 2;
            attackRange = 2;
        }

        public NeutralUnit()
        {
        }

        public override void getClosestUnit()
        {
            base.getClosestUnit();
        }

        public override void move()
        {
            if (health > health * 0.25)
            {
                if (positionY == closestUnitY)
                {
                    if (positionX < closestUnitX)
                    {
                        nextPositionX = closestUnitX - (positionX + 1);
                        if (fm.arrayMap[nextPositionX, positionY].Name == "E")
                        {
                            positionX = nextPositionX;
                        }
                    }
                    else if (positionX > closestUnitX)
                    {
                        nextPositionX = positionX - 1;
                        if (fm.arrayMap[nextPositionX, positionY].Name == "E")
                        {
                            positionX = nextPositionX;
                        }
                    }
                }
                else if (positionX == closestUnitX)
                {
                    if (positionY < closestUnitY)
                    {
                        nextPositionY = closestUnitY - (closestUnitY - 1);
                        if (fm.arrayMap[positionX, nextPositionY].Name == "E")
                        {
                            positionY = nextPositionY;
                        }
                    }
                    else if (positionY > closestUnitY)
                    {
                        nextPositionY = positionY - 1;
                        if (fm.arrayMap[positionX, nextPositionY].Name == "E")
                        {
                            positionY = nextPositionY;
                        }
                    }
                    else if (positionX == closestUnitX && positionY == closestUnitY)
                    {
                        if (positionX < closestUnitX && positionY < closestUnitY)
                        {
                            nextPositionX = closestUnitX - (positionX + 1);
                            nextPositionY = closestUnitY - (positionY + 1);
                            if (fm.arrayMap[nextPositionX, nextPositionY].Name == "E")
                            {
                                positionX = nextPositionX;
                                positionY = nextPositionY;
                            }
                        }
                        else if (positionX > closestUnitX && positionY > closestUnitY)
                        {
                            nextPositionX = positionX - 1;
                            nextPositionY = positionY - 1;
                            if (fm.arrayMap[nextPositionX, nextPositionY].Name == "E")
                            {
                                positionX = nextPositionX;
                                positionY = nextPositionY;
                            }
                        }
                    }
                    else if (positionX < closestUnitX && positionY > closestUnitY)
                    {
                        nextPositionX = closestUnitX - (positionX + 1);
                        nextPositionY = positionY;
                        if (fm.arrayMap[nextPositionX, nextPositionY].Name == "E")
                        {
                            positionX = nextPositionX;
                            positionY = nextPositionY;
                        }
                    }
                    else if (positionX > closestUnitX && positionY < closestUnitY)
                    {
                        nextPositionX = positionX - 1;
                        nextPositionY = closestUnitY - (positionY + 1);
                        if (fm.arrayMap[nextPositionX, nextPositionY].Name == "E")
                        {
                            positionX = nextPositionX;
                            positionY = nextPositionY;
                        }
                    }
                }
            }
        }

        public override void combat()
        {
            /*
             *   if (combat)
            {
                isRange(this.unitsList);
            }
            else
            {
                combat = true;
                isRange(this.unitsList);
            }

            /*Random random = new Random();
            int randomNumber;

            while (this.health <= 0 && health <= 0)
            {
                randomNumber = random.Next(0, 2);
                if(randomNumber == 0)
                {
                    this.health -= attack;
                }
                else
                {
                    health -= this.attack;
                }
            }*/
        }

        public override void isRange()
        {
            //implement search diagonal pitagoras. Internet is my friend.

            /* for (int i = 1; i <= this.attackRange; i++)
             {
                 //front
                 if(map[this.positionX][this.PositionY + i] != null)
                 {
                     return true;
                 }
                 //left
                 if (map[this.positionX - i][this.positionY] != null)
                 {
                     return true;
                 }
                 //back
                 if (map[this.positionX][this.positionY - i] != null)
                 {
                     return true;
                 }
                 //right
                 if (map[this.positionX + i][this.positionY] != null)
                 {
                     return true;
                 }
             }*/
        }

        public override void returnUnit()
        {

        }

        public override void isDead()
        {

        }

        public override string ToString()
        {
            string str = "Team:" + TeamName + Environment.NewLine + "Health: " + health + Environment.NewLine + "Attack:" + attack + Environment.NewLine + "Speed:" + speed + Environment.NewLine + "Range:" + attackRange;
            return str;
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class Buildings
    {
        public int positionX { get; set; }
        public int positionY { get; set; }
        public int health { get; set; }
        public int team { get; set; }
        public char image { get; set; }
        public string name { get; set; }

        public Buildings()
        {
          
        }

        public virtual void death()
        {
            /* if ( health == 0)
             {
               building.Clear();
             }

             else
             {
               
             }
            */
        }

        public virtual string ToString()
        {
            return " ";
        }

        public abstract void Save();
    }

    public class ResourceBuilding : Buildings
    {
        Form1 fm;

        private string resourceType;
        private int resourcePerTick = 0;
        private int resourceRemaining1 = 0;
        private int resourceRemaining2 = 0;
        private int i = 1;

        public int ResourcePerTick
        {
            get { return resourcePerTick; }
            set { resourcePerTick = value; }
        }

        public int I
        {
            get { return i; }
            set { i = value; }
        }

        public ResourceBuilding(Form1 fm)
        {
            this.fm = fm;
        }

        public ResourceBuilding()
        {
        }

        public override void death()
        {

        }

        public override string ToString()
        {
            string str = "Team:" + team + Environment.NewLine + "Health:" + health + Environment.NewLine + "Name:" + name;
            return str;
        }

        public void generateResources()
        {
            ResourcePerTick = (i++) * 5;
            fm.scrapCount_lbl.Text = String.Format("{0:00}", ResourcePerTick);
            fm.scrapCounter2_lbl.Text = String.Format("{0:00}", ResourcePerTick);
            fm.battery1_lbl.Text = String.Format("{0:00}", ResourcePerTick);
            fm.battery2_lbl.Text = String.Format("{0:00}", ResourcePerTick);
            fm.oil1_lbl.Text = String.Format("{0:00}", ResourcePerTick);
            fm.oil2_lbl.Text = String.Format("{0:00}", ResourcePerTick);
        }
      
        public void removeResource()
        {
            if (ResourcePerTick == 5)
            {
                //remove resources. Unit purchased.
            }
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class FactoryBuilding : Buildings
    {
        protected int positionX { get; set; }
        protected int positionY { get; set; }
        private int unitsProduce { get; set; }
        private int ticksPerProduction { get; set; }
        private int spawnPoint { get; set; }

        public FactoryBuilding()
        {
            health = 100;
        }
        public override void death()
        {

        }

        public override string ToString()
        {
            string str = "Team:" + team + Environment.NewLine + "Health:" + health + Environment.NewLine + "Name: Factory Building" + name;
            return str;
        }

        public void spawnUnits()
        {

        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class HuntersBuilding : Buildings
    {
        protected int positionX { get; set; }
        protected int positionY { get; set; }
        private int unitsProduce { get; set; }
        private int ticksPerProduction { get; set; }
        private int spawnPoint { get; set; }

        public override void death()
        {

        }

        public override string ToString()
        {
            string str = "Team:" + team + Environment.NewLine + "Health:" + health + Environment.NewLine + "Name:" + name;
            return str;
        }

        public void spawnUnits()
        {

        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class Building : Unit
    {
        public Building()
        {

        }
        public override void Save()
        {
            throw new NotImplementedException();
        }
    }
   
    public class Map
    {
        public void randomMap()
        {

        }

        public void movePosition()
        {
          
        }

        public void updatePosition()
        {

        }

        public void read()
        {

        }
    }

    public class GameEngine 
    {
        Form1 fm;

        public ResourceBuilding ResourceB
        {
            get; set;
        }

        public GameEngine(Form1 fm)
        {
            this.fm = fm;
            ResourceB = new ResourceBuilding(fm);
        }

    }
}