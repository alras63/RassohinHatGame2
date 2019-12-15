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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace RassohinHatGame
{
    public partial class adminFormData : Form
    {
        public int Secundes { get; set; }
        public int Minutes { get; set; }

        List<Team> TeamList = new List<Team>();
        List<Word> WordList = new List<Word>();
        public adminFormData()
        {
            InitializeComponent();

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



        }

        private void SetTimerSettingsBTN_Click(object sender, EventArgs e)
        {
            string secundesStr = secTB.Text;
            string minutesStr = minTB.Text;
         

            if(int.TryParse(secundesStr, out int secundes) && int.TryParse(minutesStr, out int minutes))
            {

                Secundes = secundes;
                Minutes = minutes;
                timerLabel.Text = String.Format("{0}:{1}", Minutes, Secundes);

       
            }
            else
            {
                MessageBox.Show("Ошибка, введите числа", "Не числа", MessageBoxButtons.OK, MessageBoxIcon.Error);



                
            }
        }

        private void SetTeamBTN_Click(object sender, EventArgs e)
        {
        
            bool contained = false;
            
            if(!String.IsNullOrEmpty(teamNameInput.Text))
            {
                foreach(var teamEl in TeamList)
                {
                    if (teamEl.Name == teamNameInput.Text)
                    {
                        contained = true;
                        MessageBox.Show(String.Format("Команда {0} была добавлено ранее", teamNameInput.Text), "Повторение", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        
                    }
                   
                    
                }

                if (contained == false)
                {
                    TeamList.Add(new Team { Name = teamNameInput.Text });
                    teamNameInput.Clear();
                }
            }
            
    
            teamDGV.DataSource = new BindingSource(TeamList, null);
        }

        private void AddWordBTN_Click(object sender, EventArgs e)
        {
            bool contained = false;

            if (!String.IsNullOrEmpty(wordInput.Text))
            {
                foreach (var wordEl in WordList)
                {
                    if (wordEl.Name == wordInput.Text)
                    {
                        contained = true;
                        MessageBox.Show(String.Format("Слово {0} было добавлено ранее", wordInput.Text), "Повторение", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }


                }

                if (contained == false)
                {
                    WordList.Add(new Word { Name = wordInput.Text });
                    wordInput.Clear();
                }
            }


            wordDGV.DataSource = new BindingSource(WordList, null);
        }

        private void SaveExitBTN_Click(object sender, EventArgs e)
        {
            if(TeamList.Count >= 2 && WordList.Count >= 2 && (Minutes > 0 || Secundes >= 20))
            {
                var teams = new Team();
                var path = @"data.xml";
                XDocument xdoc;
                if (File.Exists(path))
                {
                    xdoc = XDocument.Load(path);

                }
                else
                {
                    xdoc = new XDocument(new XElement("settings"));
                } 

                var teamsElement = xdoc.Element("settings").Element("Teams");
                if(teamsElement != null)
                {
                    teamsElement.RemoveAll();

                } else
                {
                   
                    xdoc.Root.Add(new XElement("Teams"));
                    teamsElement = xdoc.Element("settings").Element("Teams");
                }
                teamsElement.Add(TeamList.Select(el => new XElement("teamItem", new XElement("Name", el.Name), new XElement("Score", el.Score))));

                var wordsElement = xdoc.Element("settings").Element("Words");

                if(wordsElement != null)
                {
                    wordsElement.RemoveAll();

                }
                else
                {
                    xdoc.Root.Add(new XElement("Words"));
                    wordsElement = xdoc.Element("settings").Element("Words");

                }
                wordsElement.Add(WordList.Select(el => new XElement("wordItem", new XElement("Name", el.Name))));

                var timerElement = xdoc.Element("settings").Element("Timer");

                if(timerElement != null)
                {
                    timerElement.RemoveAll();

                } else
                {
                    xdoc.Root.Add(new XElement("Timer"));
                    timerElement = xdoc.Element("settings").Element("Timer");
                }
                timerElement.Add(new XElement("Secundes", Secundes), new XElement("Minutes", Minutes));

                //    xdoc.Root.Add(teamsElement);
                xdoc.Save(@"data.xml");

                this.Close();
            } else
            {
                MessageBox.Show("Перепроверьте настройки: слов и команд должно быть не меньше 2, а времени не меньше 20 секунд", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void resetTeam_Click(object sender, EventArgs e)
        {
            TeamList.Clear();
            adminDataRefresh();
        }

        private void resetWord_Click(object sender, EventArgs e)
        {
            WordList.Clear();
            adminDataRefresh();

        }

        private void adminDataRefresh()
        {
            teamDGV.DataSource = new BindingSource(TeamList, null);
            wordDGV.DataSource = new BindingSource(WordList, null);
            minTB.Text = Minutes.ToString();
            secTB.Text = Secundes.ToString();
            timerLabel.Text = String.Format("{0}:{1}", Minutes, Secundes);
        }
    }
}
