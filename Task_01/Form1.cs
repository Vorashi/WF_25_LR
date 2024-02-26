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

namespace Task_01
{
    public partial class Form1 : Form
    {
        int SelectedIndex = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitItemTool_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearListItemTool_Click(object sender, EventArgs e)
        {
            LBoxRangomFirst.Items.Clear();
            LBoxRangomSecond.Items.Clear();
            LBoxRangomThree.Items.Clear();
        }

        private void ClearWindowItemTool_Click(object sender, EventArgs e)
        {
            LBoxMain.Items.Clear();
        }

        private void BtnAddToList_Click(object sender, EventArgs e)
        {
            if (TbxInput.Text != "") 
            {
                LBoxMain.Items.Add(TbxInput.Text);
                TbxInput.Text = "";
            } 
            else 
            {
                MessageBox.Show("Значение введите пожалуйста!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFile();
        }

        public void LoadFile()
        {
            string filePath = "C:\\My work programm\\C#\\WF_25\\Task_01\\source.txt";

            try
            {
                string[] words = File.ReadAllText(filePath).Split('$');

                for (int i = 0; i < words.Length; i++)
                {
                    if (i <= 4)
                    {
                        LBoxRangomFirst.Items.Add(words[i]);
                    }
                    else if (i <= 9)
                    {
                        LBoxRangomSecond.Items.Add(words[i]); 
                    }
                    else if ( i > 9)
                    {
                        LBoxRangomThree.Items.Add(words[i]);   
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Слова не были загруженны: " + ex.Message);
            }
        }

        private void загрузкаСписковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LBoxRangomFirst.Items.Count == 0 && LBoxRangomSecond.Items.Count == 0 && LBoxRangomThree.Items.Count == 0)
            {
                LoadFile();
            }
            else 
            {
                MessageBox.Show("Поля уже заполнены!");
            }
            
        }

        private void CopeItemTool_Click(object sender, EventArgs e)
        {
            TbxInput.Text = TbxGenerate.Text;
        }

        private void BtnDraftString_Click(object sender, EventArgs e)
        {
            if (LBoxMain.SelectedItem != null) 
            {
                TbxInput.Text = (string) LBoxMain.SelectedItem;
                LBoxRangomFirst.Enabled = false;
                LBoxRangomSecond.Enabled = false;
                LBoxRangomThree.Enabled = false;
                SelectedIndex = LBoxMain.SelectedIndex;
            }
            else if (LBoxRangomFirst.SelectedItem != null)
            {
                TbxInput.Text = (string) LBoxRangomFirst.SelectedItem;
                LBoxMain.Enabled = false;
                LBoxRangomSecond.Enabled = false;
                LBoxRangomThree.Enabled = false;
                SelectedIndex = LBoxRangomFirst.SelectedIndex;
            }
            else if (LBoxRangomSecond.SelectedItem != null)
            {
                TbxInput.Text = (string) LBoxRangomSecond.SelectedItem;
                LBoxRangomFirst.Enabled = false;
                LBoxMain.Enabled = false;
                LBoxRangomThree.Enabled = false;
                SelectedIndex = LBoxRangomSecond.SelectedIndex;            
            }
            else if (LBoxRangomThree.SelectedItem != null)
            {
                TbxInput.Text = (string) LBoxRangomThree.SelectedItem;
                LBoxRangomFirst.Enabled = false;
                LBoxRangomSecond.Enabled = false;
                LBoxMain.Enabled = false;
                SelectedIndex = LBoxRangomThree.SelectedIndex;
            }
            BtnSaveDraft.Visible = true;
        }

        private void DeleteStringItemTool_Click(object sender, EventArgs e)
        {
            LBoxMain.Items.Remove(LBoxMain.SelectedItem);
            LBoxRangomFirst.Items.Remove(LBoxRangomFirst.SelectedItem);
            LBoxRangomSecond.Items.Remove(LBoxRangomSecond.SelectedItem);
            LBoxRangomThree.Items.Remove(LBoxRangomThree.SelectedItem);
        }

        private void AddStringItemTool_Click(object sender, EventArgs e)
        {
            if (LBoxRangomFirst.SelectedItem != null) 
            {
                LBoxMain.Items.Add(LBoxRangomFirst.SelectedItem.ToString());
                LBoxRangomFirst.SelectedItem = null;
            }
            else if (LBoxRangomSecond.SelectedItem != null)
            {
                LBoxMain.Items.Add(LBoxRangomSecond.SelectedItem.ToString());
                LBoxRangomSecond.SelectedItem = null;
            }
            else if (LBoxRangomThree.SelectedItem != null)
            {
                LBoxMain.Items.Add(LBoxRangomThree.SelectedItem.ToString());
                LBoxRangomThree.SelectedItem = null;
            }
        }

        private void BtnSaveDraft_Click(object sender, EventArgs e)
        {
            if (LBoxMain.SelectedItem != null)
            {
                LBoxMain.Items[SelectedIndex] = TbxInput.Text;
                LBoxMain.ClearSelected();
                TbxInput.Text = "";
            }
            else if (LBoxRangomFirst.SelectedItem != null)
            {
                LBoxRangomFirst.Items[SelectedIndex] = TbxInput.Text;
                LBoxRangomFirst.ClearSelected();
                TbxInput.Text = "";
            }
            else if (LBoxRangomSecond.SelectedItem != null)
            {
                LBoxRangomSecond.Items[SelectedIndex] = TbxInput.Text;
                LBoxRangomSecond.ClearSelected();
                TbxInput.Text = "";
            }
            else if (LBoxRangomThree.SelectedItem != null)
            {
                LBoxRangomThree.Items[SelectedIndex] = TbxInput.Text;
                LBoxRangomThree.ClearSelected();
                TbxInput.Text = "";
            }
            BtnSaveDraft.Visible = false;
            LBoxMain.Enabled = true;
            LBoxRangomFirst.Enabled = true;
            LBoxRangomSecond.Enabled = true;
            LBoxRangomThree.Enabled = true;
        }

        private void BtnGenerator_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            TbxGenerate.Enabled = true;
            OnGenerateItemTool.Enabled = true;
            CopeItemTool.Enabled = true;
            TbxGenerate.Text = LBoxRangomFirst.Items[Random(ran)].ToString() + " ";
            TbxGenerate.Text += LBoxRangomSecond.Items[Random(ran)].ToString() + " ";
            TbxGenerate.Text += LBoxRangomThree.Items[Random(ran)].ToString();
        }

        public int Random(Random rand) 
        {            
            return rand.Next(5);  
        }

        private void ВыключитьГенерациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TbxGenerate.Enabled = false;
            TbxGenerate.Text = "";
            CopeItemTool.Enabled= false;
            OnGenerateItemTool.Enabled = false;
        }
    }
}
