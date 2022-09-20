using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Difficulty_Settings
{
    public partial class Form1 : Form
    {
        //global variables
        string heroName;
        string difficultyLevel;
        public Form1()
        {
            InitializeComponent();
        }
        private void easyButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Yellow;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;  
            heroName = nameInput.Text; 
            difficultyLevel = easyButton.Text;
        }
        private void mediumButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Orange;
            hardButton.BackColor = Color.Black;
            heroName = nameInput.Text; 
            difficultyLevel = mediumButton.Text;
        }
        private void hardButton_Click(object sender, EventArgs e)
        {

            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Red; 
            heroName = nameInput.Text; 
            difficultyLevel = hardButton.Text;
        }
        private void beginButton_Click(object sender, EventArgs e)
        {
            heroName = nameInput.Text; 
            outputLabel.Text = $"Welcome {heroName}";
            outputLabel.Text += $"\nGo forth brave warrior and face the {difficultyLevel} path!";
        }
    }
}
