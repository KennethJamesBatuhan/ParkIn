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
            comboVehicleType = new ComboBox();
            button2 = new Button();
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
            parkOutButton.FlatAppearance.BorderSize = 0;
            parkOutButton.FlatStyle = FlatStyle.Flat;
            parkOutButton.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parkOutButton.ForeColor = Color.White;
            parkOutButton.Location = new Point(15, 248);
            parkOutButton.Name = "parkOutButton";
            parkOutButton.Size = new Size(230, 56);
            parkOutButton.TabIndex = 4;
            parkOutButton.Text = "PARK OUT";
            parkOutButton.TextAlign = ContentAlignment.MiddleLeft;
            parkOutButton.UseVisualStyleBackColor = true;
            // 
            // parkInButton
            // 
            parkInButton.FlatAppearance.BorderSize = 0;
            parkInButton.FlatStyle = FlatStyle.Flat;
            parkInButton.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parkInButton.ForeColor = Color.White;
            parkInButton.Location = new Point(15, 175);
            parkInButton.Name = "parkInButton";
            parkInButton.Size = new Size(230, 56);
            parkInButton.TabIndex = 3;
            parkInButton.Text = "PARK IN";
            parkInButton.TextAlign = ContentAlignment.MiddleLeft;
            parkInButton.UseVisualStyleBackColor = true;
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
            submitButton.Location = new Point(528, 356);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(171, 43);
            submitButton.TabIndex = 11;
            submitButton.Text = "SUBMIT";
            submitButton.UseVisualStyleBackColor = false;
            // 
            // comboVehicleType
            // 
            comboVehicleType.FlatStyle = FlatStyle.Flat;
            comboVehicleType.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboVehicleType.ForeColor = Color.DimGray;
            comboVehicleType.FormattingEnabled = true;
            comboVehicleType.Items.AddRange(new object[] { "Motorcycle", "Sedan", "SUV", "Van" });
            comboVehicleType.Location = new Point(411, 230);
            comboVehicleType.Name = "comboVehicleType";
            comboVehicleType.Size = new Size(418, 27);
            comboVehicleType.TabIndex = 14;
            comboVehicleType.Text = "Vehicle Type";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button2.Location = new Point(702, 21);
            button2.Name = "button2";
            button2.Size = new Size(236, 36);
            button2.TabIndex = 12;
            button2.Text = "EKIS KA SAKIN";
            button2.UseVisualStyleBackColor = true;
            // 
            // parkOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(950, 550);
            Controls.Add(panelDash);
            Controls.Add(submitButton);
            Controls.Add(comboVehicleType);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "parkOut";
            Text = "Form2";
            panelDash.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDash;
        private Button button1;
        private Button parkOutButton;
        private Button parkInButton;
        private Panel panel1;
        private Button submitButton;
        private ComboBox comboVehicleType;
        private Button button2;
    }
}