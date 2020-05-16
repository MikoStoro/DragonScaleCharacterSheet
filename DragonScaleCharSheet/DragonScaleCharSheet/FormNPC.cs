using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonScaleCharSheet
{
    public partial class FormNPC : Form
    {
        int level = 1;

        List<string> tempList = new List<string>() { "Wytrzymałość", "Sprawność", "Siła", "Intelekt" };

        List<string> statsList = new List<string>();

        Dictionary<string, int> statsDictBase = new Dictionary<string, int>();
        Dictionary<string, int> statsDict = new Dictionary<string, int>();

        Dictionary<string, double> modifiersDict = new Dictionary<string, double>();

        public FormNPC(bool opened)
        {
            InitializeComponent();

            if (opened == true)
            {
                rollBtn.Enabled = false;
                statChoice1.Enabled = false;
                statChoice2.Enabled = false;
            }
        }

        public FormNPC(Dictionary<string, int> statsB, string name, int level)
        {

        }

        private void setOrder()
        {
            statsList = new List<string>();

            foreach (var x in statsOrderGroupBox.Controls.OfType<ComboBox>())
            {
                statsList.Add(x.SelectedItem.ToString());
            }
        }

        private void rollStats()
        {
            List<int> rollResults = new List<int>();
            Random rnd = new Random();

            int roll = rnd.Next(11);
            rollResults.Add(roll);
            rollResults.Add(10 - roll);

            roll = rnd.Next(13);
            rollResults.Add(roll);
            rollResults.Add(12 - roll);

            rollResults.Sort();
            rollResults.Reverse();
            Console.WriteLine(rollResults);

            for (int i = 0; i < 4; i++)
            {
                statsDictBase[statsList[i]] = rollResults[i] + 2;
                statsDict[statsList[i]] = rollResults[i] + 2;
                Console.WriteLine(statsList[i]);
                Console.WriteLine(rollResults[i]);
            }
        }

        private void setStats()
        {
            vitTextBox.Text = statsDict["Wytrzymałość"] + " (" + Convert.ToInt32(statsDict["Wytrzymałość"] * modifiersDict["Wytrzymałość"]).ToString() + ")";
            agiTextBox.Text = statsDict["Sprawność"] + " (" + Convert.ToInt32(statsDict["Sprawność"] * modifiersDict["Sprawność"]).ToString() + ")";
            strTextBox.Text = statsDict["Siła"] + " (" + Convert.ToInt32(statsDict["Siła"] * modifiersDict["Siła"]).ToString() + ")";
            intTextBox.Text = statsDict["Intelekt"] + " (" + Convert.ToInt32(statsDict["Intelekt"] * modifiersDict["Intelekt"]).ToString() + ")";
        }

        private void calculateAll()
        {
            int Vit = statsDict["Wytrzymałość"];
            int Int = statsDict["Intelekt"];
            int Agi = statsDict["Sprawność"];
            int Str = statsDict["Siła"];

            healthTextBox.Text = (Vit + 2).ToString() + " / " + Convert.ToInt16((Vit + 2) * 0.75).ToString() + " / " + Convert.ToInt16((Vit + 2) / 2).ToString() + " / " + Convert.ToInt16((Vit + 2) / 4).ToString();

            magickaTextBox.Text = (Int + 2).ToString();

            dexPowerTextBox.Text = (Agi + 2).ToString() + " / " + Convert.ToInt16((Agi + 2) * 0.75).ToString() + " / " + Convert.ToInt16((Agi + 2) / 2).ToString() + " / " + Convert.ToInt16((Agi + 2) / 4).ToString();
            intPowerTextBox.Text = (Int + 2).ToString() + " / " + Convert.ToInt16((Int + 2) * 0.75).ToString() + " / " + Convert.ToInt16((Int + 2) / 2).ToString() + " / " + Convert.ToInt16((Int + 2) / 4).ToString();
            strPowerTextBox.Text = (Vit + 2).ToString() + " / " + Convert.ToInt16((Str + 2) * 0.75).ToString() + " / " + Convert.ToInt16((Str + 2) / 2).ToString() + " / " + Convert.ToInt16((Str + 2) / 4).ToString();

            accTextBox.Text = Convert.ToInt16(Agi / 2).ToString() + " / " + Convert.ToInt16(Int / 2).ToString();
            speedTextBox.Text = Convert.ToInt16(Agi / 2.5).ToString();

            blockTextBox.Text = Agi.ToString();
            dodgeTextBox.Text = Convert.ToInt16(Agi / 1.5).ToString();

            focusTextBox.Text = Convert.ToInt16(Int / 2.5).ToString();

            critTextBox.Text = Convert.ToInt16(Int / 5 + Agi / 5 + Str / 10).ToString() + " / " + Convert.ToInt16(Int / 5 + Agi / 5).ToString() + " / " + Convert.ToInt16(Int / 4).ToString();

            unbreakTextBox.Text = Convert.ToInt16(Vit / 4 + Int / 4).ToString();
        }

        private void statChoice1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statChoice1.SelectedIndex > -1)
            {
                foreach (var x in statsOrderGroupBox.Controls.OfType<ComboBox>())
                {
                    if (x.SelectedIndex == statChoice1.SelectedIndex)
                    {
                        if (x.Name != "statChoice1")
                        {
                            x.SelectedIndex = -1;
                        }
                    }

                }
            }
        }

        private void statChoice2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statChoice2.SelectedIndex > -1)
            {
                foreach (var x in statsOrderGroupBox.Controls.OfType<ComboBox>())
                {
                    if (x.SelectedIndex == statChoice2.SelectedIndex)
                    {
                        if (x.Name != "statChoice2")
                        {
                            x.SelectedIndex = -1;
                        }
                    }

                }
            }
        }

        private void statChoice3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statChoice3.SelectedIndex > -1)
            {
                foreach (var x in statsOrderGroupBox.Controls.OfType<ComboBox>())
                {
                    if (x.SelectedIndex == statChoice3.SelectedIndex)
                    {
                        if (x.Name != "statChoice3")
                        {
                            x.SelectedIndex = -1;
                        }
                    }

                }
            }
        }

        private void statChoice4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statChoice4.SelectedIndex > -1)
            {
                foreach (var x in statsOrderGroupBox.Controls.OfType<ComboBox>())
                {
                    if (x.SelectedIndex == statChoice4.SelectedIndex)
                    {
                        if (x.Name != "statChoice4")
                        {
                            x.SelectedIndex = -1;
                        }
                    }

                }
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (var x in statsOrderGroupBox.Controls.OfType<ComboBox>())
            {
                x.SelectedIndex = -1;
            }

            foreach (var x in tempList)
            {
                statsDict.Add(x, 0);
                modifiersDict.Add(x, 1);
            }
        }

        private void vitModifierNumeric_ValueChanged(object sender, EventArgs e)
        {
            modifiersDict["Wytrzymałość"] = Convert.ToDouble(vitModifierNumeric.Value);
            updateVit();
            calculateAll();

        }

        private void strModifierNumeric_ValueChanged(object sender, EventArgs e)
        {
            modifiersDict["Siła"] = Convert.ToDouble(strModifierNumeric.Value);
            updateStr();
            calculateAll();
        }

        private void agiModifierNumeric_ValueChanged(object sender, EventArgs e)
        {
            modifiersDict["Zwinność"] = Convert.ToDouble(agiModifierNumeric.Value);
            updateAgi();
            calculateAll();
        }

        private void intModifierNumeric_ValueChanged(object sender, EventArgs e)
        {
            modifiersDict["Intelekt"] = Convert.ToDouble(intModifierNumeric.Value);
            updateInt();
            calculateAll();
        }

        private void rollBtn_Click(object sender, EventArgs e)
        {
            bool completed = true;

            foreach (var x in statsOrderGroupBox.Controls.OfType<ComboBox>())
            {
                if (x.SelectedIndex == -1)
                {
                    completed = false;
                    break;
                }
            }

            if (completed == true)
            {
                setOrder();
                rollStats();
                setStats();
                calculateAll();
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola Atrybutów!", "Błąd!");
            }
        }

        private void statsResetBtn_Click(object sender, EventArgs e)
        {
            level = 1;
            levelTextBox.Text = level.ToString();

            foreach (var x in statsDictBase)
            {
                statsDict[x.Key] = x.Value;
            }

            setStats();
        }

        private void modifierResetBtn_Click(object sender, EventArgs e)
        {
            vitModifierNumeric.Value = 1;
            intModifierNumeric.Value = 1;
            strModifierNumeric.Value = 1;
            agiModifierNumeric.Value = 1;

            foreach (var x in tempList)
            {
                modifiersDict[x] = 1;
            }

            setStats();
            calculateAll();
        }

        private void vitAddBtn_Click(object sender, EventArgs e)
        {
            int temp = statsDict["Wytrzymałość"];
            if (temp < 20)
            {
                if (temp <= 4)
                {
                    level += 1;
                }
                else if (temp <= 8)
                {
                    level += 2;
                }
                else if (temp <= 12)
                {
                    level += 3;
                }
                else if (temp <= 16)
                {
                    level += 4;
                }
                else
                {
                    level += 5;
                }

                statsDict["Wytrzymałość"] += 1;
                levelTextBox.Text = level.ToString();
                updateVit();
            }
            else
            {
                MessageBox.Show("Wartość Atrybutu nie może przekroczyć 20!", "Błąd!");
            }
        }

        private void updateVit()
        {
            vitTextBox.Text = statsDict["Wytrzymałość"].ToString() + " (" + Convert.ToInt32(statsDict["Wytrzymałość"] * modifiersDict["Wytrzymałość"]).ToString() + ")";
            calculateAll();
        }

        private void strAddBtn_Click(object sender, EventArgs e)
        {
            int temp = statsDict["Siła"];
            if (temp < 20)
            {
                if (temp <= 4)
                {
                    level += 1;
                }
                else if (temp <= 8)
                {
                    level += 2;
                }
                else if (temp <= 12)
                {
                    level += 3;
                }
                else if (temp <= 16)
                {
                    level += 4;
                }
                else
                {
                    level += 5;
                }

                statsDict["Siła"] += 1;
                levelTextBox.Text = level.ToString();
                updateStr();

            }
            else
            {
                MessageBox.Show("Wartość Atrybutu nie może przekroczyć 20!", "Błąd!");
            }
        }

        private void updateStr()
        {
            strTextBox.Text = statsDict["Siła"].ToString() + " (" + Convert.ToInt32(statsDict["Siła"] * modifiersDict["Siła"]).ToString() + ")";
            calculateAll();
        }

        private void agiAddBtn_Click(object sender, EventArgs e)
        {
            int temp = statsDict["Sprawność"];
            if (temp < 20)
            {
                if (temp <= 4)
                {
                    level += 1;
                }
                else if (temp <= 8)
                {
                    level += 2;
                }
                else if (temp <= 12)
                {
                    level += 3;
                }
                else if (temp <= 16)
                {
                    level += 4;
                }
                else
                {
                    level += 5;
                }

                statsDict["Sprawność"] += 1;
                levelTextBox.Text = level.ToString();
                updateAgi();
            }
            else
            {
                MessageBox.Show("Wartość Atrybutu nie może przekroczyć 20!", "Błąd!");
            }
        }

        private void updateAgi()
        {
            agiTextBox.Text = statsDict["Sprawność"].ToString() + " (" + Convert.ToInt32(statsDict["Sprawność"] * modifiersDict["Sprawność"]).ToString() + ")";
            calculateAll();
        }

        private void intAddBtn_Click(object sender, EventArgs e)
        {
            int temp = statsDict["Intelekt"];
            if (temp < 20)
            {
                if (temp <= 4)
                {
                    level += 1;
                }
                else if (temp <= 8)
                {
                    level += 2;
                }
                else if (temp <= 12)
                {
                    level += 3;
                }
                else if (temp <= 16)
                {
                    level += 4;
                }
                else
                {
                    level += 5;
                }

                statsDict["Intelekt"] += 1;
                levelTextBox.Text = level.ToString();
                updateInt();
            }
            else
            {
                MessageBox.Show("Wartość Atrybutu nie może przekroczyć 20!", "Błąd!");
            }
        }

        private void updateInt()
        {
            intTextBox.Text = statsDict["Intelekt"].ToString() + " (" + Convert.ToInt32(statsDict["Intelekt"] * modifiersDict["Intelekt"]).ToString() + ")";
            calculateAll();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Zapisane zmiany nie mogą zostać w żaden sposób cofnięte. Zablokowana zostanie także możliwość przerzucenia kości. Kontynuować?", "Ostrożnie!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string filename = nameTextBox.Text.Replace(' ', '_').Replace(",", "");
                saveFileDialog.FileName = filename;

                string saveFile = "";

                saveFile += ("DSKP" + "\n");

                saveFile += "NPC";
                saveFile += "\n";

                saveFile += (nameTextBox.Text + " " + typeTextBox.Text);
                saveFile += "\n";

                saveFile += level.ToString();
                saveFile += "\n";

                foreach (var x in statsDict)
                {
                    saveFile += (x.Key + " " + x.Value + "\n");
                }

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, saveFile);

                    rollBtn.Enabled = false;


                    foreach (var x in statsDict)
                    {
                        statsDictBase[x.Key] = x.Value;
                    }

                }
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kiedy otwarty zostanie inny plik, wszystkie niezapisane zmiany w obecnym zostaną utracone. Kontynuować?", "Ostrożnie!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               
            if(result == DialogResult.Yes)
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string input = File.ReadAllText(openFileDialog.FileName);

                    string[] lines = input.Split(new char[] { '\n' });
                }
            }
        }
    }
}
