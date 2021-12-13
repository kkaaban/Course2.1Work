namespace test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonInfoHotels = new System.Windows.Forms.Button();
            this.buttonDeleteHotel = new System.Windows.Forms.Button();
            this.buttonAddHotel = new System.Windows.Forms.Button();
            this.comboBoxHotels = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonListRoomBooking = new System.Windows.Forms.Button();
            this.buttonListRoomSettled = new System.Windows.Forms.Button();
            this.buttonListRoomFree = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonListRoomAll = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelHotel = new System.Windows.Forms.Label();
            this.dateTimePickerFrom2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonViewDeclarationByDate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdClient1 = new System.Windows.Forms.TextBox();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.buttonInfoByIdClient = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonFirstLastNameSearch = new System.Windows.Forms.Button();
            this.textBoxFirstLastNameSearch = new System.Windows.Forms.TextBox();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonLastNameSort = new System.Windows.Forms.Button();
            this.buttonFirstNameSort = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonInfoClients = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonDeleteDeclaration = new System.Windows.Forms.Button();
            this.buttonSealDeclaration = new System.Windows.Forms.Button();
            this.textBoxIdDeclaration = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonBooking = new System.Windows.Forms.Button();
            this.buttonSettle = new System.Windows.Forms.Button();
            this.textBoxNumRoom1 = new System.Windows.Forms.TextBox();
            this.textBoxIdClient2 = new System.Windows.Forms.TextBox();
            this.dateTimePickerFrom1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.buttonUnbooking = new System.Windows.Forms.Button();
            this.buttonUnSettle = new System.Windows.Forms.Button();
            this.textBoxIdClient3 = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonRoomInfo = new System.Windows.Forms.Button();
            this.textBoxNumRoom2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonInfoHotels);
            this.panel1.Controls.Add(this.buttonDeleteHotel);
            this.panel1.Controls.Add(this.buttonAddHotel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 30);
            this.panel1.TabIndex = 0;
            // 
            // buttonInfoHotels
            // 
            this.buttonInfoHotels.AutoSize = true;
            this.buttonInfoHotels.Location = new System.Drawing.Point(261, 0);
            this.buttonInfoHotels.Name = "buttonInfoHotels";
            this.buttonInfoHotels.Size = new System.Drawing.Size(144, 30);
            this.buttonInfoHotels.TabIndex = 2;
            this.buttonInfoHotels.Text = "інф. про всі готелі";
            this.buttonInfoHotels.UseVisualStyleBackColor = true;
            this.buttonInfoHotels.Click += new System.EventHandler(this.buttonInfoHotels_Click);
            // 
            // buttonDeleteHotel
            // 
            this.buttonDeleteHotel.AutoSize = true;
            this.buttonDeleteHotel.Location = new System.Drawing.Point(122, 0);
            this.buttonDeleteHotel.Name = "buttonDeleteHotel";
            this.buttonDeleteHotel.Size = new System.Drawing.Size(133, 30);
            this.buttonDeleteHotel.TabIndex = 1;
            this.buttonDeleteHotel.Text = "видалити готель";
            this.buttonDeleteHotel.UseVisualStyleBackColor = true;
            this.buttonDeleteHotel.Click += new System.EventHandler(this.buttonDeleteHotel_Click);
            // 
            // buttonAddHotel
            // 
            this.buttonAddHotel.AutoSize = true;
            this.buttonAddHotel.Location = new System.Drawing.Point(0, 0);
            this.buttonAddHotel.Name = "buttonAddHotel";
            this.buttonAddHotel.Size = new System.Drawing.Size(116, 30);
            this.buttonAddHotel.TabIndex = 0;
            this.buttonAddHotel.Text = "додати готель";
            this.buttonAddHotel.UseVisualStyleBackColor = true;
            this.buttonAddHotel.Click += new System.EventHandler(this.buttonAddHotel_Click);
            // 
            // comboBoxHotels
            // 
            this.comboBoxHotels.FormattingEnabled = true;
            this.comboBoxHotels.Location = new System.Drawing.Point(12, 48);
            this.comboBoxHotels.Name = "comboBoxHotels";
            this.comboBoxHotels.Size = new System.Drawing.Size(151, 28);
            this.comboBoxHotels.TabIndex = 1;
            this.comboBoxHotels.SelectedValueChanged += new System.EventHandler(this.comboBoxHotels_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.labelInfo);
            this.panel2.Location = new System.Drawing.Point(446, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 487);
            this.panel2.TabIndex = 2;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.ForeColor = System.Drawing.Color.Gray;
            this.labelInfo.Location = new System.Drawing.Point(3, 3);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(99, 20);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Інформація...";
            this.labelInfo.TextChanged += new System.EventHandler(this.labelInfo_TextChanged);
            // 
            // buttonListRoomBooking
            // 
            this.buttonListRoomBooking.AutoSize = true;
            this.buttonListRoomBooking.Location = new System.Drawing.Point(311, 23);
            this.buttonListRoomBooking.Name = "buttonListRoomBooking";
            this.buttonListRoomBooking.Size = new System.Drawing.Size(113, 30);
            this.buttonListRoomBooking.TabIndex = 28;
            this.buttonListRoomBooking.Text = "броньованих";
            this.buttonListRoomBooking.UseVisualStyleBackColor = true;
            this.buttonListRoomBooking.Click += new System.EventHandler(this.buttonListRoomBooking_Click);
            // 
            // buttonListRoomSettled
            // 
            this.buttonListRoomSettled.AutoSize = true;
            this.buttonListRoomSettled.Location = new System.Drawing.Point(226, 23);
            this.buttonListRoomSettled.Name = "buttonListRoomSettled";
            this.buttonListRoomSettled.Size = new System.Drawing.Size(82, 30);
            this.buttonListRoomSettled.TabIndex = 27;
            this.buttonListRoomSettled.Text = "зайнятих";
            this.buttonListRoomSettled.UseVisualStyleBackColor = true;
            this.buttonListRoomSettled.Click += new System.EventHandler(this.buttonListRoomSettled_Click);
            // 
            // buttonListRoomFree
            // 
            this.buttonListRoomFree.AutoSize = true;
            this.buttonListRoomFree.Location = new System.Drawing.Point(151, 23);
            this.buttonListRoomFree.Name = "buttonListRoomFree";
            this.buttonListRoomFree.Size = new System.Drawing.Size(72, 30);
            this.buttonListRoomFree.TabIndex = 26;
            this.buttonListRoomFree.Text = "вільних";
            this.buttonListRoomFree.UseVisualStyleBackColor = true;
            this.buttonListRoomFree.Click += new System.EventHandler(this.buttonListRoomFree_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(112, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Список номерів:";
            // 
            // buttonListRoomAll
            // 
            this.buttonListRoomAll.AutoSize = true;
            this.buttonListRoomAll.Location = new System.Drawing.Point(102, 23);
            this.buttonListRoomAll.Name = "buttonListRoomAll";
            this.buttonListRoomAll.Size = new System.Drawing.Size(44, 30);
            this.buttonListRoomAll.TabIndex = 25;
            this.buttonListRoomAll.Text = "усіх";
            this.buttonListRoomAll.UseVisualStyleBackColor = true;
            this.buttonListRoomAll.Click += new System.EventHandler(this.buttonListRoomAll_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.labelHotel);
            this.panel3.Location = new System.Drawing.Point(12, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 142);
            this.panel3.TabIndex = 3;
            // 
            // labelHotel
            // 
            this.labelHotel.AutoSize = true;
            this.labelHotel.ForeColor = System.Drawing.Color.Gray;
            this.labelHotel.Location = new System.Drawing.Point(3, 2);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(99, 20);
            this.labelHotel.TabIndex = 0;
            this.labelHotel.Text = "Інформація...";
            // 
            // dateTimePickerFrom2
            // 
            this.dateTimePickerFrom2.Location = new System.Drawing.Point(215, 3);
            this.dateTimePickerFrom2.Name = "dateTimePickerFrom2";
            this.dateTimePickerFrom2.Size = new System.Drawing.Size(90, 27);
            this.dateTimePickerFrom2.TabIndex = 9;
            // 
            // dateTimePickerTo2
            // 
            this.dateTimePickerTo2.Location = new System.Drawing.Point(335, 3);
            this.dateTimePickerTo2.Name = "dateTimePickerTo2";
            this.dateTimePickerTo2.Size = new System.Drawing.Size(90, 27);
            this.dateTimePickerTo2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(169, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Клієнти";
            // 
            // buttonViewDeclarationByDate
            // 
            this.buttonViewDeclarationByDate.AutoSize = true;
            this.buttonViewDeclarationByDate.Location = new System.Drawing.Point(99, 0);
            this.buttonViewDeclarationByDate.Name = "buttonViewDeclarationByDate";
            this.buttonViewDeclarationByDate.Size = new System.Drawing.Size(98, 30);
            this.buttonViewDeclarationByDate.TabIndex = 14;
            this.buttonViewDeclarationByDate.Text = "див. заявки";
            this.buttonViewDeclarationByDate.UseVisualStyleBackColor = true;
            this.buttonViewDeclarationByDate.Click += new System.EventHandler(this.buttonViewDeclarationByDate_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(172, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "id:";
            // 
            // textBoxIdClient1
            // 
            this.textBoxIdClient1.ForeColor = System.Drawing.Color.Gray;
            this.textBoxIdClient1.Location = new System.Drawing.Point(206, 4);
            this.textBoxIdClient1.Name = "textBoxIdClient1";
            this.textBoxIdClient1.Size = new System.Drawing.Size(62, 27);
            this.textBoxIdClient1.TabIndex = 16;
            this.textBoxIdClient1.Text = "0";
            this.textBoxIdClient1.Enter += new System.EventHandler(this.textBoxIdClient1_Enter);
            this.textBoxIdClient1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdClient1_KeyPress);
            this.textBoxIdClient1.Leave += new System.EventHandler(this.textBoxIdClient1_Leave);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.AutoSize = true;
            this.buttonDeleteClient.Location = new System.Drawing.Point(172, 37);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(99, 30);
            this.buttonDeleteClient.TabIndex = 17;
            this.buttonDeleteClient.Text = "видалити";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.AutoSize = true;
            this.buttonEditClient.Location = new System.Drawing.Point(172, 73);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(99, 30);
            this.buttonEditClient.TabIndex = 18;
            this.buttonEditClient.Text = "редагувати";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            this.buttonEditClient.Click += new System.EventHandler(this.buttonEditClient_Click);
            // 
            // buttonInfoByIdClient
            // 
            this.buttonInfoByIdClient.AutoSize = true;
            this.buttonInfoByIdClient.Location = new System.Drawing.Point(172, 109);
            this.buttonInfoByIdClient.Name = "buttonInfoByIdClient";
            this.buttonInfoByIdClient.Size = new System.Drawing.Size(99, 30);
            this.buttonInfoByIdClient.TabIndex = 19;
            this.buttonInfoByIdClient.Text = "інф.";
            this.buttonInfoByIdClient.UseVisualStyleBackColor = true;
            this.buttonInfoByIdClient.Click += new System.EventHandler(this.buttonInfoByIdClient_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.buttonFirstLastNameSearch);
            this.panel4.Controls.Add(this.textBoxFirstLastNameSearch);
            this.panel4.Controls.Add(this.buttonAddClient);
            this.panel4.Controls.Add(this.buttonLastNameSort);
            this.panel4.Controls.Add(this.buttonFirstNameSort);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.buttonInfoClients);
            this.panel4.Controls.Add(this.buttonInfoByIdClient);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBoxIdClient1);
            this.panel4.Controls.Add(this.buttonEditClient);
            this.panel4.Controls.Add(this.buttonDeleteClient);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(169, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 176);
            this.panel4.TabIndex = 20;
            // 
            // buttonFirstLastNameSearch
            // 
            this.buttonFirstLastNameSearch.AutoSize = true;
            this.buttonFirstLastNameSearch.Location = new System.Drawing.Point(172, 142);
            this.buttonFirstLastNameSearch.Name = "buttonFirstLastNameSearch";
            this.buttonFirstLastNameSearch.Size = new System.Drawing.Size(68, 30);
            this.buttonFirstLastNameSearch.TabIndex = 26;
            this.buttonFirstLastNameSearch.Text = "шукати";
            this.buttonFirstLastNameSearch.UseVisualStyleBackColor = true;
            this.buttonFirstLastNameSearch.Click += new System.EventHandler(this.buttonFirstLastNameSearch_Click);
            // 
            // textBoxFirstLastNameSearch
            // 
            this.textBoxFirstLastNameSearch.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFirstLastNameSearch.Location = new System.Drawing.Point(3, 145);
            this.textBoxFirstLastNameSearch.Name = "textBoxFirstLastNameSearch";
            this.textBoxFirstLastNameSearch.Size = new System.Drawing.Size(163, 27);
            this.textBoxFirstLastNameSearch.TabIndex = 25;
            this.textBoxFirstLastNameSearch.Text = "ім\'я або прізвище";
            this.textBoxFirstLastNameSearch.Enter += new System.EventHandler(this.textBoxFirstLastNameSearch_Enter);
            this.textBoxFirstLastNameSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstLastNameSearch_KeyPress);
            this.textBoxFirstLastNameSearch.Leave += new System.EventHandler(this.textBoxFirstLastNameSearch_Leave);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(81, 4);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(73, 27);
            this.buttonAddClient.TabIndex = 24;
            this.buttonAddClient.Text = "додати";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // buttonLastNameSort
            // 
            this.buttonLastNameSort.AutoSize = true;
            this.buttonLastNameSort.Location = new System.Drawing.Point(70, 109);
            this.buttonLastNameSort.Name = "buttonLastNameSort";
            this.buttonLastNameSort.Size = new System.Drawing.Size(96, 30);
            this.buttonLastNameSort.TabIndex = 23;
            this.buttonLastNameSort.Text = "прізвищем";
            this.buttonLastNameSort.UseVisualStyleBackColor = true;
            this.buttonLastNameSort.Click += new System.EventHandler(this.buttonLastNameSort_Click);
            // 
            // buttonFirstNameSort
            // 
            this.buttonFirstNameSort.AutoSize = true;
            this.buttonFirstNameSort.Location = new System.Drawing.Point(3, 109);
            this.buttonFirstNameSort.Name = "buttonFirstNameSort";
            this.buttonFirstNameSort.Size = new System.Drawing.Size(61, 30);
            this.buttonFirstNameSort.TabIndex = 21;
            this.buttonFirstNameSort.Text = "ім\'ям";
            this.buttonFirstNameSort.UseVisualStyleBackColor = true;
            this.buttonFirstNameSort.Click += new System.EventHandler(this.buttonFirstNameSort_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 66);
            this.label5.TabIndex = 22;
            this.label5.Text = "Відсортувати список за:";
            // 
            // buttonInfoClients
            // 
            this.buttonInfoClients.AutoSize = true;
            this.buttonInfoClients.Location = new System.Drawing.Point(3, 37);
            this.buttonInfoClients.Name = "buttonInfoClients";
            this.buttonInfoClients.Size = new System.Drawing.Size(163, 30);
            this.buttonInfoClients.TabIndex = 21;
            this.buttonInfoClients.Text = "інф. про всіх клієнтів";
            this.buttonInfoClients.UseVisualStyleBackColor = true;
            this.buttonInfoClients.Click += new System.EventHandler(this.buttonInfoClients_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel6.Location = new System.Drawing.Point(172, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(99, 139);
            this.panel6.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel5.Controls.Add(this.buttonDeleteDeclaration);
            this.panel5.Controls.Add(this.buttonSealDeclaration);
            this.panel5.Controls.Add(this.textBoxIdDeclaration);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.buttonViewDeclarationByDate);
            this.panel5.Controls.Add(this.dateTimePickerTo2);
            this.panel5.Controls.Add(this.dateTimePickerFrom2);
            this.panel5.Location = new System.Drawing.Point(12, 426);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(428, 73);
            this.panel5.TabIndex = 21;
            // 
            // buttonDeleteDeclaration
            // 
            this.buttonDeleteDeclaration.AutoSize = true;
            this.buttonDeleteDeclaration.Location = new System.Drawing.Point(151, 36);
            this.buttonDeleteDeclaration.Name = "buttonDeleteDeclaration";
            this.buttonDeleteDeclaration.Size = new System.Drawing.Size(84, 30);
            this.buttonDeleteDeclaration.TabIndex = 30;
            this.buttonDeleteDeclaration.Text = "видалити";
            this.buttonDeleteDeclaration.UseVisualStyleBackColor = true;
            this.buttonDeleteDeclaration.Click += new System.EventHandler(this.buttonDeleteDeclaration_Click);
            // 
            // buttonSealDeclaration
            // 
            this.buttonSealDeclaration.AutoSize = true;
            this.buttonSealDeclaration.Location = new System.Drawing.Point(99, 36);
            this.buttonSealDeclaration.Name = "buttonSealDeclaration";
            this.buttonSealDeclaration.Size = new System.Drawing.Size(50, 30);
            this.buttonSealDeclaration.TabIndex = 29;
            this.buttonSealDeclaration.Text = "друк";
            this.buttonSealDeclaration.UseVisualStyleBackColor = true;
            this.buttonSealDeclaration.Click += new System.EventHandler(this.buttonSealDeclaration_Click);
            // 
            // textBoxIdDeclaration
            // 
            this.textBoxIdDeclaration.ForeColor = System.Drawing.Color.Gray;
            this.textBoxIdDeclaration.Location = new System.Drawing.Point(5, 37);
            this.textBoxIdDeclaration.Name = "textBoxIdDeclaration";
            this.textBoxIdDeclaration.Size = new System.Drawing.Size(84, 27);
            this.textBoxIdDeclaration.TabIndex = 28;
            this.textBoxIdDeclaration.Text = "id заявки";
            this.textBoxIdDeclaration.Enter += new System.EventHandler(this.textBoxIdDeclaration_Enter);
            this.textBoxIdDeclaration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdDeclaration_KeyPress);
            this.textBoxIdDeclaration.Leave += new System.EventHandler(this.textBoxIdDeclaration_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "до";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "з";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Заявки";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Controls.Add(this.buttonBooking);
            this.panel7.Controls.Add(this.buttonSettle);
            this.panel7.Controls.Add(this.textBoxNumRoom1);
            this.panel7.Controls.Add(this.textBoxIdClient2);
            this.panel7.Controls.Add(this.dateTimePickerFrom1);
            this.panel7.Controls.Add(this.dateTimePickerTo1);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(12, 230);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(222, 112);
            this.panel7.TabIndex = 22;
            // 
            // buttonBooking
            // 
            this.buttonBooking.AutoSize = true;
            this.buttonBooking.Location = new System.Drawing.Point(94, 75);
            this.buttonBooking.Name = "buttonBooking";
            this.buttonBooking.Size = new System.Drawing.Size(98, 30);
            this.buttonBooking.TabIndex = 30;
            this.buttonBooking.Text = "бронювати";
            this.buttonBooking.UseVisualStyleBackColor = true;
            this.buttonBooking.Click += new System.EventHandler(this.buttonBooking_Click);
            // 
            // buttonSettle
            // 
            this.buttonSettle.AutoSize = true;
            this.buttonSettle.Location = new System.Drawing.Point(7, 75);
            this.buttonSettle.Name = "buttonSettle";
            this.buttonSettle.Size = new System.Drawing.Size(81, 30);
            this.buttonSettle.TabIndex = 19;
            this.buttonSettle.Text = "заселити";
            this.buttonSettle.UseVisualStyleBackColor = true;
            this.buttonSettle.Click += new System.EventHandler(this.buttonSettle_Click);
            // 
            // textBoxNumRoom1
            // 
            this.textBoxNumRoom1.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNumRoom1.Location = new System.Drawing.Point(8, 7);
            this.textBoxNumRoom1.Name = "textBoxNumRoom1";
            this.textBoxNumRoom1.Size = new System.Drawing.Size(82, 27);
            this.textBoxNumRoom1.TabIndex = 25;
            this.textBoxNumRoom1.Text = "№ номера";
            this.textBoxNumRoom1.Enter += new System.EventHandler(this.textBoxNumRoom1_Enter);
            this.textBoxNumRoom1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumRoom1_KeyPress);
            this.textBoxNumRoom1.Leave += new System.EventHandler(this.textBoxNumRoom1_Leave);
            // 
            // textBoxIdClient2
            // 
            this.textBoxIdClient2.ForeColor = System.Drawing.Color.Gray;
            this.textBoxIdClient2.Location = new System.Drawing.Point(96, 7);
            this.textBoxIdClient2.Name = "textBoxIdClient2";
            this.textBoxIdClient2.Size = new System.Drawing.Size(82, 27);
            this.textBoxIdClient2.TabIndex = 24;
            this.textBoxIdClient2.Text = "id клієнта";
            this.textBoxIdClient2.Enter += new System.EventHandler(this.textBoxIdClient2_Enter);
            this.textBoxIdClient2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdClient2_KeyPress);
            this.textBoxIdClient2.Leave += new System.EventHandler(this.textBoxIdClient2_Leave);
            // 
            // dateTimePickerFrom1
            // 
            this.dateTimePickerFrom1.Location = new System.Drawing.Point(8, 40);
            this.dateTimePickerFrom1.Name = "dateTimePickerFrom1";
            this.dateTimePickerFrom1.Size = new System.Drawing.Size(90, 27);
            this.dateTimePickerFrom1.TabIndex = 26;
            // 
            // dateTimePickerTo1
            // 
            this.dateTimePickerTo1.Location = new System.Drawing.Point(124, 40);
            this.dateTimePickerTo1.Name = "dateTimePickerTo1";
            this.dateTimePickerTo1.Size = new System.Drawing.Size(90, 27);
            this.dateTimePickerTo1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "до";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel8.Controls.Add(this.buttonUnbooking);
            this.panel8.Controls.Add(this.buttonUnSettle);
            this.panel8.Controls.Add(this.textBoxIdClient3);
            this.panel8.Location = new System.Drawing.Point(241, 230);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(118, 112);
            this.panel8.TabIndex = 23;
            // 
            // buttonUnbooking
            // 
            this.buttonUnbooking.AutoSize = true;
            this.buttonUnbooking.Location = new System.Drawing.Point(7, 75);
            this.buttonUnbooking.Name = "buttonUnbooking";
            this.buttonUnbooking.Size = new System.Drawing.Size(106, 30);
            this.buttonUnbooking.TabIndex = 26;
            this.buttonUnbooking.Text = "зняти бронь";
            this.buttonUnbooking.UseVisualStyleBackColor = true;
            this.buttonUnbooking.Click += new System.EventHandler(this.buttonUnbooking_Click);
            // 
            // buttonUnSettle
            // 
            this.buttonUnSettle.AutoSize = true;
            this.buttonUnSettle.Location = new System.Drawing.Point(8, 39);
            this.buttonUnSettle.Name = "buttonUnSettle";
            this.buttonUnSettle.Size = new System.Drawing.Size(83, 30);
            this.buttonUnSettle.TabIndex = 24;
            this.buttonUnSettle.Text = "виселити";
            this.buttonUnSettle.UseVisualStyleBackColor = true;
            this.buttonUnSettle.Click += new System.EventHandler(this.buttonUnSettle_Click);
            // 
            // textBoxIdClient3
            // 
            this.textBoxIdClient3.ForeColor = System.Drawing.Color.Gray;
            this.textBoxIdClient3.Location = new System.Drawing.Point(7, 7);
            this.textBoxIdClient3.Name = "textBoxIdClient3";
            this.textBoxIdClient3.Size = new System.Drawing.Size(84, 27);
            this.textBoxIdClient3.TabIndex = 25;
            this.textBoxIdClient3.Text = "id клієнта";
            this.textBoxIdClient3.Enter += new System.EventHandler(this.textBoxIdClient3_Enter);
            this.textBoxIdClient3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdClient3_KeyPress);
            this.textBoxIdClient3.Leave += new System.EventHandler(this.textBoxIdClient3_Leave);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel9.Controls.Add(this.buttonRoomInfo);
            this.panel9.Controls.Add(this.buttonListRoomSettled);
            this.panel9.Controls.Add(this.buttonListRoomFree);
            this.panel9.Controls.Add(this.buttonListRoomBooking);
            this.panel9.Controls.Add(this.buttonListRoomAll);
            this.panel9.Controls.Add(this.textBoxNumRoom2);
            this.panel9.Location = new System.Drawing.Point(12, 348);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(430, 72);
            this.panel9.TabIndex = 24;
            // 
            // buttonRoomInfo
            // 
            this.buttonRoomInfo.AutoSize = true;
            this.buttonRoomInfo.Location = new System.Drawing.Point(6, 37);
            this.buttonRoomInfo.Name = "buttonRoomInfo";
            this.buttonRoomInfo.Size = new System.Drawing.Size(83, 30);
            this.buttonRoomInfo.TabIndex = 24;
            this.buttonRoomInfo.Text = "інфо";
            this.buttonRoomInfo.UseVisualStyleBackColor = true;
            this.buttonRoomInfo.Click += new System.EventHandler(this.buttonRoomInfo_Click);
            // 
            // textBoxNumRoom2
            // 
            this.textBoxNumRoom2.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNumRoom2.Location = new System.Drawing.Point(5, 5);
            this.textBoxNumRoom2.Name = "textBoxNumRoom2";
            this.textBoxNumRoom2.Size = new System.Drawing.Size(84, 27);
            this.textBoxNumRoom2.TabIndex = 25;
            this.textBoxNumRoom2.Text = "№ номера";
            this.textBoxNumRoom2.Enter += new System.EventHandler(this.textBoxNumRoom2_Enter);
            this.textBoxNumRoom2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumRoom2_KeyPress);
            this.textBoxNumRoom2.Leave += new System.EventHandler(this.textBoxNumRoom2_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 511);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBoxHotels);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Готелі";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button buttonDeleteHotel;
        private Button buttonAddHotel;
        private Button buttonInfoHotels;
        private ComboBox comboBoxHotels;
        private Panel panel2;
        private Label labelInfo;
        private Panel panel3;
        private Label labelHotel;
        private DateTimePicker dateTimePickerFrom2;
        private DateTimePicker dateTimePickerTo2;
        private Label label3;
        private Button buttonViewDeclarationByDate;
        private Label label4;
        private TextBox textBoxIdClient1;
        private Button buttonDeleteClient;
        private Button buttonEditClient;
        private Button buttonInfoByIdClient;
        private Panel panel4;
        private Button buttonLastNameSort;
        private Button buttonFirstNameSort;
        private Label label5;
        private Button buttonInfoClients;
        private Button buttonAddClient;
        private Panel panel5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxFirstLastNameSearch;
        private Button buttonFirstLastNameSearch;
        private Panel panel6;
        private Panel panel7;
        private Button buttonSettle;
        private Label label2;
        private DateTimePicker dateTimePickerTo1;
        private DateTimePicker dateTimePickerFrom1;
        private TextBox textBoxNumRoom1;
        private TextBox textBoxIdClient2;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel8;
        private Button buttonUnSettle;
        private TextBox textBoxIdClient3;
        private Button buttonListRoomBooking;
        private Button buttonListRoomSettled;
        private Button buttonListRoomFree;
        private Label label9;
        private Button buttonListRoomAll;
        private Button buttonBooking;
        private Button buttonUnbooking;
        private Panel panel9;
        private Button buttonRoomInfo;
        private TextBox textBoxNumRoom2;
        private Button buttonDeleteDeclaration;
        private Button buttonSealDeclaration;
        private TextBox textBoxIdDeclaration;
    }
}