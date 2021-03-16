using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Lists
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        List<string> heroes = new List<string>();
        Random generator = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = numbers;
            heroes.Add("Superman");
            heroes.Add("Batman");
            lstHeroes.DataSource = heroes;
        }

        private void btnSortNumbers_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = "Status : Sorted";
        }

        private void btnSortHeroes_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = "Status : Sorted";

        }

        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            lstNumbers.DataSource = null;
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = numbers;
            lblStatus.Text = "Status : New number list";

        }

        private void btnNewHeroes_Click(object sender, EventArgs e)
        {
            heroes.Clear();
            lstHeroes.DataSource = null;
            heroes.Add("Superman");
            heroes.Add("Batman");
            lstHeroes.DataSource = heroes;
            lblStatus.Text = "Status : New hero list";
        }

        private void btnRemoveNumbers_Click(object sender, EventArgs e)
        {
            if (numbers.Count > 0)
            {
                numbers.RemoveAt(lstNumbers.SelectedIndex);
                lstNumbers.DataSource = null;
                lstNumbers.DataSource = numbers;
            }
            lblStatus.Text = "Status : Number removed";
        }

        private void btnRemoveAllNumbers_Click(object sender, EventArgs e)
        {
           if (numbers.Count > 0)
            {

                while (numbers.Remove((int)lstNumbers.SelectedItem) == true)
                    numbers.Remove((int)lstNumbers.SelectedItem);
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = "Status : All instances of the number removed";   
           }
        }

        private void btnRemoveHero_Click(object sender, EventArgs e)
        {
            if (heroes.Count > 0)
            {
                if (heroes.Contains(txtRemoveHero.Text))
                {
                    heroes.Remove((string)txtRemoveHero.Text);
                    lblStatus.Text = "Status : Hero removed";
                }
                else
                    lblStatus.Text = "Status : Hero not found";
                lstHeroes.DataSource = null;
                lstHeroes.DataSource = heroes;
            }
        }

        private void btnAddHero_Click(object sender, EventArgs e)
        {
            if ((txtAddHero.Text).Trim() != "" && heroes.Contains(txtAddHero.Text.Trim()))
                lblStatus.Text = "Status : Hero already listed";
            else if ((txtAddHero.Text).Trim() != "")
            {
                heroes.Add(txtAddHero.Text.Trim());
                lstHeroes.DataSource = null;
                lstHeroes.DataSource = heroes;
                lblStatus.Text = ("Status : Name added");
            }
            else
                lblStatus.Text = ("Status : Enter a valid name");
        }
    }           
}
