namespace EventTicket.Forms.Commission
{
    partial class CommissionAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewClients = new DataGridView();
            dataGridViewEvents = new DataGridView();
            inputOrderPrice = new NumericUpDown();
            label2 = new Label();
            dtpOrderDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            inputTicketCount = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            cbStatusChoose = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            inputOrderNote = new TextBox();
            btnAddOrEdit = new Button();
            inputEventName = new TextBox();
            label1 = new Label();
            inputClientName = new TextBox();
            inputClientAddress = new TextBox();
            inputClientTelephone = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox22 = new TextBox();
            textBox11 = new TextBox();
            textBox3 = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputOrderPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputTicketCount).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(355, 37);
            dataGridViewClients.Margin = new Padding(5);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.Size = new Size(815, 250);
            dataGridViewClients.TabIndex = 0;
            dataGridViewClients.CellClick += dataGridViewClients_CellClick;
            // 
            // dataGridViewEvents
            // 
            dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvents.Location = new Point(355, 322);
            dataGridViewEvents.Margin = new Padding(5);
            dataGridViewEvents.Name = "dataGridViewEvents";
            dataGridViewEvents.Size = new Size(815, 250);
            dataGridViewEvents.TabIndex = 1;
            dataGridViewEvents.CellClick += dataGridViewEvents_CellClick;
            // 
            // inputOrderPrice
            // 
            inputOrderPrice.Location = new Point(14, 228);
            inputOrderPrice.Margin = new Padding(31, 37, 31, 37);
            inputOrderPrice.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            inputOrderPrice.Name = "inputOrderPrice";
            inputOrderPrice.Size = new Size(321, 33);
            inputOrderPrice.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 71);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(195, 25);
            label2.TabIndex = 4;
            label2.Text = "Количество билетов";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Enabled = false;
            dtpOrderDate.Location = new Point(14, 164);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(321, 33);
            dtpOrderDate.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 136);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(236, 25);
            label3.TabIndex = 7;
            label3.Text = "Дата оформления заказа";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 200);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(169, 25);
            label4.TabIndex = 9;
            label4.Text = "Стоимость заказа";
            // 
            // inputTicketCount
            // 
            inputTicketCount.Location = new Point(14, 98);
            inputTicketCount.Margin = new Padding(31, 37, 31, 37);
            inputTicketCount.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            inputTicketCount.Name = "inputTicketCount";
            inputTicketCount.Size = new Size(321, 33);
            inputTicketCount.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 7);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(174, 25);
            label5.TabIndex = 10;
            label5.Text = "Выберите клиента";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(355, 292);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(221, 25);
            label6.TabIndex = 11;
            label6.Text = "Выберите мероприятие";
            // 
            // cbStatusChoose
            // 
            cbStatusChoose.FormattingEnabled = true;
            cbStatusChoose.Location = new Point(14, 297);
            cbStatusChoose.Name = "cbStatusChoose";
            cbStatusChoose.Size = new Size(321, 33);
            cbStatusChoose.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 269);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(132, 25);
            label7.TabIndex = 13;
            label7.Text = "Статус заказа";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 333);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(203, 25);
            label8.TabIndex = 14;
            label8.Text = "Примечание к заказу";
            // 
            // inputOrderNote
            // 
            inputOrderNote.Location = new Point(14, 361);
            inputOrderNote.Name = "inputOrderNote";
            inputOrderNote.Size = new Size(321, 33);
            inputOrderNote.TabIndex = 15;
            // 
            // btnAddOrEdit
            // 
            btnAddOrEdit.Location = new Point(14, 581);
            btnAddOrEdit.Name = "btnAddOrEdit";
            btnAddOrEdit.Size = new Size(323, 68);
            btnAddOrEdit.TabIndex = 16;
            btnAddOrEdit.Text = "button1";
            btnAddOrEdit.UseVisualStyleBackColor = true;
            btnAddOrEdit.Click += btnAddOrEdit_Click;
            // 
            // inputEventName
            // 
            inputEventName.Location = new Point(14, 37);
            inputEventName.Name = "inputEventName";
            inputEventName.Size = new Size(321, 33);
            inputEventName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(269, 25);
            label1.TabIndex = 17;
            label1.Text = "Наименование мероприятия";
            // 
            // inputClientName
            // 
            inputClientName.Location = new Point(14, 297);
            inputClientName.Name = "inputClientName";
            inputClientName.Size = new Size(321, 33);
            inputClientName.TabIndex = 19;
            // 
            // inputClientAddress
            // 
            inputClientAddress.Location = new Point(14, 361);
            inputClientAddress.Name = "inputClientAddress";
            inputClientAddress.Size = new Size(321, 33);
            inputClientAddress.TabIndex = 20;
            // 
            // inputClientTelephone
            // 
            inputClientTelephone.Location = new Point(14, 425);
            inputClientTelephone.Name = "inputClientTelephone";
            inputClientTelephone.Size = new Size(321, 33);
            inputClientTelephone.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 397);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(163, 25);
            label9.TabIndex = 22;
            label9.Text = "Телефон клиента";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 525);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(163, 25);
            label10.TabIndex = 27;
            label10.Text = "Телефон клиента";
            // 
            // textBox22
            // 
            textBox22.Location = new Point(14, 553);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(321, 33);
            textBox22.TabIndex = 26;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(14, 489);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(321, 33);
            textBox11.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 489);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(321, 33);
            textBox3.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 461);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(203, 25);
            label11.TabIndex = 23;
            label11.Text = "Примечание к заказу";
            // 
            // CommissionAddForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(label10);
            Controls.Add(textBox22);
            Controls.Add(textBox11);
            Controls.Add(textBox3);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(inputClientTelephone);
            Controls.Add(inputClientAddress);
            Controls.Add(inputClientName);
            Controls.Add(inputEventName);
            Controls.Add(label1);
            Controls.Add(btnAddOrEdit);
            Controls.Add(inputOrderNote);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cbStatusChoose);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(inputTicketCount);
            Controls.Add(label3);
            Controls.Add(dtpOrderDate);
            Controls.Add(label2);
            Controls.Add(inputOrderPrice);
            Controls.Add(dataGridViewEvents);
            Controls.Add(dataGridViewClients);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "CommissionAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CommissionAddForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputOrderPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputTicketCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewClients;
        private DataGridView dataGridViewEvents;
        private NumericUpDown inputOrderPrice;
        private Label label2;
        private DateTimePicker dtpOrderDate;
        private Label label3;
        private Label label4;
        private NumericUpDown inputTicketCount;
        private Label label5;
        private Label label6;
        private ComboBox cbStatusChoose;
        private Label label7;
        private Label label8;
        private TextBox inputOrderNote;
        private Button btnAddOrEdit;
        private TextBox inputEventName;
        private Label label1;
        private TextBox inputClientName;
        private TextBox inputClientAddress;
        private TextBox inputClientTelephone;
        private Label label9;
        private Label label10;
        private TextBox textBox22;
        private TextBox textBox11;
        private TextBox textBox3;
        private Label label11;
    }
}