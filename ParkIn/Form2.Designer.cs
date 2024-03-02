namespace ParkIn
{
    partial class parkOut
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
            panelDash = new Panel();
            button1 = new Button();
            parkOutButton = new Button();
            parkInButton = new Button();
            panel1 = new Panel();
            submitButton = new Button();
            button23 = new Button();
            plateNum = new Label();
            vehicleType = new Label();
            vehicleBrand = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panelDash.SuspendLayout();
            SuspendLayout();
            // 
            // panelDash
            // 
            panelDash.BackColor = Color.FromArgb(50, 50, 50);
            panelDash.Controls.Add(button1);
            panelDash.Controls.Add(parkOutButton);
            panelDash.Controls.Add(parkInButton);
            panelDash.Controls.Add(panel1);
            panelDash.Location = new Point(-3, -2);
            panelDash.Name = "panelDash";
            panelDash.Size = new Size(264, 558);
            panelDash.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button1.Location = new Point(49, 495);
            button1.Name = "button1";
            button1.Size = new Size(169, 36);
            button1.TabIndex = 5;
            button1.Text = "LOGOUT";
            button1.UseVisualStyleBackColor = true;
            // 
            // parkOutButton
            // 
            parkOutButton.BackColor = Color.White;
            parkOutButton.FlatAppearance.BorderSize = 0;
            parkOutButton.FlatStyle = FlatStyle.Flat;
            parkOutButton.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parkOutButton.ForeColor = SystemColors.WindowFrame;
            parkOutButton.Location = new Point(3, 248);
            parkOutButton.Name = "parkOutButton";
            parkOutButton.Size = new Size(261, 56);
            parkOutButton.TabIndex = 4;
            parkOutButton.Text = "PARK OUT";
            parkOutButton.TextAlign = ContentAlignment.MiddleLeft;
            parkOutButton.UseVisualStyleBackColor = false;
            // 
            // parkInButton
            // 
            parkInButton.FlatAppearance.BorderSize = 0;
            parkInButton.FlatStyle = FlatStyle.Flat;
            parkInButton.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parkInButton.ForeColor = Color.White;
            parkInButton.Location = new Point(3, 175);
            parkInButton.Name = "parkInButton";
            parkInButton.Size = new Size(261, 56);
            parkInButton.TabIndex = 3;
            parkInButton.Text = "PARK IN";
            parkInButton.TextAlign = ContentAlignment.MiddleLeft;
            parkInButton.UseVisualStyleBackColor = true;
            parkInButton.Click += parkInButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.BackgroundImage = Properties.Resources.PARK_NA_BAI;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(15, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 177);
            panel1.TabIndex = 2;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.White;
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Tahoma", 14.2F, FontStyle.Bold);
            submitButton.ForeColor = Color.FromArgb(50, 50, 50);
            submitButton.Location = new Point(529, 364);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(171, 43);
            submitButton.TabIndex = 11;
            submitButton.Text = "SUBMIT";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // button23
            // 
            button23.FlatAppearance.BorderSize = 0;
            button23.FlatStyle = FlatStyle.Flat;
            button23.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button23.Location = new Point(702, 21);
            button23.Name = "button23";
            button23.Size = new Size(236, 36);
            button23.TabIndex = 12;
            button23.Text = "EKIS KA SAKIN";
            button23.UseVisualStyleBackColor = true;
            // 
            // plateNum
            // 
            plateNum.AutoSize = true;
            plateNum.Font = new Font("Arial", 12F, FontStyle.Bold);
            plateNum.Location = new Point(400, 211);
            plateNum.Name = "plateNum";
            plateNum.Size = new Size(144, 24);
            plateNum.TabIndex = 13;
            plateNum.Text = "Plate Number:";
            // 
            // vehicleType
            // 
            vehicleType.AutoSize = true;
            vehicleType.Font = new Font("Arial", 12F, FontStyle.Bold);
            vehicleType.Location = new Point(408, 247);
            vehicleType.Name = "vehicleType";
            vehicleType.Size = new Size(136, 24);
            vehicleType.TabIndex = 14;
            vehicleType.Text = "Vehicle Type:";
            // 
            // vehicleBrand
            // 
            vehicleBrand.AutoSize = true;
            vehicleBrand.Font = new Font("Arial", 12F, FontStyle.Bold);
            vehicleBrand.Location = new Point(397, 284);
            vehicleBrand.Name = "vehicleBrand";
            vehicleBrand.Size = new Size(147, 24);
            vehicleBrand.TabIndex = 15;
            vehicleBrand.Text = "Vehicle Brand:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(438, 175);
            label2.Name = "label2";
            label2.Size = new Size(106, 24);
            label2.TabIndex = 16;
            label2.Text = "Parked In:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(561, 175);
            label3.Name = "label3";
            label3.Size = new Size(262, 24);
            label3.TabIndex = 17;
            label3.Text = "12:00:00  January 31, 2024";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(561, 211);
            label4.Name = "label4";
            label4.Size = new Size(97, 24);
            label4.TabIndex = 18;
            label4.Text = "GVC1234";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(561, 247);
            label5.Name = "label5";
            label5.Size = new Size(51, 24);
            label5.TabIndex = 19;
            label5.Text = "CAR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(561, 284);
            label6.Name = "label6";
            label6.Size = new Size(92, 24);
            label6.TabIndex = 20;
            label6.Text = "TOTOYA";
            // 
            // parkOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(950, 550);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(vehicleBrand);
            Controls.Add(vehicleType);
            Controls.Add(plateNum);
            Controls.Add(panelDash);
            Controls.Add(submitButton);
            Controls.Add(button23);
            FormBorderStyle = FormBorderStyle.None;
            Name = "parkOut";
            Text = "Form2";
            panelDash.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDash;
        private Button button1;
        private Button parkOutButton;
        private Button parkInButton;
        private Panel panel1;
        private Button submitButton;
        private Button button23;
        private Label plateNum;
        private Label vehicleType;
        private Label vehicleBrand;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}