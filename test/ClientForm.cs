using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        #region проверки при вводе в поля
        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        delegate void RemoveLastChar();
        private void textBoxPassportID_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxPassportID.Text;
            RemoveLastChar remove = delegate
            {
                textBoxPassportID.Text = textBoxPassportID.Text.Remove(text.Length - 1);
                textBoxPassportID.SelectionStart = text.Length;
            };
            if (text.Length == 0)
                return;

            if (text.Length == 1)
                if (!(char.IsDigit(text[0]) || (text[0] >= 'A' && text[0] <= 'Z')))
                    remove();

            if (text.Length == 2)
            {
                if (char.IsDigit(text[0]))
                    if (!(char.IsDigit(text[1])))
                        remove();
                if (text[0] >= 'A' && text[0] <= 'Z')
                    if (!(text[1] >= 'A' && text[1] <= 'Z'))
                        remove();
            }

            if (text.Length > 2 && text.Length <= 8)
                if (!(char.IsDigit(text[text.Length - 1])))
                    remove();

            if (text.Length == 9)
            {
                if (text[0] >= 'A' && text[0] <= 'Z')
                    remove();
                if (!(char.IsDigit(text[text.Length - 1])))
                    remove();
            }

            if (text.Length > 9)
                remove();
        }
        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxPhoneNumber.Text;
            RemoveLastChar remove = delegate
            {
                textBoxPhoneNumber.Text = textBoxPhoneNumber.Text.Remove(text.Length - 1);
                textBoxPhoneNumber.SelectionStart = text.Length;
            };

            if (text.Length == 1)
                if (!(text[0] == '+'))
                    remove();

            if (text.Length > 1)
                if (!char.IsDigit(text[text.Length - 1]))
                    remove();
        }
        #endregion
        public EntityClientPL Client { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Client==null)
                    Client = new EntityClientPL(textBoxPassportID.Text);
                Client.PassportID = textBoxPassportID.Text;
                Client.FirstName = textBoxFirstName.Text;
                Client.LastName = textBoxLastName.Text;
                Client.PhoneNumber = textBoxPhoneNumber.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Client = null;
                return;
            }
            this.Close();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            if (Client!= null)
            {
                textBoxFirstName.Text = Client.FirstName;
                textBoxLastName.Text = Client.LastName;
                textBoxPassportID.Text = Client.PassportID;
                textBoxPhoneNumber.Text = Client.PhoneNumber;
            }
        }
    }
}
