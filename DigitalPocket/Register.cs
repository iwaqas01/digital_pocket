using DigitalPocket.DataBaseFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalPocket
{
    public partial class Register : Form
    {
        DigitalPocketContext _context = null;

        public Register()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (_context = new DigitalPocketContext())
            {
                if(_context.PocketUser.Any(x => x.Username == textBox1.Text))
                {
                    MessageBox.Show("User already exsist");
                }
                else
                {
                   if(String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text)|| String.IsNullOrEmpty(textBox4.Text))
                    {
                        MessageBox.Show("One of the required field is missing");
                    }
                   else
                    {
                        PocketUser pu = new PocketUser()
                        {
                            Email = textBox3.Text,
                            Password = textBox2.Text,
                            Username = textBox1.Text

                        };
                        _context.PocketUser.Add(pu);
                        _context.SaveChanges();
                        UWallet uw = new UWallet()
                        {
                            Ammount = Convert.ToDecimal(textBox4.Text),
                            Date = DateTime.Now,
                            UserId = pu.Id

                        };
                        _context.UWallet.Add(uw);
                        _context.SaveChanges();

                        MessageBox.Show("Account Created please login with your login details");
                        this.Close();
                    }
                }
            }
        }
    }
}
