using Entities;
using Mappers;
using ServiceBLL;
using System.Linq;
using System.IO;
using EntitiesBLL;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pathWorkDirectory = @"C:\ProgramData\Hotels";
            UpdateComboBoxHotels();
        }
        string pathWorkDirectory;
        void UpdateComboBoxHotels()
        {
            comboBoxHotels.Items.Clear();
            if (!Directory.Exists(pathWorkDirectory))
            {
                Directory.CreateDirectory(pathWorkDirectory);
                return;
            }
            string[] jsons = Directory.GetFiles(pathWorkDirectory, "*.json");
            foreach (var json in jsons)
            {
                var service = new ServiceHotelBLL(json);
                string hotelName = service.GetTitle();
                if (hotelName != null)
                {
                    comboBoxHotels.Items.Add(hotelName);
                }
            }
        }
        public ServiceClientBLL ServiceClient
        {
            get
            {
                int id = comboBoxHotels.SelectedIndex;
                if (id == -1)
                    return null;
                string hotelName = comboBoxHotels.Items[id].ToString();
                string path = pathWorkDirectory + @"\" + hotelName + ".json";
                return new ServiceClientBLL(path);
            }
        }
        public ServiceDeclarationBLL ServiceDeclaration
        {
            get
            {
                int id = comboBoxHotels.SelectedIndex;
                if (id == -1)
                    return null;
                string hotelName = comboBoxHotels.Items[id].ToString();
                string path = pathWorkDirectory + @"\" + hotelName + ".json";
                return new ServiceDeclarationBLL(path);
            }
        }
        public ServiceHotelBLL ServiceHotel
        {
            get
            {
                int id = comboBoxHotels.SelectedIndex;
                if (id == -1)
                    return null;
                string hotelTitle = comboBoxHotels.Items[id].ToString();
                string path = pathWorkDirectory + @"\" + hotelTitle + ".json";
                return new ServiceHotelBLL(path);
            }
        }
        #region placeholders
        private void textBoxIdClient1_Enter(object sender, EventArgs e)
        {
            if (textBoxIdClient1.Text=="0")
            {
                textBoxIdClient1.ForeColor = Color.Black;
                textBoxIdClient1.Text = "";
            }
        }
        private void textBoxIdClient1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdClient1.Text))
            {
                textBoxIdClient1.ForeColor = Color.Gray;
                textBoxIdClient1.Text = "0";
            }
        }
        private void textBoxFirstLastNameSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxFirstLastNameSearch.Text == "ім'я або прізвище")
            {
                textBoxFirstLastNameSearch.ForeColor = Color.Black;
                textBoxFirstLastNameSearch.Text = "";
            }
        }
        private void textBoxFirstLastNameSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirstLastNameSearch.Text))
            {
                textBoxFirstLastNameSearch.ForeColor = Color.Gray;
                textBoxFirstLastNameSearch.Text = "ім'я або прізвище";
            }
        }
        private void textBoxNumRoom1_Enter(object sender, EventArgs e)
        {
            if (textBoxNumRoom1.Text == "№ номера")
            {
                textBoxNumRoom1.ForeColor = Color.Black;
                textBoxNumRoom1.Text = "";
            }
        }
        private void textBoxNumRoom1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNumRoom1.Text))
            {
                textBoxNumRoom1.ForeColor = Color.Gray;
                textBoxNumRoom1.Text = "№ номера";
            }
        }
        private void textBoxIdClient2_Enter(object sender, EventArgs e)
        {
            if (textBoxIdClient2.Text == "id клієнта")
            {
                textBoxIdClient2.ForeColor = Color.Black;
                textBoxIdClient2.Text = "";
            }
        }
        private void textBoxIdClient2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdClient2.Text))
            {
                textBoxIdClient2.ForeColor = Color.Gray;
                textBoxIdClient2.Text = "id клієнта";
            }
        }
        private void textBoxIdClient3_Enter(object sender, EventArgs e)
        {
            if (textBoxIdClient3.Text == "id клієнта")
            {
                textBoxIdClient3.ForeColor = Color.Black;
                textBoxIdClient3.Text = "";
            }
        }
        private void textBoxIdClient3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdClient3.Text))
            {
                textBoxIdClient3.ForeColor = Color.Gray;
                textBoxIdClient3.Text = "id клієнта";
            }
        }
        private void textBoxNumRoom2_Enter(object sender, EventArgs e)
        {
            if (textBoxNumRoom2.Text == "№ номера")
            {
                textBoxNumRoom2.ForeColor = Color.Black;
                textBoxNumRoom2.Text = "";
            }
        }
        private void textBoxNumRoom2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNumRoom2.Text))
            {
                textBoxNumRoom2.ForeColor = Color.Gray;
                textBoxNumRoom2.Text = "№ номера";
            }
        }
        private void textBoxIdDeclaration_Enter(object sender, EventArgs e)
        {
            if (textBoxIdDeclaration.Text == "id заявки")
            {
                textBoxIdDeclaration.ForeColor = Color.Black;
                textBoxIdDeclaration.Text = "";
            }
        }
        private void textBoxIdDeclaration_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdDeclaration.Text))
            {
                textBoxIdDeclaration.ForeColor = Color.Gray;
                textBoxIdDeclaration.Text = "id заявки";
            }
        }
        #endregion
        #region проверки в момент ввода в поля
        private void textBoxIdClient1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8)
                e.Handled = true;
        }
        private void textBoxNumRoom1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8)
                e.Handled = true;
        }
        private void textBoxIdClient2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8)
                e.Handled = true;
        }
        private void textBoxIdClient3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8)
                e.Handled = true;
        }
        private void textBoxNumRoom2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8)
                e.Handled = true;
        }
        private void textBoxIdDeclaration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8)
                e.Handled = true;
        }
        private void textBoxFirstLastNameSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        #endregion
        EntityClientPL GetClient()
        {
            var form = new ClientForm();
            form.ShowDialog();
            return form.Client;
        }
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            if (ServiceClient == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            EntityClientPL client = GetClient();
            if (client == null)
                return;
            try
            {
                ServiceClient.Add(client.ClientPLtoBLL());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка!\n"+ex.Message);
                buttonAddClient_Click(sender, e);
            }
            labelHotel.Text = ServiceHotel.GetInfo(DateTime.Now);
        }
        EntityHotelPL GetHotel()
        {
            var form = new HotelForm();
            form.ShowDialog();
            return form.Hotel;
        }
        private void buttonAddHotel_Click(object sender, EventArgs e)
        {
            EntityHotelPL hotel = GetHotel();
            if (hotel == null)
                return;
            var service = new ServiceHotelBLL(pathWorkDirectory);
            try
            {
                service.Create(hotel.HotelPLtoBLL());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка!\n"+ex.Message);
                return;
            }
            UpdateComboBoxHotels();
        }

        private void buttonDeleteHotel_Click(object sender, EventArgs e)
        {
            if (ServiceHotel == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            ServiceHotel.Delete();
            UpdateComboBoxHotels();
            labelHotel.Text = "";
            comboBoxHotels.Text = "";
        }

        private void buttonInfoHotels_Click(object sender, EventArgs e)
        {
            string info = "";
            for (int i = 0; i < comboBoxHotels.Items.Count; i++)
            {
                string hotelName = comboBoxHotels.Items[i].ToString();
                string path = pathWorkDirectory + @"\" + hotelName + ".json";
                var service = new ServiceHotelBLL(path);
                info += service.GetInfo(DateTime.Now)+"\n\n";
            }
            labelInfo.Text = info;
        }

        private void comboBoxHotels_SelectedValueChanged(object sender, EventArgs e)
        {
            labelHotel.ForeColor = Color.Black;
            labelHotel.Text = ServiceHotel.GetInfo(DateTime.Now);
        }

        private void buttonInfoClients_Click(object sender, EventArgs e)
        {
            if (ServiceClient ==null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            labelInfo.Text = ServiceClient.GetInfo();
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            if (textBoxIdClient1.Text == "" | textBoxIdClient1.Text == "0")
                return;
            if (ServiceClient == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            try
            {
                ServiceClient.DeleteById(int.Parse(textBoxIdClient1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка! \n"+ex.Message);
            }
            labelHotel.Text = ServiceHotel.GetInfo(DateTime.Now);
        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            if (textBoxIdClient1.Text == "" | textBoxIdClient1.Text == "0")
                return;
            if (ServiceClient == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            int id;
            var form = new ClientForm();
            try
            {
                id = int.Parse(textBoxIdClient1.Text);
                form.Client = ServiceClient.GetClientById(id).ClientBLLtoPL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка!\n"+ex.Message);
                return;
            }
            form.ShowDialog();
            if (form.Client == null)
                return;
            EntityClientPL client = form.Client;
            ServiceClient.UpdateById(id, client.ClientPLtoBLL());
        }

        private void buttonInfoByIdClient_Click(object sender, EventArgs e)
        {
            if (textBoxIdClient1.Text == ""| textBoxIdClient1.Text == "0")
                return;
            if (ServiceClient == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            try
            {
                int id = int.Parse(textBoxIdClient1.Text);
                labelInfo.Text = ServiceClient.GetInfoById(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка! \n"+ex.Message);
            }
        }

        private void labelInfo_TextChanged(object sender, EventArgs e)
        {
            labelInfo.ForeColor = Color.Black;
        }

        public ServiceRoomBLL ServiceRoom
        {
            get
            {
                int id = comboBoxHotels.SelectedIndex;
                if (id == -1)
                    return null;
                string hotelName = comboBoxHotels.Items[id].ToString();
                string path = pathWorkDirectory + @"\" + hotelName + ".json";
                return new ServiceRoomBLL(path);
            }
        }
        private void buttonSettle_Click(object sender, EventArgs e)
        {
            if (ServiceClient == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            if (textBoxNumRoom1.Text == "№ номера" || textBoxNumRoom1.Text == "")
                return;
            if (textBoxIdClient2.Text == "id клієнта"|| textBoxIdClient2.Text == "")
                return;
            DateTime from = DateTime.Parse(dateTimePickerFrom1.Value.ToShortDateString());
            DateTime to = DateTime.Parse(dateTimePickerTo1.Value.ToShortDateString());
            DateTime now = DateTime.Parse(DateTime.Now.ToShortDateString());
            if (to < now)
            {
                MessageBox.Show("Щоб заселити, дата виселення не повинна бути минулою за "+ DateTime.Now.ToShortDateString());
                return;
            }
            if (from> now)
            {
                MessageBox.Show("Щоб заселити, дата заселення не повинна бути більшою за "+ DateTime.Now.ToShortDateString());
                return;
            }
            try
            {
                ServiceClient.ToRent(int.Parse(textBoxIdClient2.Text),
                    ServiceRoom.GetRoomByNumber(textBoxNumRoom1.Text),
                from, to);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка!\n"+ex.Message);
                return;
            }
            labelHotel.Text = ServiceHotel.GetInfo(DateTime.Now);
            MessageBox.Show("До сплати: "+
                ServiceRoom.GetPriceRent(ServiceRoom.GetRoomByNumber(textBoxNumRoom1.Text), from, to).ToString());
        }

        private void buttonBooking_Click(object sender, EventArgs e)
        {
            if (ServiceClient == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            if (textBoxNumRoom1.Text == "№ номера" || textBoxNumRoom1.Text == "")
                return;
            if (textBoxIdClient2.Text == "id клієнта" || textBoxIdClient2.Text == "")
                return;
            DateTime from = DateTime.Parse(dateTimePickerFrom1.Value.ToShortDateString());
            DateTime to = DateTime.Parse(dateTimePickerTo1.Value.ToShortDateString());
            DateTime now = DateTime.Parse(DateTime.Now.ToShortDateString());
            if (from <= now)
            {
                MessageBox.Show("Щоб забронювати, дата заселення повинна бути більшою за " + DateTime.Now.ToShortDateString());
                return;
            }
            if (to <= now)
            {
                MessageBox.Show("Щоб забронювати, дата виселення повинна бути більшою за " + DateTime.Now.ToShortDateString());
                return;
            }
            try
            {
                ServiceClient.ToRent(int.Parse(textBoxIdClient2.Text),
                    ServiceRoom.GetRoomByNumber(textBoxNumRoom1.Text),
                    from, to);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка!\n" + ex.Message);
                return;
            }
            labelHotel.Text = ServiceHotel.GetInfo(DateTime.Now);
            MessageBox.Show("До сплати: " +
                ServiceRoom.GetPriceRent(ServiceRoom.GetRoomByNumber(textBoxNumRoom1.Text), from, to).ToString());
        }

        private void buttonUnSettle_Click(object sender, EventArgs e)
        {
            if (textBoxIdClient3.Text == "id клієнта" || textBoxIdClient3.Text == "")
                return;
            if (ServiceClient == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            try
            {
                ServiceClient.RemoveRent(int.Parse(textBoxIdClient3.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка!\n" + ex.Message);
                return;
            }
            labelHotel.Text = ServiceHotel.GetInfo(DateTime.Now);
        }

        private void buttonUnbooking_Click(object sender, EventArgs e)
        {
            if (textBoxIdClient3.Text == "id клієнта" || textBoxIdClient3.Text == "")
                return;
            if (ServiceClient == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            try
            {
                ServiceClient.RemoveRent(int.Parse(textBoxIdClient3.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка!\n" + ex.Message);
                return;
            }
            labelHotel.Text = ServiceHotel.GetInfo(DateTime.Now);
        }

        private void buttonListRoomAll_Click(object sender, EventArgs e)
        {
            if (ServiceRoom == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            labelInfo.Text = ServiceRoom.GetInfo(DateTime.Now);
        }
        private void buttonListRoomFree_Click(object sender, EventArgs e)
        {
            if (ServiceRoom == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            labelInfo.Text = ServiceRoom.GetInfoFree(DateTime.Now);
        }

        private void buttonListRoomSettled_Click(object sender, EventArgs e)
        {
            if (ServiceRoom==null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            labelInfo.Text = ServiceRoom.GetInfoSettle(DateTime.Now);
        }

        private void buttonListRoomBooking_Click(object sender, EventArgs e)
        {
            if (ServiceRoom == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            labelInfo.Text = ServiceRoom.GetInfoBooking(DateTime.Now);
        }

        private void buttonRoomInfo_Click(object sender, EventArgs e)
        {
            if (ServiceRoom == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            try
            {
                labelInfo.Text = ServiceRoom.GetInfoByNumber(DateTime.Now, textBoxNumRoom2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка!\n" + ex.Message);
                return;
            }
        }

        private void buttonFirstNameSort_Click(object sender, EventArgs e)
        {
            if (ServiceClient == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            var clients = new List<EntityClientPL>();
            foreach (var client in ServiceClient.GetListClient())
            {
                clients.Add(client.ClientBLLtoPL());
            }
            string info = "";
            clients.Sort((a, b) => a.FirstName.CompareTo(b.FirstName));
            foreach (var client in clients)
            {
                info += $"ID: {client.ID}\n" +
                    $"Ім`я: {client.FirstName}\n" +
                    $"Прізвище: {client.LastName}\n" +
                    $"Паспорт: {client.PassportID}\n" +
                    $"Телефон: {client.PhoneNumber}\n\n";
            }
            labelInfo.Text = info;
        }

        private void buttonLastNameSort_Click(object sender, EventArgs e)
        {
            if (ServiceClient == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            var clients = ServiceClient.GetListClient().ListClientBLLtoPL();
            string info = "";
            clients.Sort((a, b) => a.LastName.CompareTo(b.LastName));
            labelInfo.Text = GetInfoListClient(clients);
        }
        string GetInfoListClient(List<EntityClientPL> clients)
        {
            string info = "";
            foreach (var client in clients)
            {
                info += $"ID: {client.ID}\n" +
                    $"Ім`я: {client.FirstName}\n" +
                    $"Прізвище: {client.LastName}\n" +
                    $"Паспорт: {client.PassportID}\n" +
                    $"Телефон: {client.PhoneNumber}\n\n";
            }
            return info;
        }
        private void buttonFirstLastNameSearch_Click(object sender, EventArgs e)
        {
            if (ServiceClient == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            if (textBoxFirstLastNameSearch.Text == "ім'я або прізвище"|| textBoxFirstLastNameSearch.Text == "")
                return;
            var listFirstName = ServiceClient.GetListByFirstName(textBoxFirstLastNameSearch.Text);
            var listLastName = ServiceClient.GetListByLastName(textBoxFirstLastNameSearch.Text);
            labelInfo.Text = GetInfoListClient(listFirstName.ListClientBLLtoPL());
            labelInfo.Text +="\n"+ GetInfoListClient(listLastName.ListClientBLLtoPL());
        }


        private void buttonSealDeclaration_Click(object sender, EventArgs e)
        {
            if (ServiceDeclaration == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            if (textBoxIdDeclaration.Text == "id заявки" || textBoxIdDeclaration.Text == "")
                return;
            var form = new SaveFileDialog();
            if (form.ShowDialog() == DialogResult.Cancel)
                return;
            string path = form.FileName;
            ServiceDeclaration.CreateFile(int.Parse(textBoxIdDeclaration.Text), path);
        }

        private void buttonDeleteDeclaration_Click(object sender, EventArgs e)
        {
            if (ServiceDeclaration == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            if (textBoxIdDeclaration.Text == "id заявки" || textBoxIdDeclaration.Text == "")
                return;
            ServiceDeclaration.Delete(int.Parse(textBoxIdDeclaration.Text));
        }

        private void buttonViewDeclarationByDate_Click(object sender, EventArgs e)
        {
            if (ServiceDeclaration == null)
            {
                MessageBox.Show("Спочатку оберіть або створіть готель");
                return;
            }
            var declarations = new List<EntityDeclarationPL>();
            foreach (var declaration in ServiceDeclaration.GetListFromTo(dateTimePickerFrom2.Value, dateTimePickerTo2.Value))
            {
                declarations.Add(declaration.DeclarationBLLtoPL());
            }
            string info = "";
            foreach (var declaration in declarations)
            {
                info += $"ID: {declaration.ID}\n" +
                    $"{declaration.TextDeclaration}\n\n";
            }
            labelInfo.Text = info;
        }
    }
}