namespace EventTicket.Forms.Event
{
    partial class EventAddForm
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
            label6 = new Label();
            label5 = new Label();
            placeEventInput = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnAddOrEdit = new Button();
            nameEventInput = new TextBox();
            label1 = new Label();
            ticketPriceEventInput = new NumericUpDown();
            timeEventInput = new DateTimePicker();
            dateEventInput = new DateTimePicker();
            seatAmountEventInput = new NumericUpDown();
            descriptionEventInput = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)ticketPriceEventInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seatAmountEventInput).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 329);
            label6.Name = "label6";
            label6.Size = new Size(169, 25);
            label6.TabIndex = 24;
            label6.Text = "Количество мест";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 265);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 22;
            label5.Text = "Цена билета";
            // 
            // placeEventInput
            // 
            placeEventInput.Location = new Point(12, 229);
            placeEventInput.Name = "placeEventInput";
            placeEventInput.Size = new Size(360, 33);
            placeEventInput.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 201);
            label4.Name = "label4";
            label4.Size = new Size(203, 25);
            label4.TabIndex = 20;
            label4.Text = "Место мероприятия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(205, 25);
            label3.TabIndex = 18;
            label3.Text = "Время мероприятия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(189, 25);
            label2.TabIndex = 16;
            label2.Text = "Дата мероприятия";
            // 
            // btnAddOrEdit
            // 
            btnAddOrEdit.Location = new Point(12, 513);
            btnAddOrEdit.Name = "btnAddOrEdit";
            btnAddOrEdit.Size = new Size(360, 36);
            btnAddOrEdit.TabIndex = 15;
            btnAddOrEdit.Text = "Добавить";
            btnAddOrEdit.UseVisualStyleBackColor = true;
            btnAddOrEdit.Click += btnAddOrEdit_Click;
            // 
            // nameEventInput
            // 
            nameEventInput.Location = new Point(12, 37);
            nameEventInput.Name = "nameEventInput";
            nameEventInput.Size = new Size(360, 33);
            nameEventInput.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 25);
            label1.TabIndex = 13;
            label1.Text = "Название мероприятия";
            // 
            // ticketPriceEventInput
            // 
            ticketPriceEventInput.Location = new Point(12, 293);
            ticketPriceEventInput.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            ticketPriceEventInput.Name = "ticketPriceEventInput";
            ticketPriceEventInput.Size = new Size(360, 33);
            ticketPriceEventInput.TabIndex = 26;
            // 
            // timeEventInput
            // 
            timeEventInput.Format = DateTimePickerFormat.Time;
            timeEventInput.Location = new Point(12, 165);
            timeEventInput.Name = "timeEventInput";
            timeEventInput.Size = new Size(360, 33);
            timeEventInput.TabIndex = 27;
            // 
            // dateEventInput
            // 
            dateEventInput.Location = new Point(12, 101);
            dateEventInput.Name = "dateEventInput";
            dateEventInput.Size = new Size(360, 33);
            dateEventInput.TabIndex = 28;
            // 
            // seatAmountEventInput
            // 
            seatAmountEventInput.Location = new Point(12, 357);
            seatAmountEventInput.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            seatAmountEventInput.Name = "seatAmountEventInput";
            seatAmountEventInput.Size = new Size(360, 33);
            seatAmountEventInput.TabIndex = 29;
            // 
            // descriptionEventInput
            // 
            descriptionEventInput.Location = new Point(12, 421);
            descriptionEventInput.Name = "descriptionEventInput";
            descriptionEventInput.Size = new Size(360, 33);
            descriptionEventInput.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 393);
            label7.Name = "label7";
            label7.Size = new Size(236, 25);
            label7.TabIndex = 30;
            label7.Text = "Описание мероприятия";
            // 
            // EventAddForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(descriptionEventInput);
            Controls.Add(label7);
            Controls.Add(seatAmountEventInput);
            Controls.Add(dateEventInput);
            Controls.Add(timeEventInput);
            Controls.Add(ticketPriceEventInput);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(placeEventInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAddOrEdit);
            Controls.Add(nameEventInput);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "EventAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventAddForm";
            ((System.ComponentModel.ISupportInitialize)ticketPriceEventInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)seatAmountEventInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private TextBox placeEventInput;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAddOrEdit;
        private TextBox nameEventInput;
        private Label label1;
        private NumericUpDown ticketPriceEventInput;
        private DateTimePicker timeEventInput;
        private DateTimePicker dateEventInput;
        private NumericUpDown seatAmountEventInput;
        private TextBox descriptionEventInput;
        private Label label7;
    }
}