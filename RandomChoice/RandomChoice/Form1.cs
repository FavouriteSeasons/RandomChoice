

using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Threading;

namespace RandomChoice
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Status.Text = "Initialization...";
            
            ProgressBar.Value = 10;
            ProgressBar.Style = ProgressBarStyle.Marquee;
            //Thread.Sleep(1000);
            ChoicecomboBox.SelectedIndex = 0;
            ChoicelistBox.Items.Clear();
            ProgressBar.Style = ProgressBarStyle.Continuous;
            ProgressBar.Value = 50;
            string[] ss = ChoicecomboBox.Items.Cast<string>().ToArray();
            ChoicelistBox.Items.AddRange(ss);
            ProgressBar.Value = 100;
            ChoicelistBox.SelectedIndex = 0;
            ProgressBar.Style = ProgressBarStyle.Continuous;
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 0;
            Status.Text= "Starting...";
            ProgressBar.Style = ProgressBarStyle.Marquee;
            Thread.Sleep(1000);
            Random rd =new Random();
            Status.Text = "Waiting...";
            ProgressBar.Style = ProgressBarStyle.Continuous;
            ProgressBar.Value = 50;
            int num=rd.Next(ChoicecomboBox.Items.Count);
            ProgressBar.Value = 67;
            Status.Text = "RandomNameber:"+num;
            ProgressBar.Value = 80;
            string st=ChoicecomboBox.GetItemText(ChoicecomboBox.Items[num]);
            ProgressBar.Value = 90;
            Status.Text = "Random result:"+st;
            ProgressBar.Value = 100;
            MessageBox.Show("Random result:" + st,"Finish!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 0;
            Status.Text = "ADD:" + StringBox.Text;
            ProgressBar.Value = 50;
            ChoicecomboBox.Items.Add(StringBox.Text);
                ChoicelistBox.Items.Clear();
                string[] ss = ChoicecomboBox.Items.Cast<string>().ToArray();
                ChoicelistBox.Items.AddRange(ss);
            if (ChoicecomboBox.Items.Count > 0)
            {
                ChoicecomboBox.SelectedIndex = 0;
                ChoicelistBox.SelectedIndex = 0;
            }
            ProgressBar.Value = 100;
            Thread.Sleep(100);
            Status.Text = "OK.";
        }

        private void DELButton_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 0;
            Status.Text = "Del:" + ChoicelistBox.Text;
            if (ChoicecomboBox.Items.Count > 0)
            {
                ChoicecomboBox.Items.Remove(ChoicelistBox.SelectedItem);
                //combobox.Items.Remove(combobox.SelectedItem);
            }
            ChoicelistBox.Items.Clear();
            string[] ss = ChoicecomboBox.Items.Cast<string>().ToArray();
            ChoicelistBox.Items.AddRange(ss);
            ProgressBar.Value = 50;
            if (ChoicecomboBox.Items.Count>0)
            {
                ChoicecomboBox.SelectedIndex = 0;
                ChoicelistBox.SelectedIndex = 0;
            }
            ProgressBar.Value = 100;
            Thread.Sleep(100);
            Status.Text = "OK.";
        }
    }
}