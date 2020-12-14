using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GameStrategy.Controller;
using GameStrategy.Models;
using GameStrategy.Models.ArmyUnit;
using GameStrategy.Models.Buildings;

namespace GameStrategy
{
    public partial class Form1 : Form
    {
        private Battlefield _battlefield;
        private Bot _bot;
        private Bot _bot2;
        private Bot _bot3;
        private Castle _castle;
        private Castle _enemyCastle1;
        private Castle _enemyCastle2;
        private Castle _enemyCastle3;
        private int _mousePositionClickX;
        private int _mousePositionClickY;
        private PlayerKnight _player;
        private int _startValue;
        private Villages _village;

        public Form1()
        {
            InitializeComponent();
            pictureBoxMap.Controls.Add(pictureGameObject);
            pictureGameObject.Location = new Point(0, 0);
            pictureGameObject.BackColor = Color.Transparent;
            MapController.Init();
            new CameraController(panel1);
            timer1.Interval = 10;
            timer1.Tick += Update;
            timer2.Tick += UpdateGameObject;
            Init();
        }

       

        public void Init()
        {
            pictureBoxCastle.Image =
                new Bitmap(Path.Combine(
                    new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                    "Sprites\\background.png"));
            pictureBox2.Image =
                new Bitmap(Path.Combine(
                    new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                    "Sprites\\background_color.png"));
            _castle = new Castle(4, 5);
            MapController.SetObject(_castle.posX, _castle.posY);
            _player = new PlayerKnight(3, 2, _castle);
            MapController.SetObject(_player.posX, _player.posY);
            _enemyCastle1 = new Castle(15, 17);
            _enemyCastle2 = new Castle(10, 25);
            _enemyCastle3 = new Castle(20, 10);

            _bot = new Bot(14, 19, "Builder", _enemyCastle1, new Army());
            _bot2 = new Bot(9, 24, "Builder", _enemyCastle2, new Army());
            _bot3 = new Bot(19, 9, "Builder", _enemyCastle3, new Army());
            _village = new Villages(MapController.cellSize * 14, MapController.cellSize * 6);
            timer1.Start();
        }

