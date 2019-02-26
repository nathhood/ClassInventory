using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // create a List to store all inventory objects
        List<Player> players = new List<Player>();


        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // TODO - gather all information from screen 
            string name, team, position;
            int age;

            name = c.Text;
            team = teamInput.Text;
            position = positionInput.Text;
            age = Convert.ToInt32(ageInput.Text);

            // TODO - create object with gathered information
            Player p = new Player(name, team, position, age);

            // TODO - add object to global list
            players.Add(p);

            // TODO - display message to indicate addition made
            label1.Text = c.Text + " added";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            
            // TODO - if object is in list remove it
            foreach (Player p in players)
            {
                if (p.name == removeInput.Text)
                {
                    // TODO - display message to indicate deletion made
                    label1.Text = removeInput.Text + " removed";
                    
                    players.Remove(p);
                    return;
                }

                else
                {
                    label1.Text = removeInput.Text + " is not in the database";
                    return;
                }
            }
            label1.Text = "nothing is in the database";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // TODO - if object entered exists in list show it
            foreach (Player p in players)
            {
                if (p.name == textBox1.Text)
                {
                    // TODO - display message to indicate deletion made
                    label1.Text = p.name + " ";
                    label1.Text += p.age + " ";
                    label1.Text += p.team + " ";
                    label1.Text += p.position;
                    return;
                }

            }
            // TODO - else show not found message
            textBox1.Text = "nothing is in the database";
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // TODO - show all objects in list
            label1.Text = "";

            for (int i = 0; i < players.Count; i++)
            {
                label1.Text += players[i].name + " " +
                    players[i].team + " " +
                    players[i].position + " " +
                    players[i].age + "\n";
            }
        }
    }
}
