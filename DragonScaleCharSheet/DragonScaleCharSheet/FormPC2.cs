using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DragonScaleCharSheet
{
    public partial class FormPC2 : Form
    {

        int baseLevel = 1;
        int level = 1;

        List<string> statsList = new List<string>();
        List<string> knowledgeList = new List<string>();
        List<string> sensesList = new List<string>();

        Dictionary<string, int> statsDictBase = new Dictionary<string, int>();
        Dictionary<string, int> knowledgeDictBase = new Dictionary<string, int>();
        Dictionary<string, int> sensesDictBase = new Dictionary<string, int>();

        Dictionary<string, int> statsDict = new Dictionary<string, int>();
        Dictionary<string, int> knowledgeDict = new Dictionary<string, int>();
        Dictionary<string, int> sensesDict = new Dictionary<string, int>();


        private void rollStats()
        {
            List<int> rollResults = new List<int>();
            Random rnd = new Random();

            int roll = rnd.Next(1, 9);
            rollResults.Add(roll);
            rollResults.Add(8 - roll);
            roll = rnd.Next(1, 9);
            rollResults.Add(roll);
            rollResults.Add(8 - roll);
            roll = rnd.Next(1, 11);
            rollResults.Add(roll);
            rollResults.Add(10 - roll);

            rollResults.Sort();
            rollResults.Reverse();
            Console.WriteLine(rollResults);

            for (int i = 0; i < 6; i++)
            {
                statsDictBase[statsList[i]] = rollResults[i] + 3;
                statsDict[statsList[i]] = rollResults[i] + 3;
            }
        }

        private void rollKnowledge()
        {
            List<int> rollResults = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                int roll = rnd.Next(1, 7);
                rollResults.Add(roll);
                rollResults.Add(6 - roll);
            }

            for (int i = 0; i < 6; i++)
            {
                knowledgeDictBase[knowledgeList[i]] = rollResults[i]+2;
                knowledgeDict[knowledgeList[i]] = rollResults[i]+2;
            }
        }

        private void rollSenses()
        {
            List<int> rollResults = new List<int>();
            Random rnd = new Random();

            int roll = rnd.Next(1, 9);
            rollResults.Add(roll);
            rollResults.Add(8 - roll);
            roll = rnd.Next(1, 9);
            rollResults.Add(roll);
            rollResults.Add(8 - roll);
            roll = rnd.Next(1, 11);
            rollResults.Add(roll);
            rollResults.Add(10 - roll);


            for (int i = 0; i < 5; i++)
            {
                sensesDictBase[sensesList[i]] = rollResults[i] + 3;
                sensesDict[sensesList[i]] = rollResults[i] + 3;
            }
        }

        private void calculateAll()
        {
            int Vit = statsDict["Witalność"];
            int Wil = statsDict["Wola"];
            int Agi = statsDict["Zwinność"];
            int Str = statsDict["Siła"];
            int Dex = statsDict["Zręczność"];
            int Int = statsDict["Inteligencja"];

            healthTextBox.Text = (Vit + 2).ToString() + " / " + Convert.ToInt16((Vit + 2) * (0.75)).ToString() + " / " + Convert.ToInt16((Vit + 2) / 2).ToString() + " / " + Convert.ToInt16((Vit + 2) / 4).ToString();
            strPowerTextBox.Text = (Str + 2).ToString() + " / " + Convert.ToInt16((Str + 2) * (0.75)).ToString() + " / " + Convert.ToInt16((Str + 2) / 2).ToString() + " / " + Convert.ToInt16((Str + 2) / 4).ToString();
            dexPowerTextBox.Text = (Dex + 2).ToString() + " / " + Convert.ToInt16((Dex + 2) * (0.75)).ToString() + " / " + Convert.ToInt16((Dex + 2) / 2).ToString() + " / " + Convert.ToInt16((Dex + 2) / 4).ToString();
            intPowerTextBox.Text = (Int + 2).ToString() + " / " + Convert.ToInt16((Int + 2) * (0.75)).ToString() + " / " + Convert.ToInt16((Int + 2) / 2).ToString() + " / " + Convert.ToInt16((Int + 2) / 4).ToString();

            magickaTextBox.Text = (Wil + 2).ToString();
            speedTextBox.Text = Convert.ToInt16(Agi / 2.5).ToString();
            unbreakTextBox.Text = Convert.ToInt16((Vit + Wil * 2) / 3).ToString();
            blockTextBox.Text = Convert.ToInt16(2 + (Dex * 2 + Str) / 3).ToString();
            dodgeTextBox.Text = Convert.ToInt16(2 + (Agi / 1.5)).ToString();
            accTextBox.Text = Convert.ToInt16(Dex * 0.66).ToString() + " / " + Convert.ToInt16((Wil+Int)/2).ToString();
            focusTextBox.Text = Convert.ToInt16(Wil / 4 + Int / 4).ToString();
            critTextBox.Text = ((Int / 5 + Dex / 6 + Str / 6) - 2).ToString() + " / " + ((Int / 5 + Dex / 6) - 1).ToString() + " / " + (Int / 4).ToString();


        }

        private void reset()
        {
            level = baseLevel;

            foreach(var x in statsDictBase)
            {
                statsDict[x.Key] = x.Value;
            }
            foreach(var x in knowledgeDictBase)
            {
                knowledgeDict[x.Key] = x.Value;
            }
            foreach(var x in sensesDictBase)
            {
                sensesDict[x.Key] = x.Value;
            }

            updateVit();
            updateWil();
            updateAgi();
            updateStr();
            updateDex();
            updateInt();

            geographyTextBox.Text = knowledgeDict["Geografia"].ToString();
            natureTextBox.Text = knowledgeDict["Natura"].ToString();
            magicTextBox.Text = knowledgeDict["Magia"].ToString();
            technicTextBox.Text = knowledgeDict["Technika"].ToString();
            religionTextBox.Text = knowledgeDict["Religia"].ToString();
            cultureTextBox.Text = knowledgeDict["Kultura"].ToString();

            sightTextBox.Text = sensesDict["Wzrok"].ToString();
            hearingTextBox.Text = sensesDict["Słuch"].ToString();
            tasteTextBox.Text = sensesDict["Smak"].ToString();
            touchTextBox.Text = sensesDict["Dotyk"].ToString();
            olfactionTextBox.Text = sensesDict["Węch"].ToString();
        }

        public FormPC2(List<string> statsB, List<string> knowledgeB, List<string> sensesB, string nameRaceClass, bool opened)
        {
            InitializeComponent();

            characterTextBox.Text = nameRaceClass;
            Size size = TextRenderer.MeasureText(characterTextBox.Text, characterTextBox.Font);
            characterTextBox.Width = size.Width;

            statsList = statsB;
            knowledgeList = knowledgeB;
            sensesList = sensesB;

            rollStats();
            rollSenses();
            rollKnowledge();

            reset();

            if(opened == true)
            {
                rerollAllBtn.Enabled = false;
                sensesRerollBtn.Enabled = false;
                statsRerollBtn.Enabled = false;
            }
        }

        public FormPC2(Dictionary<string,int>statsB, Dictionary<string,int>knowledgeB, Dictionary<string,int>sensesB, int levelB, string name)
        {
            InitializeComponent();

            baseLevel = levelB;
            characterTextBox.Text = name;

            foreach (var x in statsB)
            {
                statsDictBase[x.Key] = x.Value;
            }
            foreach (var x in knowledgeB)
            {
                knowledgeDictBase[x.Key] = x.Value;
            }
            foreach (var x in sensesB)
            {
                sensesDictBase[x.Key] = x.Value;
            }
            
            rerollAllBtn.Enabled = false;
            sensesRerollBtn.Enabled = false;
            statsRerollBtn.Enabled = false;
            knowledgeRerollBtn.Enabled = false;

            reset();

        }



        private void FormPC2_Load(object sender, EventArgs e)
        {
            levelTextBox.Text = level.ToString();
        }

        private void rerollSensesButton_Click(object sender, EventArgs e)
        {
            rollSenses();

            sightTextBox.Text = sensesDict["Wzrok"].ToString();
            hearingTextBox.Text = sensesDict["Słuch"].ToString();
            tasteTextBox.Text = sensesDict["Smak"].ToString();
            touchTextBox.Text = sensesDict["Dotyk"].ToString();
            olfactionTextBox.Text = sensesDict["Węch"].ToString();
        }

        private void rerollStatsButton_Click(object sender, EventArgs e)
        {
            level = baseLevel;


            rollStats();

            updateVit();
            updateWil();
            updateAgi();
            updateStr();
            updateDex();
            updateInt();

        }

        private void knowledgeRerollBtn_Click(object sender, EventArgs e)
        {
            rollKnowledge();

            geographyTextBox.Text = knowledgeDict["Geografia"].ToString();
            natureTextBox.Text = knowledgeDict["Natura"].ToString();
            magicTextBox.Text = knowledgeDict["Magia"].ToString();
            technicTextBox.Text = knowledgeDict["Technika"].ToString();
            religionTextBox.Text = knowledgeDict["Religia"].ToString();
            cultureTextBox.Text = knowledgeDict["Kultura"].ToString();
        }

        private void statsResetBtn_Click(object sender, EventArgs e)
        {
            level = baseLevel;
            levelTextBox.Text = level.ToString();

            foreach (var x in statsDictBase)
            {
                statsDict[x.Key] = x.Value;
            }

            updateVit();
            updateWil();
            updateAgi();
            updateStr();
            updateDex();
            updateInt();

            calculateAll();
        }
        
        private void knowledgeResetBtn_Click(object sender, EventArgs e)
        {
            foreach (var x in knowledgeDictBase)
            {
                knowledgeDict[x.Key] = x.Value;
            }

            geographyTextBox.Text = knowledgeDict["Geografia"].ToString();
            natureTextBox.Text = knowledgeDict["Natura"].ToString();
            magicTextBox.Text = knowledgeDict["Magia"].ToString();
            technicTextBox.Text = knowledgeDict["Technika"].ToString();
            religionTextBox.Text = knowledgeDict["Religia"].ToString();
            cultureTextBox.Text = knowledgeDict["Kultura"].ToString();

        }
        
        private void updateVit()
        {
                vitTextBox.Text = statsDict["Witalność"].ToString();
                calculateAll();
        }

        private void vitAddBtn_Click(object sender, EventArgs e)
        {
            int temp = statsDict["Witalność"];

            if (temp < 20)
            {

                if(temp < 5)
                {
                    level += 1;
                }
                else if(temp < 9)
                {
                    level += 2;
                }
                else if(temp < 13)
                {
                    level += 3;
                }
                else if(temp < 17)
                {
                    level += 4;
                }
                else
                {
                    level += 5;
                }

                levelTextBox.Text = level.ToString();

                statsDict["Witalność"] += 1;
                updateVit();
            }
            else
            {
                MessageBox.Show("Wartość parametru nie może przekroczyć 20!", "Błąd!");
            }
        }

        private void updateInt()
        {
                intTextBox.Text = statsDict["Inteligencja"].ToString();
                calculateAll();
        }
        
        private void intAddBtn_Click(object sender, EventArgs e)
        {
            int temp = statsDict["Inteligencja"];

            if (temp< 20)
            {

                if (temp < 5)
                {
                    level += 1;
                }
                else if (temp < 9)
                {
                    level += 2;
                }
                else if (temp < 13)
                {
                    level += 3;
                }
                else if (temp < 17)
                {
                    level += 4;
                }
                else
                {
                    level += 5;
                }

                levelTextBox.Text = level.ToString();
                statsDict["Inteligencja"] += 1;
                updateInt();
            }
            else
            {
                MessageBox.Show("Wartość parametru nie może przekroczyć 20!", "Błąd!");
            }
        }

        private void updateWil()
        {   
                wilTextBox.Text = statsDict["Wola"].ToString();
                calculateAll();
        }

        private void wilAddBtn_Click(object sender, EventArgs e)
        {
            int temp = statsDict["Wola"];

            if (temp < 20)
            {
                if (temp < 5)
                {
                    level += 1;
                }
                else if (temp < 9)
                {
                    level += 2;
                }
                else if (temp < 13)
                {
                    level += 3;
                }
                else if (temp < 17)
                {
                    level += 4;
                }
                else
                {
                    level += 5;
                }

                levelTextBox.Text = level.ToString();
                statsDict["Wola"] += 1;
                updateWil();
            }
            else
            {
                MessageBox.Show("Wartość parametru nie może przekroczyć 20!", "Błąd!");
            }
        }

        private void updateAgi()
        {
            agiTextBox.Text = statsDict["Zwinność"].ToString();
            calculateAll(); 
        }

        private void agiAddBtn_Click(object sender, EventArgs e)
        {
            int temp = statsDict["Zwinność"];

            if (temp < 20)
            {
                if (temp < 5)
                {
                    level += 1;
                }
                else if (temp < 9)
                {
                    level += 2;
                }
                else if (temp < 13)
                {
                    level += 3;
                }
                else if (temp < 17)
                {
                    level += 4;
                }
                else
                {
                    level += 5;
                }

                levelTextBox.Text = level.ToString();
                statsDict["Zwinność"] += 1;
                updateAgi();
            }
            else
            {
                MessageBox.Show("Wartość parametru nie może przekroczyć 20!", "Błąd!");
            }
        }

        private void updateStr()
        {  
                strTextBox.Text = statsDict["Siła"].ToString();
                calculateAll();
        }

        private void strAddBtn_Click(object sender, EventArgs e)
        {
            int temp = statsDict["Siła"];

            if (temp < 20)
            {
                if (temp < 5)
                {
                    level += 1;
                }
                else if (temp < 9)
                {
                    level += 2;
                }
                else if (temp < 13)
                {
                    level += 3;
                }
                else if (temp < 17)
                {
                    level += 4;
                }
                else
                {
                    level += 5;
                }
                levelTextBox.Text = level.ToString();
                statsDict["Siła"] += 1;
                updateStr();
            }
            else
            {
                MessageBox.Show("Wartość parametru nie może przekroczyć 20!", "Błąd!");
            }
        }

        private void updateDex()
        {
            dexTextBox.Text = statsDict["Zręczność"].ToString();
            calculateAll();
        }

        private void dexAddBtn_Click(object sender, EventArgs e)
        {
            int temp = statsDict["Zręczność"];
            
            if (temp < 20)
            {
                if (temp < 5)
                {
                    level += 1;
                }
                else if (temp < 9)
                {
                    level += 2;
                }
                else if (temp < 13)
                {
                    level += 3;
                }
                else if (temp < 17)
                {
                    level += 4;
                }
                else
                {
                    level += 5;
                }
                levelTextBox.Text = level.ToString();
                statsDict["Zręczność"] += 1;
                updateDex();
            }
            else
            {
                MessageBox.Show("Wartość parametru nie może przekroczyć 20!", "Błąd!");
            }
        }

        private void cultureAddBtn_Click(object sender, EventArgs e)
        {
            if (knowledgeDict["Kultura"] < 20)
            {
                knowledgeDict["Kultura"] += 1;
                cultureTextBox.Text = knowledgeDict["Kultura"].ToString();
            }
            else
            {
                MessageBox.Show("Wartość parametru nie może przekroczyć 20!", "Błąd!");
            }
        }

        private void geographyAddBtn_Click(object sender, EventArgs e)
        {
            if (knowledgeDict["Geografia"]< 20)
            {
                knowledgeDict["Geografia"] += 1;
                geographyTextBox.Text = knowledgeDict["Geografia"].ToString();
            }
            else
            {
                MessageBox.Show("Wartość parametru nie może przekroczyć 20!", "Błąd!");
            }
        }

        private void technicAddBtn_Click(object sender, EventArgs e)
        {
            if (knowledgeDict["Technika"] < 20) {
                knowledgeDict["Technika"] += 1;
                technicTextBox.Text = knowledgeDict["Technika"].ToString();
            }
            else
            {
                MessageBox.Show("Wartość parametru nie może przekroczyć 20!", "Błąd!");
            }
        }

        private void natureAddBtn_Click(object sender, EventArgs e)
        {
            if (knowledgeDict["Natura"] < 20)
            {
                knowledgeDict["Natura"] += 1;
                natureTextBox.Text = knowledgeDict["Natura"].ToString();
            }
            else
            {
                MessageBox.Show("Wartość parametru nie może przekroczyć 20!", "Błąd!");
            }
        }

        private void magicAddBtn_Click(object sender, EventArgs e)
        {
            if (knowledgeDict["Magia"] < 20)
            {
                knowledgeDict["Magia"] += 1;
                magicTextBox.Text = knowledgeDict["Magia"].ToString();
            }
            else
            {
                MessageBox.Show("Wartość parametru nie może przekroczyć 20!", "Błąd!");
            }
        }

        private void religionAddBtn_Click(object sender, EventArgs e)
        {
            if (knowledgeDict["Religia"] < 20)
            {
                knowledgeDict["Religia"] += 1;
                religionTextBox.Text = knowledgeDict["Religia"].ToString();
            }
            else
            {
                MessageBox.Show("Wartość parametru nie może przekroczyć 20!", "Błąd!");
            }
        }

        private void resetAllBtn_Click(object sender, EventArgs e)
        {
            reset();
            level = baseLevel;
            levelTextBox.Text = level.ToString();
        }

        private void rerollAllBtn_Click(object sender, EventArgs e)
        {
            level = baseLevel;
            levelTextBox.Text = level.ToString();

            rollKnowledge();
            rollSenses();
            rollStats();

            updateVit();
            updateWil();
            updateAgi();
            updateStr();
            updateDex();
            updateInt();

            calculateAll();

            geographyTextBox.Text = knowledgeDict["Geografia"].ToString();
            natureTextBox.Text = knowledgeDict["Natura"].ToString();
            magicTextBox.Text = knowledgeDict["Magia"].ToString();
            technicTextBox.Text = knowledgeDict["Technika"].ToString();
            religionTextBox.Text = knowledgeDict["Religia"].ToString();
            cultureTextBox.Text = knowledgeDict["Kultura"].ToString();


            sightTextBox.Text = sensesDict["Wzrok"].ToString();
            hearingTextBox.Text = sensesDict["Słuch"].ToString();
            tasteTextBox.Text = sensesDict["Smak"].ToString();
            touchTextBox.Text = sensesDict["Dotyk"].ToString();
            olfactionTextBox.Text = sensesDict["Węch"].ToString();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Przejdziesz teraz do menu głównego. Jakakakolwiek niezapisana praca zastanie utracona. Kontynuować?", "Ostrożnie!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {
                FormMenu formMenu = new FormMenu();
                formMenu.Show();
                this.Close();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Zapisane zmiany nie mogą zostać w żaden sposób cofnięte. Zablokowana zostanie także możliwość przerzucenia kości. Kontynuować?", "Ostrożnie!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                string filename = characterTextBox.Text.Replace(' ', '_').Replace(",","");
                saveFileDialog.FileName = filename;

                string saveFile = "";

                saveFile += ("DSKP" + "\n");

                saveFile += "PC";
                saveFile += "\n";

                saveFile += characterTextBox.Text;
                saveFile += "\n";

                saveFile += level.ToString();
                saveFile += "\n";

                foreach(var x in statsDict)
                {
                    saveFile += (x.Key + " " + x.Value + "\n");
                   // saveFile += " ";
                   //saveFile += x.Value;
                   //saveFile += '\n';
                }

                foreach(var x in knowledgeDict)
                {
                    saveFile += (x.Key + " " + x.Value + "\n"); 
                }

                foreach(var x in sensesDict)
                {
                    saveFile += (x.Key + " " + x.Value + "\n");
                }

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, saveFile);

                    rerollAllBtn.Enabled = false;
                    sensesRerollBtn.Enabled = false;
                    statsRerollBtn.Enabled = false;
                    baseLevel = level;

                    foreach(var x in statsDict)
                    {
                        statsDictBase[x.Key] = x.Value;
                    }

                    foreach (var x in knowledgeDict)
                    {
                        knowledgeDictBase[x.Key] = x.Value;
                    }
                }
            }
        }
    }         
}
