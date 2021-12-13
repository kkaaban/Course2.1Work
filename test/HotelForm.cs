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
    public partial class HotelForm : Form
    {
        public HotelForm()
        {
            InitializeComponent();
        }

        private void textBoxCountRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8)
                e.Handled = true;
        }
        public EntityHotelPL Hotel { get; private set; }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var rooms = new List<EntityRoomPL>();
                for (int i = 0; i < int.Parse(textBoxCountRoom.Text); i++)
                    rooms.Add(new EntityRoomPL(i.ToString()) { Price = decimal.Parse(textBoxPrice.Text) });
                Hotel = new EntityHotelPL(textBoxName.Text, rooms);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Hotel = null;
                return;
            }
            this.Close();
        }
    }
}
