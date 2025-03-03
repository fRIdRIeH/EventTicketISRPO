namespace EventTicket
{
    partial class MainForm
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
            btnGoToEventList = new Button();
            btnGoToClientList = new Button();
            btnGoToCommissionList = new Button();
            SuspendLayout();
            // 
            // btnGoToEventList
            // 
            btnGoToEventList.Location = new Point(172, 61);
            btnGoToEventList.Name = "btnGoToEventList";
            btnGoToEventList.Size = new Size(224, 42);
            btnGoToEventList.TabIndex = 0;
            btnGoToEventList.Text = "Мероприятия";
            btnGoToEventList.UseVisualStyleBackColor = true;
            btnGoToEventList.Click += btnGoToEventList_Click;
            // 
            // btnGoToClientList
            // 
            btnGoToClientList.Location = new Point(172, 147);
            btnGoToClientList.Name = "btnGoToClientList";
            btnGoToClientList.Size = new Size(224, 42);
            btnGoToClientList.TabIndex = 1;
            btnGoToClientList.Text = "Клиенты";
            btnGoToClientList.UseVisualStyleBackColor = true;
            btnGoToClientList.Click += btnGoToClientList_Click;
            // 
            // btnGoToCommissionList
            // 
            btnGoToCommissionList.Location = new Point(172, 230);
            btnGoToCommissionList.Name = "btnGoToCommissionList";
            btnGoToCommissionList.Size = new Size(224, 42);
            btnGoToCommissionList.TabIndex = 2;
            btnGoToCommissionList.Text = "Заказы";
            btnGoToCommissionList.UseVisualStyleBackColor = true;
            btnGoToCommissionList.Click += btnGoToCommissionList_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(btnGoToCommissionList);
            Controls.Add(btnGoToClientList);
            Controls.Add(btnGoToEventList);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EventTicket";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGoToEventList;
        private Button btnGoToClientList;
        private Button btnGoToCommissionList;
    }
}
