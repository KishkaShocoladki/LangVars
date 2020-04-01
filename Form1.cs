using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> RusWords = new Dictionary<string, string>();
        Dictionary<string, string> EngWords = new Dictionary<string, string>();
        Dictionary<string, string> UkrWords = new Dictionary<string, string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            RusWords.Add("Выберите Язык", "Выберите Язык");
            EngWords.Add("Выберите Язык", "Choose Language");
            UkrWords.Add("Выберите Язык", "Выберiте Язiк");
            RusWords.Add("Выбери Язык", "Выбери Язык");
            EngWords.Add("Выбери Язык", "Choose Tongue");
            UkrWords.Add("Выбери Язык", "Выберiте Язик");
            RusWords.Add("Выберите Сложность", "Выберите Сложность");
            EngWords.Add("Выберите Сложность", "Choose Difficulty");
            UkrWords.Add("Выберите Сложность", "Выберiте Сложность");
            RusWords.Add("Новичок", "Новичок");
            EngWords.Add("Новичок", "Beginner");
            UkrWords.Add("Новичок", "Новiчок");
            RusWords.Add("Любитель", "Любитель");
            EngWords.Add("Любитель", "Amateur");
            UkrWords.Add("Любитель", "Любiтель");
            RusWords.Add("Профи", "Профи");
            EngWords.Add("Профи", "Pro");
            UkrWords.Add("Профи", "Профi");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label1.Text = EngWords["Выберите Язык"];
            label2.Text = EngWords["Выбери Язык"];
            label3.Text = EngWords["Выберите Сложность"];
            button1.Text = EngWords["Новичок"];
            button2.Text = EngWords["Любитель"];
            button3.Text = EngWords["Профи"];
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.Text = RusWords["Выберите Язык"];
            label2.Text = RusWords["Выбери Язык"];
            label3.Text = RusWords["Выберите Сложность"];
            button1.Text = RusWords["Новичок"];
            button2.Text = RusWords["Любитель"];
            button3.Text = RusWords["Профи"];
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = UkrWords["Выберите Язык"];
            label2.Text = UkrWords["Выбери Язык"];
            label3.Text = UkrWords["Выберите Сложность"];
            button1.Text = UkrWords["Новичок"];
            button2.Text = UkrWords["Любитель"];
            button3.Text = UkrWords["Профи"];
        }
    }
}
