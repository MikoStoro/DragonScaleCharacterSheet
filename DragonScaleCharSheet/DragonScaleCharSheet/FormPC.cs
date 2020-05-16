using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonScaleCharSheet
{



    public partial class FormPC : Form
    {
        List<string> stats1 = new List<string>();
        List<string> knowledge1 = new List<string>();
        List<string> senses1 = new List<string>();



        private void setOrder()
        {
            foreach (var x in statsGroupBox.Controls.OfType<ComboBox>())
            {
                stats1.Add(x.SelectedItem.ToString());
            }

            foreach (var x in knowledgeGroupBox.Controls.OfType<ComboBox>())
            {
                knowledge1.Add(x.SelectedItem.ToString());
            }

            foreach (var x in perceptionGroupBox.Controls.OfType<ComboBox>())
            {
                senses1.Add(x.SelectedItem.ToString());
            }
        }


        public FormPC()
        {
            InitializeComponent();
        }

        private void statChoice1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statChoice1.SelectedIndex > -1)
            {
                foreach (var x in statsGroupBox.Controls.OfType<ComboBox>())
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
                foreach (var x in statsGroupBox.Controls.OfType<ComboBox>())
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
                foreach (var x in statsGroupBox.Controls.OfType<ComboBox>())
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
                foreach (var x in statsGroupBox.Controls.OfType<ComboBox>())
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

        private void statChoice5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statChoice5.SelectedIndex > -1)
            {
                foreach (var x in statsGroupBox.Controls.OfType<ComboBox>())
                {
                    if (x.SelectedIndex == statChoice5.SelectedIndex)
                    {
                        if (x.Name != "statChoice5")
                        {
                            x.SelectedIndex = -1;
                        }
                    }

                }
            }
        }

        private void statChoice6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statChoice6.SelectedIndex > -1)
            {
                foreach (var x in statsGroupBox.Controls.OfType<ComboBox>())
                {
                    if (x.SelectedIndex == statChoice6.SelectedIndex)
                    {
                        if (x.Name != "statChoice6")
                        {
                            x.SelectedIndex = -1;
                        }
                    }

                }
            }
        }

        private void senseChoice1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statChoice1.SelectedIndex > -1)
            {
                foreach (var x in statsGroupBox.Controls.OfType<ComboBox>())
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

        private void senseChoice2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (senseChoice2.SelectedIndex > -1)
            {
                foreach (var x in perceptionGroupBox.Controls.OfType<ComboBox>())
                {
                    if (x.SelectedIndex == senseChoice2.SelectedIndex)
                    {
                        if (x.Name != "senseChoice2")
                        {
                            x.SelectedIndex = -1;
                        }
                    }

                }
            }
        }

        private void senseChoice3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (senseChoice3.SelectedIndex > -1)
            {
                foreach (var x in perceptionGroupBox.Controls.OfType<ComboBox>())
                {
                    if (x.SelectedIndex == senseChoice3.SelectedIndex)
                    {
                        if (x.Name != "senseChoice3")
                        {
                            x.SelectedIndex = -1;
                        }
                    }

                }
            }
        }

        private void senseChoice4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (senseChoice4.SelectedIndex > -1)
            {
                foreach (var x in perceptionGroupBox.Controls.OfType<ComboBox>())
                {
                    if (x.SelectedIndex == senseChoice4.SelectedIndex)
                    {
                        if (x.Name != "senseChoice4")
                        {
                            x.SelectedIndex = -1;
                        }
                    }

                }
            }
        }

        private void senseChoice5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (senseChoice5.SelectedIndex > -1)
            {
                foreach (var x in perceptionGroupBox.Controls.OfType<ComboBox>())
                {
                    if (x.SelectedIndex == senseChoice5.SelectedIndex)
                    {
                        if (x.Name != "senseChoice5")
                        {
                            x.SelectedIndex = -1;
                        }
                    }

                }
            }
        }

        private void disciplineChoice1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (senseChoice5.SelectedIndex > -1)
            {
                foreach (var x in perceptionGroupBox.Controls.OfType<ComboBox>())
                {
                    if (x.SelectedIndex == senseChoice5.SelectedIndex)
                    {
                        if (x.Name != "senseChoice5")
                        {
                            x.SelectedIndex = -1;
                        }
                    }

                }
            }
        }

        private void disciplineChoice2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (disciplineChoice2.SelectedIndex > -1)
            {
                foreach (var x in knowledgeGroupBox.Controls.OfType<ComboBox>())
                {
                    if (x.SelectedIndex == disciplineChoice2.SelectedIndex)
                    {
                        if (x.Name != "disciplineChoice2")
                        {
                            x.SelectedIndex = -1;
                        }
                    }

                }
            }
        }

        private void disciplineChoice3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (disciplineChoice3.SelectedIndex > -1)
            {
                foreach (var x in knowledgeGroupBox.Controls.OfType<ComboBox>())
                {
                    if (x.SelectedIndex == disciplineChoice3.SelectedIndex)
                    {
                        if (x.Name != "disciplineChoice3")
                        {
                            x.SelectedIndex = -1;
                        }
                    }

                }
            }
        }

        private void disciplineChoice4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (disciplineChoice4.SelectedIndex > -1)
            {
                foreach (var x in knowledgeGroupBox.Controls.OfType<ComboBox>())
                {
                    if (x.SelectedIndex == disciplineChoice4.SelectedIndex)
                    {
                        if (x.Name != "disciplineChoice4")
                        {
                            x.SelectedIndex = -1;
                        }
                    }

                }
            }
        }

        private void disciplineChoice5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (disciplineChoice5.SelectedIndex > -1)
            {
                foreach (var x in knowledgeGroupBox.Controls.OfType<ComboBox>())
                {
                    if (x.SelectedIndex == disciplineChoice5.SelectedIndex)
                    {
                        if (x.Name != "disciplineChoice5")
                        {
                            x.SelectedIndex = -1;
                        }
                    }

                }
            }
        }

        private void disciplineChoice6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (disciplineChoice6.SelectedIndex > -1)
            {
                foreach (var x in knowledgeGroupBox.Controls.OfType<ComboBox>())
                {
                    if (x.SelectedIndex == disciplineChoice6.SelectedIndex)
                    {
                        if (x.Name != "disciplineChoice6")
                        {
                            x.SelectedIndex = -1;
                        }
                    }

                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            string message = "Wracając do menu głównego utracisz wszystkie zmiany wprowadzone w Edytorze. Czy na pewno chcesz kontynuować?";
            string label = "Niezapisane zmiany";
            DialogResult result = MessageBox.Show(message, label, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                FormMenu formMenu = new FormMenu();
                formMenu.Show();
                this.Close();
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool completed = true;

            foreach (var x in this.Controls.OfType<ComboBox>())
            {
                if (x.SelectedIndex == -1)
                {
                    completed = false;
                    break;
                }

            }

            if (completed == true)
            {
                foreach (var x in this.Controls.OfType<TextBox>())
                {
                    if (x.Text.Trim() == "")
                    {
                        completed = false;
                        break;
                    }
                }

                if (completed == true)
                {
                    string message = "Program przystąpi teraz do generacji karty przy użyciu wprowadzonych danych. Ich zmiana nie będzie później możliwa. Kontynuować?";
                    string label = "Generacja Karty";
                    DialogResult result = MessageBox.Show(message, label, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        setOrder();
                        string nameRaceClass = nameTextBox.Text + ", " + raceTextBox.Text + " " + classTextBox.Text;

                        FormPC2 formPC2 = new FormPC2(stats1, knowledge1, senses1, nameRaceClass, false);
                        formPC2.Show();
                        this.Close();


                    }
                    if (result == DialogResult.No)
                    {
                        stats1.Clear();
                        senses1.Clear();
                        knowledge1.Clear();
                    }
                }
                else
                {
                    string message = "W Edytorze pozostały puste pola! Wypełnij je aby kontynuować.";
                    string label = "Błąd!";

                    MessageBox.Show(message, label, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
