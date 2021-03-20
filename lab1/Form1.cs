using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            criterionPool = new List<string> { };
            pairIndexesMajor = new List<int[]> { };
            pairIndexesMinor = new List<int[]> { };
            AHPs = new List<Form1> { };
            index = 0;
            level = 0;
        }

        private void addCriterionButton_Click(object sender, EventArgs e)
        {
            string tmpText = criterionTextBox.Text;
            if (tmpText != null && tmpText != "")
            {
                criterionPool.Add(tmpText);
                criterionTextBox.Clear();
            }
        }

        private void endAddingButton_Click(object sender, EventArgs e)
        {
            if(level == 0)
            {
                if(criterionPool.Count < 3)
                {
                    MessageBox.Show("Three or more criteria are required.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                addNamesBox.Text = "Add categories";
                level++;
                g_AHP = new Form1(criterionPool.ToArray());
                criterionPool.Clear();
                return;
            }
            level = -1;
            if (criterionPool.Count < 2)
            {
                MessageBox.Show("Two or more categories are required.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string []criterionNames = criterionPool.ToArray();
            for(int i = 0; i < g_AHP.Amount; i++)
            {
                AHPs.Add(new Form1(criterionNames));
            }

            addNamesBox.Enabled = false;
            prioritiesAddBox.Enabled = true;
            criterionPool.Clear();
            criterionTextBox.Clear();

            pairIndexesMajor = generatePairs(g_AHP.Amount);
            pairIndexesMinor = generatePairs(AHPs.ElementAt(0).Amount);

            setRadioButtons(g_AHP.Names, pairIndexesMajor);
        }

        private void setRadioButtons(string []names, List<int[]> pairIndexes)
        {
            choice1.Text = names[pairIndexes.ElementAt(index)[0]];
            choice2.Text = names[pairIndexes.ElementAt(index)[1]];
        }
        private void nextPairButton_Click(object sender, EventArgs e)
        {
            if(level == -1)
            {
                applyRatio(g_AHP, pairIndexesMajor);
            }
            else
            {
                applyRatio(AHPs.ElementAt(level), pairIndexesMinor);
            }
        }
        private void applyRatio(Form1 aHP, List<int[]> pairIndexes)
        {
            if (valuesComboBox.SelectedIndex != -1)
            {
                if (choice1.Checked)
                {
                    aHP.setPriority(pairIndexes.ElementAt(index)[0], pairIndexes.ElementAt(index)[1], Int32.Parse(valuesComboBox.Text));
                }
                else
                {
                    aHP.setPriority(pairIndexes.ElementAt(index)[1], pairIndexes.ElementAt(index)[0], Int32.Parse(valuesComboBox.Text));
                }
                index++;
                if (index < pairIndexes.Count)
                {
                    setRadioButtons(aHP.Names, pairIndexes);
                }
                else
                {
                    if(level < AHPs.Count - 1)
                    {
                        aHP.calculateVectors();
                        aHP.PRINTFORILLYA();
                        level++;
                        index = 0;
                        setRadioButtons(AHPs.ElementAt(level).Names, pairIndexes);
                        prioritiesAddBox.Text = g_AHP.Names[level];
                    }
                    else 
                    {
                        aHP.calculateVectors();
                        aHP.PRINTFORILLYA();
                        prioritiesAddBox.Enabled = false;
                        showResultDialogBox();
                    }
                }
            }
        }
        private List<int[]> generatePairs(int amount)
        {
            List<int[]> rez = new List<int[]> { };

            for (int i = 0; i < amount; i++)
            {
                for (int j = 0; j < amount; j++)
                {
                    if (i >= j) continue;
                    else
                    {
                        rez.Add(new[] { i, j });
                    }
                }
            }
            return rez;
        }
        public void showResultDialogBox()
        {
            ResultDialog resultDialog = new ResultDialog(Form1.getPriorityValues(g_AHP, AHPs));

            if (resultDialog.ShowDialog(this) == DialogResult.OK)
            {
                //
            }
            else
            {
                Console.WriteLine("DialogW::Error");
            }
            resultDialog.Dispose();
            this.Close();
        }

        List<string> criterionPool;
        Form1 g_AHP;
        List<Form1> AHPs;
        List<int[]> pairIndexesMajor;
        List<int[]> pairIndexesMinor;
        int index;
        int level;
    }
}
