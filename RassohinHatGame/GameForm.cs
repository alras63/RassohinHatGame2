using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RassohinHatGame
{
    struct Timer
    {
        public int secundes;
        public int minutes;



        public void timerFunc()
        {

            if (secundes > 0)
            {
                secundes--;
            }
            else if (minutes > 0)
            {

                secundes = 59;
                minutes--;
            }
            else
            {
                secundes = 0;
                minutes = 0;
            }
        }
    }
    public partial class GameForm : Form
    {
        public int Secundes { get; set; }
        public int Minutes { get; set; }

        List<Team> TeamList = new List<Team>();
        List<Word> WordList = new List<Word>();

        int activeTeam = 0;

        string activeWord;

        Timer timer = new Timer();
      

        public GameForm()
        {
            InitializeComponent();
            gameoverGB.Visible = false;
            wordToGameGB.Visible = false;
            gameGB.Visible = false;
            var path = @"data.xml";
            XDocument xdoc;
            if (File.Exists(path))
            {
                xdoc = XDocument.Load(path);
                var teamsElement = xdoc.Element("settings").Element("Teams");


                var wordsElement = xdoc.Element("settings").Element("Words");


                var timerElement = xdoc.Element("settings").Elements("Timer");

                List<Team> list = new List<Team>();

                var els = xdoc.Root.Elements("Teams").Elements("teamItem").Select(element => new Team() { Name = element.Element("Name").Value, Score = int.Parse(element.Element("Score").Value) });
                foreach (var obj in els)
                {
                    list.Add(obj);
                }

                TeamList = list;


                List<Word> listW = new List<Word>();

                var elsW = xdoc.Root.Elements("Words").Elements("wordItem").Select(element => new Word() { Name = element.Element("Name").Value });
                foreach (var objW in elsW)
                {
                    listW.Add(objW);
                }

                WordList = listW;


                Minutes = int.Parse(xdoc.Root.Element("Timer").Element("Minutes").Value);
                Secundes = int.Parse(xdoc.Root.Element("Timer").Element("Secundes").Value);

                adminDataRefresh();

            }

            gameProcess();
       
            timer.minutes = Minutes;
            timer.secundes = Secundes;
        }
        private void adminDataRefresh()
        {
  
            timerLabel.Text = String.Format("{0}:{1}", Minutes, Secundes);
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }



        private void gameProcess()
        {
            Random rnd = new Random();
            if (TeamList.Count > activeTeam)
            {
                teamName.Text = TeamList[activeTeam].Name;
                if (WordList.Count > 0)
                {
                    var wordIndex = rnd.Next(WordList.Count);
                    wordToPlayer.Text = WordList[wordIndex].Name;
                    activeWord = WordList[wordIndex].Name;
                    WordList.RemoveAt(wordIndex);
                    var sourse = new BindingSource(WordList, null);
                    
                    MessageBox.Show(String.Format("К экрану приглашается человек из команды {0}, который будет описывать слово!", teamName.Text), "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    wordToGameGB.Visible = true;
                }
                else
                {
                    gameOver();
                }




            }
            else
            {
                gameOver();
            }

        }

        private void gameOver()
        {
           
           
         
            wordToGameGB.Visible = false;
            TeamList.Sort((b, a) => a.Score.CompareTo(b.Score));
            MainTImer.Stop();
            gameGB.Visible = false;
            wordToGameGB.Visible = false;
            gameoverGB.Visible = true;
            teamsDGV.DataSource = new BindingSource(TeamList, null);
            winTeam.Text = TeamList[0].Name;





        }



        private void MainTimer_Tick(object sender, EventArgs e)
        {

            
            //Раз в секунду будет выводиться такой текст (с текущим временем) 
            timerLabel.Text = string.Format("{0}:{1}", timer.minutes, timer.secundes);
            timer.timerFunc();
            currentScore.Text = TeamList[activeTeam].Score.ToString();
            if (timer.minutes == 0 && timer.secundes == 0)
            {
                MainTImer.Stop();
             //   inputGB.Visible = false;
                MessageBox.Show("Время закончилось!", "Таймер!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                activeTeam++;
                timer.minutes = Minutes;
                timer.secundes = Secundes;
                WordList.Add(new Word() { Name = activeWord });
                
                gameProcess();
            }
        }

        private void GameoverGB_Enter(object sender, EventArgs e)
        {

        }

        private void HideWord_Click_Click(object sender, EventArgs e)
        {
            wordToGameGB.Visible = false;
            gameGB.Visible = true;
            MainTImer.Enabled = true;
        }

        private void TryButton_Click(object sender, EventArgs e)
        {
            if (tryWordInput.Text == activeWord)
            {
                TeamList[activeTeam].Score++;
               
                MainTImer.Stop();
                gameGB.Visible = false;
                MessageBox.Show("Вы угадали!", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentScore.Text = TeamList[activeTeam].Score.ToString();

                gameProcess();

            }
            else
            {
                MessageBox.Show("Вы не угадали!", "Неверно", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tryWordInput.Clear();

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
