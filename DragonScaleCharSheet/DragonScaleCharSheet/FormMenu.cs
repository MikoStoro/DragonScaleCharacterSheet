using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DragonScaleCharSheet
{


    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Witaj w kreatorze kart postaci DragonScale!\n\nZaładuj Kartę Postaci - Pozwala załadować do programu utworzoną wcześniej kartę postaci gracza lub postaci niezależnej.\n\nStwórz Kartę Postaci - pozwala utworzyć nową kartę postaci gracza na poziomie 1.\n\nStwórz NPCa - pozwala utworzyć nową kartę postaci niezależnej na poziomie 1.\n\nKAżda z powyższych opcji pozwala na edycję załadowanej/stworzonej karty.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createPCButton_Click(object sender, EventArgs e)
        {
            FormPC formPC = new FormPC();
            formPC.Show();
            this.Hide();
        }

        private void createNPCButton_Click(object sender, EventArgs e)
        {
            FormNPC formNPC = new FormNPC(false);
            formNPC.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string input = File.ReadAllText(openFileDialog.FileName);
                string[] lines = input.Split(new char[] { '\n' });

                Console.WriteLine(lines[0]);

                if (lines[0] != "DSKP")
                {
                    MessageBox.Show("Wybrano nieodpowiedni plik!", "Błąd!");
                }
                else if(lines[1] == "PC")
                {
                    string name = lines[2];
                    int level = Convert.ToInt32(lines[3]);

                    Dictionary<string, int> tempstats = new Dictionary<string, int>();
                    Dictionary<string, int> tempknowledege = new Dictionary<string, int>();
                    Dictionary<string, int> tempsenses = new Dictionary<string, int>();


                    for(int i = 4; i < 10; i++)
                    {
                        string[] temp = lines[i].Split(new char[] { ' ' });
                        tempstats.Add(temp[0], Convert.ToInt32(temp[1]));
                    }

                    for(int i = 10; i < 16; i++)
                    {
                        string[] temp = lines[i].Split(new char[] { ' ' });
                        tempknowledege.Add(temp[0], Convert.ToInt32(temp[1]));
                    }

                    for(int i = 16; i <21; i++)
                    {
                        string[] temp = lines[i].Split(new char[] { ' ' });
                        tempsenses.Add(temp[0], Convert.ToInt32(temp[1]));
                    }

                    FormPC2 formPC2 = new FormPC2(tempstats, tempknowledege, tempsenses, level, name);
                    formPC2.Show();
                    this.Hide();
                }
                else if(lines[1] == "NPC")
                {
                    string name = lines[2];
                    int level = Convert.ToInt32(lines[3]);

                    Dictionary<string, int> tempstats = new Dictionary<string, int>();


                }
                
            }
        }
    }
}
