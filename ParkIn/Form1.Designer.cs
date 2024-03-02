namespace ParkIn
{
    partial class ParkInDash
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
            panelDash = new Panel();
            button1 = new Button();
            parkOutButton = new Button();
            parkInButton = new Button();
            panel1 = new Panel();
            button2 = new Button();
            plateNum = new TextBox();
            comboVehicleType = new ComboBox();
            comboVehicleBrand = new ComboBox();
            submitButton = new Button();
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
            panelDash.TabIndex = 1;
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
            button1.Click += button1_Click;
            // 
            // parkOutButton
            // 
            parkOutButton.FlatAppearance.BorderSize = 0;
            parkOutButton.FlatStyle = FlatStyle.Flat;
            parkOutButton.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parkOutButton.ForeColor = Color.White;
            parkOutButton.Location = new Point(3, 248);
            parkOutButton.Name = "parkOutButton";
            parkOutButton.Size = new Size(258, 56);
            parkOutButton.TabIndex = 4;
            parkOutButton.Text = "PARK OUT";
            parkOutButton.TextAlign = ContentAlignment.MiddleLeft;
            parkOutButton.UseVisualStyleBackColor = true;
            parkOutButton.Click += parkOutButton_Click;
            // 
            // parkInButton
            // 
            parkInButton.BackColor = Color.White;
            parkInButton.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            parkInButton.FlatAppearance.BorderSize = 0;
            parkInButton.FlatStyle = FlatStyle.Flat;
            parkInButton.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parkInButton.ForeColor = SystemColors.WindowFrame;
            parkInButton.Location = new Point(3, 175);
            parkInButton.Name = "parkInButton";
            parkInButton.Size = new Size(261, 56);
            parkInButton.TabIndex = 3;
            parkInButton.Text = "PARK IN";
            parkInButton.TextAlign = ContentAlignment.MiddleLeft;
            parkInButton.UseVisualStyleBackColor = false;
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
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button2.Location = new Point(702, 21);
            button2.Name = "button2";
            button2.Size = new Size(236, 36);
            button2.TabIndex = 6;
            button2.Text = "EKIS KA SAKIN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // plateNum
            // 
            plateNum.BorderStyle = BorderStyle.None;
            plateNum.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            plateNum.ForeColor = Color.DimGray;
            plateNum.Location = new Point(407, 169);
            plateNum.Multiline = true;
            plateNum.Name = "plateNum";
            plateNum.Size = new Size(418, 27);
            plateNum.TabIndex = 7;
            plateNum.Text = "Plate Number";
            plateNum.Enter += plateNum_Enter;
            plateNum.Leave += plateNum_Leave;
            // 
            // comboVehicleType
            // 
            comboVehicleType.FlatStyle = FlatStyle.Flat;
            comboVehicleType.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboVehicleType.ForeColor = Color.DimGray;
            comboVehicleType.FormattingEnabled = true;
            comboVehicleType.Items.AddRange(new object[] { "Motorcycle", "Sedan", "SUV", "Van" });
            comboVehicleType.Location = new Point(407, 227);
            comboVehicleType.Name = "comboVehicleType";
            comboVehicleType.Size = new Size(418, 27);
            comboVehicleType.TabIndex = 8;
            comboVehicleType.Text = "Vehicle Type";
            comboVehicleType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboVehicleBrand
            // 
            comboVehicleBrand.FlatStyle = FlatStyle.Flat;
            comboVehicleBrand.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboVehicleBrand.ForeColor = Color.DimGray;
            comboVehicleBrand.FormattingEnabled = true;
            comboVehicleBrand.Items.AddRange(new object[] { "YAMAHA", "HONDA", "NMAX", "RUSI" });
            comboVehicleBrand.Location = new Point(407, 282);
            comboVehicleBrand.Name = "comboVehicleBrand";
            comboVehicleBrand.Size = new Size(418, 27);
            comboVehicleBrand.TabIndex = 9;
            comboVehicleBrand.Text = "Vehicle Brand";
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.White;
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Tahoma", 14.2F, FontStyle.Bold);
            submitButton.ForeColor = Color.FromArgb(50, 50, 50);
            submitButton.Location = new Point(528, 350);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(171, 43);
            submitButton.TabIndex = 6;
            submitButton.Text = "SUBMIT";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // ParkInDash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(950, 550);
            Controls.Add(submitButton);
            Controls.Add(comboVehicleBrand);
            Controls.Add(comboVehicleType);
            Controls.Add(plateNum);
            Controls.Add(button2);
            Controls.Add(panelDash);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ParkInDash";
            Text = "Form1";
            panelDash.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelDash;
        private Button parkInButton;
        private Panel panel1;
        private Button parkOutButton;
        private Button button1;
        private Button button2;
        private TextBox plateNum;
        private ComboBox comboVehicleType;
        private ComboBox comboVehicleBrand;
        private Button submitButton;
    }
}
