using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Models;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            foreach (Client cl in Data.Instance.clients)
            {
                Console.WriteLine(cl.Name);
                if ((cl.Login == LoginTextBox.Text) && (cl.Password == PasswordTextBox.Text))
                {
                    ErrorLabel.Text = "";
                    if (cl.Post.ToString() == "Администратор")
                    {
                        adminPanel adminPanel = new adminPanel();
                        adminPanel.ShowDialog();
                    }
                    else
                    {
                        Orders orders = new Orders();
                        orders.ShowDialog();
                    }
                }
                else
                {
                    ErrorLabel.Text = "Данные введены неверно";
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Data.Instance.Inizialize();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.ShowDialog();
        }
    }
}
