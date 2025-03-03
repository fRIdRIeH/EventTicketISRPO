namespace EventTicket.Forms.Client
{
    partial class ClientAddForm
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
            label1 = new Label();
            inputSurnameText = new TextBox();
            btnAddOrEdit = new Button();
            inputNameText = new TextBox();
            label2 = new Label();
            inputPatronimycText = new TextBox();
            label3 = new Label();
            inputEmailText = new TextBox();
            label4 = new Label();
            inputTelephoneText = new TextBox();
            label5 = new Label();
            inputAddressText = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 0;
            label1.Text = "Фамилия клиента";
            // 
            // inputSurnameText
            // 
            inputSurnameText.Location = new Point(12, 37);
            inputSurnameText.Name = "inputSurnameText";
            inputSurnameText.Size = new Size(333, 33);
            inputSurnameText.TabIndex = 1;
            // 
            // btnAddOrEdit
            // 
            btnAddOrEdit.Location = new Point(12, 474);
            btnAddOrEdit.Name = "btnAddOrEdit";
            btnAddOrEdit.Size = new Size(333, 36);
            btnAddOrEdit.TabIndex = 2;
            btnAddOrEdit.Text = "Добавить";
            btnAddOrEdit.UseVisualStyleBackColor = true;
            btnAddOrEdit.Click += btnAddOrEdit_Click;
            // 
            // inputNameText
            // 
            inputNameText.Location = new Point(12, 101);
            inputNameText.Name = "inputNameText";
            inputNameText.Size = new Size(333, 33);
            inputNameText.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 3;
            label2.Text = "Имя клиента";
            // 
            // inputPatronimycText
            // 
            inputPatronimycText.Location = new Point(12, 165);
            inputPatronimycText.Name = "inputPatronimycText";
            inputPatronimycText.Size = new Size(333, 33);
            inputPatronimycText.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(177, 25);
            label3.TabIndex = 5;
            label3.Text = "Отчество клиента";
            // 
            // inputEmailText
            // 
            inputEmailText.Location = new Point(12, 229);
            inputEmailText.Name = "inputEmailText";
            inputEmailText.Size = new Size(333, 33);
            inputEmailText.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 201);
            label4.Name = "label4";
            label4.Size = new Size(149, 25);
            label4.TabIndex = 7;
            label4.Text = "Почта клиента";
            // 
            // inputTelephoneText
            // 
            inputTelephoneText.Location = new Point(12, 293);
            inputTelephoneText.Name = "inputTelephoneText";
            inputTelephoneText.Size = new Size(333, 33);
            inputTelephoneText.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 265);
            label5.Name = "label5";
            label5.Size = new Size(171, 25);
            label5.TabIndex = 9;
            label5.Text = "Телефон клиента";
            // 
            // inputAddressText
            // 
            inputAddressText.Location = new Point(12, 357);
            inputAddressText.Name = "inputAddressText";
            inputAddressText.Size = new Size(333, 33);
            inputAddressText.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 329);
            label6.Name = "label6";
            label6.Size = new Size(149, 25);
            label6.TabIndex = 11;
            label6.Text = "Адрес клиента";
            // 
            // ClientAddForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 522);
            Controls.Add(inputAddressText);
            Controls.Add(label6);
            Controls.Add(inputTelephoneText);
            Controls.Add(label5);
            Controls.Add(inputEmailText);
            Controls.Add(label4);
            Controls.Add(inputPatronimycText);
            Controls.Add(label3);
            Controls.Add(inputNameText);
            Controls.Add(label2);
            Controls.Add(btnAddOrEdit);
            Controls.Add(inputSurnameText);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "ClientAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputSurnameText;
        private Button btnAddOrEdit;
        private TextBox inputNameText;
        private Label label2;
        private TextBox inputPatronimycText;
        private Label label3;
        private TextBox inputEmailText;
        private Label label4;
        private TextBox inputTelephoneText;
        private Label label5;
        private TextBox inputAddressText;
        private Label label6;
    }
}