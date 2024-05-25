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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            Data.Instance.Inizialize();
        }

        public bool CheckLogin(string name)
        {
            foreach (Client cl in Data.Instance.clients)
            {
                if (cl.Login == name) return false;
            }
            return true;
        }

        private void CreateClientButton_Click(object sender, EventArgs e)
        {
            if (CheckLogin(LoginTextBox.Text))
            {
                Data.Instance.clients.Add(new Client(
                    textBox1.Text,
                    textBox2.Text,
                    "",
                    "",
                    LoginTextBox.Text,
                    textBox4.Text,
                    maskedTextBox1.Text,
                    Data.Instance.posts[0]
                    ));

                Data.Instance.Inizialize();
                Hide();
            }
            else
            {
                Console.WriteLine("Все не гуд");
            }
        }
    }
}