        public void Update(object sender, EventArgs e)
        {
            labelCountCoin.Text = _castle.Coins.ToString();
            labelCountPeople.Text = _castle.People.ToString();
            labelDay.Text = _player.Day.ToString();
            pictureBoxMap.Refresh();
        }
        private void UpdateGameObject(object sender, EventArgs e)
        {
            if (_startValue != 0)
            {
                //labelTime.Text = Int2StringTime(startValue);
                _startValue--;
            }
            else
            {
                pictureGameObject.Refresh();
                (sender as Timer).Stop();
                (sender as Timer).Dispose();
                MessageBox.Show("You can attack!");
            }
        }
        private string Int2StringTime(int time)
        {
            var hours = (time - time % (60 * 60)) / (60 * 60);
            var minutes = (time - time % 60) / 60 - hours * 60;
            var seconds = time - hours * 60 * 60 - minutes * 60;
            return string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        }
        private void pictureBoxMap_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            MapController.DrawMap(g, _castle);
            _player.Castle.Draw(g);
            _bot.Castle.Draw(g);
            _bot2.Castle.Draw(g);
            _bot3.Castle.Draw(g);
            g.DrawImage(_village.sprite,
                new Rectangle(new Point(_village.posX, _village.posY),
                    new Size(_village.spriteWith, _village.spriteHeight)), 0,
                0, _village.spriteWith, _village.spriteHeight, GraphicsUnit.Pixel);
            if (_mousePositionClickY != 0 && _mousePositionClickX != 0)
                MapController.DrawBorderCellOnClick(_mousePositionClickX, _mousePositionClickY, g);
        }
        private void pictureGameObject_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            _player.Draw(g);
            _bot.Draw(g);
            _bot2.Draw(g);
            _bot3.Draw(g);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxTask.Visible = false;
            pictureBoxCastle.Visible = false;
            button1.Visible = false;
            _castle.Interaction = false;
            pictureBoxMap.Visible = true;
            groupBoxInformCastle.Visible = false;
            buttonShowBuildings.Visible = false;
            buttonTask.Visible = false;
            buttonAttack.Visible = false;
            groupBoxArmyAttack.Visible = false;
            groupBoxArmy.Visible = false;
        }


       
        private void UpdateInformationBuildings()
        {
            //Update information about TownHall
            labelLevelBuildings.Text = _castle.TownHall.Level.ToString();
            labelCost.Text = _castle.TownHall.CostLevelUp.ToString();
            labelDescriptionBuildings.Text = _castle.TownHall.Description;
            //Update information about Temple
            labelLevelBuildings2.Text = _castle.Temple.Level.ToString();
            labelCost2.Text = _castle.Temple.CostLevelUp.ToString();
            labelDescriptionBuildings2.Text = _castle.Temple.Description;
            //Update information about Barracks

            labelLevelBuildings3.Text = _castle.Barracks.Level.ToString();
            labelCost3.Text = _castle.Barracks.CostLevelUp.ToString();
            labelDescriptionBuildings3.Text = _castle.Barracks.Description;
            //Update information about Houses

            labelLevelBuildings4.Text = _castle.Houses.Level.ToString();
            labelCost4.Text = _castle.Houses.CostLevelUp.ToString();
            labelDescriptionBuildings4.Text = _castle.Houses.Description;
            //Update information about Wall

            labelLevelBuildings5.Text = _castle.Walls.Level.ToString();
            labelCost5.Text = _castle.Walls.CostLevelUp.ToString();
            labelDescriptionBuildings5.Text = _castle.Walls.Description;
        }

        private void pictureBoxCastle_MouseClick(object sender, MouseEventArgs e)
        {
            var bitmap = (Bitmap) pictureBox2.Image;
            var pixel = bitmap.GetPixel(e.X, e.Y);
            if (pixel.R == 50)
            {
                tabPage.SelectedTab = tabPage1;
                labelLevelBuildings.Text = _castle.TownHall.Level.ToString();
                labelCost.Text = _castle.TownHall.CostLevelUp.ToString();
                if (_castle.TownHall.CanLevelUp) buttonLevelUp.Visible = true;

                _castle.TownHall.Interaction = true;
            }

            if (pixel.R == 100)
            {
                tabPage.SelectedTab = tabPage2;
                labelLevelBuildings.Text = _castle.Temple.Level.ToString();
                labelCost.Text = _castle.Temple.CostLevelUp.ToString();
                if (_castle.Temple.CanLevelUp) buttonLevelUp.Visible = true;
            }

            if (pixel.R == 150)
            {
                tabPage.SelectedTab = tabPage3;
                labelLevelBuildings.Text = _castle.Barracks.Level.ToString();
                labelCost.Text = _castle.Barracks.CostLevelUp.ToString();
                if (_castle.Barracks.CanLevelUp) buttonLevelUp.Visible = true;
            }

            if (pixel.R == 200)
            {
                tabPage.SelectedTab = tabPage4;
                labelLevelBuildings.Text = _castle.Houses.Level.ToString();
                labelCost.Text = _castle.Houses.CostLevelUp.ToString();
                if (_castle.Houses.CanLevelUp) buttonLevelUp.Visible = true;
            }

            if (pixel.R == 0)
            {
                tabPage.SelectedTab = tabPage5;
                labelLevelBuildings.Text = _castle.Walls.Level.ToString();
                labelCost.Text = _castle.Walls.CostLevelUp.ToString();
                if (_castle.Houses.CanLevelUp) buttonLevelUp.Visible = true;
            }
        }

        #region LevelUpBuildingsInCastle
        private void buttonLevelUp_Click(object sender, EventArgs e)
        {
            if (_castle.TownHall.CanLevelUp && _castle.Coins >= _castle.TownHall.CostLevelUp)
            {
                _castle.Coins -= _castle.TownHall.CostLevelUp;
                _castle.TownHall.LevelUp();
                _castle.People += _castle.TownHall.GetNewPeople(_castle.People);
                labelLevelBuildings.Text = _castle.TownHall.Level.ToString();
                labelCost.Text = _castle.TownHall.CostLevelUp.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_castle.Temple.CanLevelUp && _castle.Coins >= _castle.Temple.CostLevelUp)
            {
                _castle.Coins -= _castle.Temple.CostLevelUp;
                _castle.Temple.LevelUp();
                labelLevelBuildings2.Text = _castle.Temple.Level.ToString();
                labelCost2.Text = _castle.Temple.CostLevelUp.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_castle.Barracks.CanLevelUp && _castle.Coins >= _castle.Barracks.CostLevelUp)
            {
                _castle.Coins -= _castle.Barracks.CostLevelUp;
                _castle.Barracks.LevelUp();
                labelLevelBuildings3.Text = _castle.Barracks.Level.ToString();
                labelCost3.Text = _castle.Barracks.CostLevelUp.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_castle.Houses.CanLevelUp && _castle.Coins >= _castle.Houses.CostLevelUp)
            {
                _castle.Coins -= _castle.Houses.CostLevelUp;
                _castle.Houses.LevelUp();
                labelLevelBuildings4.Text = _castle.Houses.Level.ToString();
                labelCost4.Text = _castle.Houses.CostLevelUp.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_castle.Walls.CanLevelUp && _castle.Coins >= _castle.Walls.CostLevelUp)
            {
                _castle.Coins -= _castle.Walls.CostLevelUp;
                _castle.Walls.LevelUp();
                labelLevelBuildings5.Text = _castle.Walls.Level.ToString();
                labelCost5.Text = _castle.Walls.CostLevelUp.ToString();
            }
        }

        #endregion
        private void buttonShowBuildings_Click_1(object sender, EventArgs e)
        {
            groupBoxInformCastle.Visible = true;
            groupBoxArmy.Visible = false;
            groupBoxTask.Visible = false;
        }

        private void buttonShowArmy_Click(object sender, EventArgs e)
        {
            groupBoxTask.Visible = false;
            groupBoxArmy.Visible = true;
            groupBoxArmyAttack.Visible = false;
            labelCavalry.Text = _castle.ArmyInCastle.Cavalries.Count.ToString();
            labelRecruit.Text = _castle.ArmyInCastle.Recruits.Count.ToString();
            labelInfantryman.Text = _castle.ArmyInCastle.Infantrymen.Count.ToString();
            labelShooter.Text = _castle.ArmyInCastle.Shooters.Count.ToString();
            labelInfantrymanCost.Text = Infantryman.Cost.ToString();
            labelRecruitCost.Text = Recruit.Cost.ToString();
            labelShooterCost.Text = Shooter.Cost.ToString();
            labelCavalryCost.Text = Cavalry.Cost.ToString();
            labelRecruitInform.Text = Recruit.Description;
            label36.Text = Infantryman.Description;
            label37.Text = Cavalry.Description;
            label38.Text = Shooter.Description;
        }

        #region AddArmyInCastle

        
        private void buttonAddRecruit_Click(object sender, EventArgs e)
        {
            labelError.Text = "";

            try
            {
                var count = int.Parse(textBoxRecruit.Text);
                if (_castle.Coins >= Recruit.Cost * count)
                {
                    _castle.ArmyInCastle.AddRecruit(count);
                    labelRecruit.Text = _castle.ArmyInCastle.Recruits.Count.ToString();
                }
            }
            catch
            {
                labelError.Text = "Неправильные данные";
            }
        }


        private void buttonAddInfantryman_Click(object sender, EventArgs e)
        {
            labelError.Text = "";

            try
            {
                var count = int.Parse(textBoxInfantryman.Text);
                if (_castle.Coins >= Infantryman.Cost * count)
                {
                    _castle.ArmyInCastle.AddInfantryman(count);
                    labelInfantryman.Text = _castle.ArmyInCastle.Infantrymen.Count.ToString();
                }
            }
            catch
            {
                labelError.Text = "Неправильные данные";
            }
        }

        private void buttonAddShooter_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            try
            {
                var count = int.Parse(textBoxShooter.Text);

                if (_castle.Coins >= Shooter.Cost * count)
                {
                    _castle.ArmyInCastle.AddShooter(count);
                    labelShooter.Text = _castle.ArmyInCastle.Shooters.Count.ToString();
                }
            }
            catch
            {
                labelError.Text = "Неправильные данные";
            }
        }

        private void buttonAddCavalry_Click(object sender, EventArgs e)
        {
            labelError.Text = "";

            try
            {
                var count = int.Parse(textBoxCavalry.Text);

                if (_castle.Coins >= Cavalry.Cost * count)
                {
                    _castle.ArmyInCastle.AddCavalry(count);
                    labelCavalry.Text = _castle.ArmyInCastle.Cavalries.Count.ToString();
                }
            }
            catch
            {
                labelError.Text = "Неправильные данные";
            }
        }

        #endregion
        private void button6_Click(object sender, EventArgs e)
        {
            buttonTask3.Visible = true;
            buttonTask2.Visible = true;
            buttonTask1.Visible = true;
            _player.Day += 1;
            labelDay.Text = _player.Day.ToString();
            _castle.ArmyInCastle.ResetTimeTraining();
            labelTrainedRecruit.Text = _castle.ArmyInCastle.GetCountTrainedRecruit().ToString();
            label24.Text = _castle.ArmyInCastle.GetCountTrainedInfantrymen().ToString();
            label30.Text = _castle.ArmyInCastle.GetCountTrainedCavalries().ToString();
            label32.Text = _castle.ArmyInCastle.GetCountTrainedShooters().ToString();
            _bot.HireArmy();
            _bot.LevelUpCastle();
            _bot.Army.ResetTimeTraining();
            if (_player.Army.InBattleDay != 0)
            {
                _player.Army.InBattleDay -= 1;
            }
            else if (_player.Army.Earned != 0)
            {
                _castle.Coins += _player.Army.Earned;
                _castle.ArmyInCastle.AddInfantryman(_player.Army.Infantrymen.Count);
                _castle.ArmyInCastle.AddShooter(_player.Army.Shooters.Count);
                _castle.ArmyInCastle.AddCavalry(_player.Army.Cavalries.Count);
                _castle.ArmyInCastle.AddRecruit(_player.Army.Recruits.Count);
                _player.Army.RemoveAllArmy();
            }
        }

      


        private void pictureGameObject_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var posCursorX = e.X / MapController.cellSize;
            var posCursorY = e.Y / MapController.cellSize;
            if (posCursorX == _player.posX && posCursorY == _player.posY)
                _player.Interaction = !_player.Interaction;
            else
                _player.Interaction = false;
            if (posCursorX == _bot.posX && posCursorY == _bot.posY)
                _bot.Interaction = !_bot.Interaction;
            else
                _bot.Interaction = false;
            if (posCursorX == _bot2.posX && posCursorY == _bot2.posY)
                _bot2.Interaction = !_bot2.Interaction;
            else
                _bot2.Interaction = false;
            if (posCursorX == _bot3.posX && posCursorY == _bot3.posY)
                _bot3.Interaction = !_bot3.Interaction;
            else
                _bot3.Interaction = false;
            if (posCursorX == _castle.posX && posCursorY == _castle.posY) _castle.Interaction = !_castle.Interaction;

            if (posCursorX == _enemyCastle1.posX && posCursorY == _enemyCastle1.posY)
                _enemyCastle1.Interaction = !_enemyCastle1.Interaction;
            if (posCursorX == _enemyCastle2.posX && posCursorY == _enemyCastle2.posY)
                _enemyCastle2.Interaction = !_enemyCastle2.Interaction;
            if (posCursorX == _enemyCastle3.posX && posCursorY == _enemyCastle3.posY)
                _enemyCastle3.Interaction = !_enemyCastle3.Interaction;

            if (_bot.Interaction)
            {
                buttonAttack.Visible = true;
                button1.Visible = true;
                groupBoxArmyAttack.Visible = true;
                labelCavalryAttac.Text = _castle.ArmyInCastle.GetCountTrainedCavalries().ToString();
                labelRecruitAttac.Text = _castle.ArmyInCastle.GetCountTrainedRecruit().ToString();
                labelInfantrymanAttac.Text = _castle.ArmyInCastle.GetCountTrainedInfantrymen().ToString();
                labelShooterAttac.Text = _castle.ArmyInCastle.GetCountTrainedShooters().ToString();
                buttonAttack.Visible = true;
            }

            if (_bot2.Interaction)
            {
                buttonAttack.Visible = true;
                button1.Visible = true;
                groupBoxArmyAttack.Visible = true;
                labelCavalryAttac.Text = _castle.ArmyInCastle.GetCountTrainedCavalries().ToString();
                labelRecruitAttac.Text = _castle.ArmyInCastle.GetCountTrainedRecruit().ToString();
                labelInfantrymanAttac.Text = _castle.ArmyInCastle.GetCountTrainedInfantrymen().ToString();
                labelShooterAttac.Text = _castle.ArmyInCastle.GetCountTrainedShooters().ToString();
                buttonAttack.Visible = true;
            }
            if (_bot3.Interaction)
            {
                buttonAttack.Visible = true;
                button1.Visible = true;
                groupBoxArmyAttack.Visible = true;
                labelCavalryAttac.Text = _castle.ArmyInCastle.GetCountTrainedCavalries().ToString();
                labelRecruitAttac.Text = _castle.ArmyInCastle.GetCountTrainedRecruit().ToString();
                labelInfantrymanAttac.Text = _castle.ArmyInCastle.GetCountTrainedInfantrymen().ToString();
                labelShooterAttac.Text = _castle.ArmyInCastle.GetCountTrainedShooters().ToString();
                buttonAttack.Visible = true;
            }

            if (_enemyCastle1.Interaction)
            {
                buttonAttack.Visible = true;
                button1.Visible = true;
                groupBoxArmyAttack.Visible = true;
                groupBoxArmy.Visible = false;
                labelCavalryAttac.Text = _castle.ArmyInCastle.GetCountTrainedCavalries().ToString();
                labelRecruitAttac.Text = _castle.ArmyInCastle.GetCountTrainedRecruit().ToString();
                labelInfantrymanAttac.Text = _castle.ArmyInCastle.GetCountTrainedInfantrymen().ToString();
                labelShooterAttac.Text = _castle.ArmyInCastle.GetCountTrainedShooters().ToString();
                buttonAttack.Visible = true;
                buttonMove.Visible = false;
            }
            if (_enemyCastle2.Interaction)
            {
                buttonAttack.Visible = true;
                button1.Visible = true;
                groupBoxArmyAttack.Visible = true;
                groupBoxArmy.Visible = false;
                labelCavalryAttac.Text = _castle.ArmyInCastle.GetCountTrainedCavalries().ToString();
                labelRecruitAttac.Text = _castle.ArmyInCastle.GetCountTrainedRecruit().ToString();
                labelInfantrymanAttac.Text = _castle.ArmyInCastle.GetCountTrainedInfantrymen().ToString();
                labelShooterAttac.Text = _castle.ArmyInCastle.GetCountTrainedShooters().ToString();
                buttonAttack.Visible = true;
                buttonMove.Visible = false;
            }
            if (_enemyCastle3.Interaction)
            {
                buttonAttack.Visible = true;
                button1.Visible = true;
                groupBoxArmyAttack.Visible = true;
                groupBoxArmy.Visible = false;
                labelCavalryAttac.Text = _castle.ArmyInCastle.GetCountTrainedCavalries().ToString();
                labelRecruitAttac.Text = _castle.ArmyInCastle.GetCountTrainedRecruit().ToString();
                labelInfantrymanAttac.Text = _castle.ArmyInCastle.GetCountTrainedInfantrymen().ToString();
                labelShooterAttac.Text = _castle.ArmyInCastle.GetCountTrainedShooters().ToString();
                buttonAttack.Visible = true;
                buttonMove.Visible = false;
            }
            if (_castle.Interaction)
            {
                pictureBoxCastle.Visible = true;
                pictureBox2.Visible = true;
                pictureBoxMap.Visible = false;
                button1.Visible = true;
                _castle.Interaction = true;
                UpdateInformationBuildings();
                buttonShowBuildings.Visible = true;
                buttonTask.Visible = true;
            }

            if (_player.Interaction == false && _castle.Interaction == false && _bot.Interaction == false)
            {
                _mousePositionClickY = e.Y;
                _mousePositionClickX = e.X;
                MapController.Interaction = true;
            }
            else
            {
                _mousePositionClickY = 0;
                _mousePositionClickX = 0;
                MapController.Interaction = false;
            }
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            groupBoxTask.Visible = true;
            groupBoxArmyAttack.Visible = false;
            groupBoxArmy.Visible = false;
            groupBoxInformCastle.Visible = false;
            labelTask1.Text = _castle.tasks[0].Text + " Цена " + _castle.tasks[0].Cost + " Время " +
                              _castle.tasks[0].Time;
            labelTask2.Text = _castle.tasks[1].Text + " Цена " + _castle.tasks[0].Cost + " Время " +
                              _castle.tasks[1].Time;
            labelTask3.Text = _castle.tasks[2].Text + " Цена " + _castle.tasks[0].Cost + " Время " +
                              _castle.tasks[2].Time;
        }

      

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            if (_bot.Castle.Interaction || _bot.Interaction)
            {
                _player.Move(_bot.Castle.posX, _bot.Castle.posY);
                var countCellsToObject = _player.CountPositionToTarget * 2;
                _player.Army.InBattleDay = countCellsToObject;
                _battlefield = new Battlefield(_player.Army, _bot);
                _battlefield.Battle();
            }
        }

        #region AddArmyForAttack

      
        private void button13_Click(object sender, EventArgs e)
        {
            label21.Text = "";

            try
            {
                var count = int.Parse(textBox4.Text);
                if (_castle.ArmyInCastle.GetCountTrainedRecruit() >= count)
                {
                    _player.Army.AddRecruit(count);
                    _castle.ArmyInCastle.RemoveRecruit(count);
                    label18.Text = _player.Army.Recruits.Count.ToString();
                    labelRecruitAttac.Text = _castle.ArmyInCastle.Recruits.Count.ToString();
                }
            }
            catch
            {
                label21.Text = "Неправильные данные";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label21.Text = "";

            try
            {
                var count = int.Parse(textBox3.Text);
                if (_castle.ArmyInCastle.GetCountTrainedInfantrymen() >= count)
                {
                    _player.Army.AddInfantryman(count);
                    _castle.ArmyInCastle.RemoveInfantryman(count);
                    label17.Text = _player.Army.Infantrymen.Count.ToString();
                    labelInfantrymanAttac.Text = _castle.ArmyInCastle.Infantrymen.Count.ToString();
                }
            }
            catch
            {
                label21.Text = "Неправильные данные";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label21.Text = "";

            try
            {
                var count = int.Parse(textBox2.Text);
                if (_castle.ArmyInCastle.GetCountTrainedShooters() >= count)
                {
                    _player.Army.AddShooter(count);
                    _castle.ArmyInCastle.RemoveShooter(count);
                    label15.Text = _player.Army.Shooters.Count.ToString();
                    labelShooterAttac.Text = _castle.ArmyInCastle.Shooters.Count.ToString();
                }
            }
            catch
            {
                label21.Text = "Неправильные данные";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label21.Text = "";

            try
            {
                var count = int.Parse(textBox1.Text);
                if (_castle.ArmyInCastle.GetCountTrainedCavalries() >= count)
                {
                    _player.Army.AddCavalry(count);
                    _castle.ArmyInCastle.RemoveCavalry(count);
                    label13.Text = _battlefield.Army.Cavalries.Count.ToString();
                    labelCavalryAttac.Text = _castle.ArmyInCastle.Cavalries.Count.ToString();
                }
            }
            catch
            {
                label21.Text = "Неправильные данные";
            }
        }

        #endregion

        #region Task

        private void button8_Click(object sender, EventArgs e)
        {
            buttonTask3.Visible = false;
            buttonTask1.Visible = false;
            _castle.Coins += _castle.tasks[1].Cost;
            buttonTask2.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonTask2.Visible = false;
            buttonTask1.Visible = false;
            _castle.Coins += _castle.tasks[2].Cost;
            buttonTask3.Visible = false;

        }
        private void buttonTask1_Click(object sender, EventArgs e)
        {
            buttonTask3.Visible = false;
            buttonTask2.Visible = false;
            _castle.Coins += _castle.tasks[0].Cost;
            buttonTask1.Visible = false;
        }

        #endregion


        private void button9_Click(object sender, EventArgs e)
        {
            if (MapController.Interaction)
            {
                _player.Move(MapController.InteractionPosX, MapController.InteractionPosY);
                var countCellsToObject = _player.CountPositionToTarget;
                _startValue = 10 * countCellsToObject;
                //timer2.Start();
            }
        }
    }
}