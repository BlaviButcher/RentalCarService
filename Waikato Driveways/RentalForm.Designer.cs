namespace Waikato_Driveways
{
    partial class RentalForm
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
            this._listBox = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this._regoTextBox = new System.Windows.Forms.TextBox();
            this._vehicleTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._navigationComboBox = new System.Windows.Forms.ComboBox();
            this._fuelTypeComboBox = new System.Windows.Forms.ComboBox();
            this._lentTypeComboBox = new System.Windows.Forms.ComboBox();
            this._dateDueBackTextBox = new System.Windows.Forms.TextBox();
            this._wofDueTextBox = new System.Windows.Forms.TextBox();
            this._replaceButton = new System.Windows.Forms.Button();
            this._deleteButton = new System.Windows.Forms.Button();
            this._rentalRateTextBox = new System.Windows.Forms.TextBox();
            this._lendButton = new System.Windows.Forms.Button();
            this._maintainanceButton = new System.Windows.Forms.Button();
            this._fleetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _listBox
            // 
            this._listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._listBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this._listBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._listBox.FormattingEnabled = true;
            this._listBox.ItemHeight = 17;
            this._listBox.Location = new System.Drawing.Point(5, 30);
            this._listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._listBox.MinimumSize = new System.Drawing.Size(620, 4);
            this._listBox.Name = "_listBox";
            this._listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this._listBox.Size = new System.Drawing.Size(620, 308);
            this._listBox.TabIndex = 0;
            this._listBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this._listBox_DrawItem);
            this._listBox.SelectedIndexChanged += new System.EventHandler(this._listBox_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(280, 437);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(336, 28);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // _regoTextBox
            // 
            this._regoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._regoTextBox.Location = new System.Drawing.Point(137, 350);
            this._regoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._regoTextBox.Name = "_regoTextBox";
            this._regoTextBox.Size = new System.Drawing.Size(120, 22);
            this._regoTextBox.TabIndex = 2;
            this._regoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._regoTextBox_KeyPress);
            // 
            // _vehicleTypeComboBox
            // 
            this._vehicleTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._vehicleTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._vehicleTypeComboBox.FormattingEnabled = true;
            this._vehicleTypeComboBox.Location = new System.Drawing.Point(137, 387);
            this._vehicleTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._vehicleTypeComboBox.Name = "_vehicleTypeComboBox";
            this._vehicleTypeComboBox.Size = new System.Drawing.Size(120, 24);
            this._vehicleTypeComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 353);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rego";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 390);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Vehicle Type";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 428);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Navigation";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 468);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fuel Type";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 508);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Rental Rate";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 545);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "WOF Due";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 580);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Lent";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 618);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Due Back";
            // 
            // _navigationComboBox
            // 
            this._navigationComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._navigationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._navigationComboBox.FormattingEnabled = true;
            this._navigationComboBox.Items.AddRange(new object[] {
            "Has GPS",
            "No GPS"});
            this._navigationComboBox.Location = new System.Drawing.Point(136, 425);
            this._navigationComboBox.Name = "_navigationComboBox";
            this._navigationComboBox.Size = new System.Drawing.Size(121, 24);
            this._navigationComboBox.TabIndex = 21;
            // 
            // _fuelTypeComboBox
            // 
            this._fuelTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._fuelTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._fuelTypeComboBox.FormattingEnabled = true;
            this._fuelTypeComboBox.Items.AddRange(new object[] {
            "Petrol",
            "Electric"});
            this._fuelTypeComboBox.Location = new System.Drawing.Point(137, 464);
            this._fuelTypeComboBox.Name = "_fuelTypeComboBox";
            this._fuelTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this._fuelTypeComboBox.TabIndex = 22;
            // 
            // _lentTypeComboBox
            // 
            this._lentTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._lentTypeComboBox.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lentTypeComboBox.FormattingEnabled = true;
            this._lentTypeComboBox.Items.AddRange(new object[] {
            "In",
            "Out"});
            this._lentTypeComboBox.Location = new System.Drawing.Point(136, 577);
            this._lentTypeComboBox.Name = "_lentTypeComboBox";
            this._lentTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this._lentTypeComboBox.TabIndex = 23;
            // 
            // _dateDueBackTextBox
            // 
            this._dateDueBackTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._dateDueBackTextBox.Location = new System.Drawing.Point(136, 618);
            this._dateDueBackTextBox.Name = "_dateDueBackTextBox";
            this._dateDueBackTextBox.Size = new System.Drawing.Size(121, 22);
            this._dateDueBackTextBox.TabIndex = 25;
            // 
            // _wofDueTextBox
            // 
            this._wofDueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._wofDueTextBox.Location = new System.Drawing.Point(136, 541);
            this._wofDueTextBox.Name = "_wofDueTextBox";
            this._wofDueTextBox.Size = new System.Drawing.Size(121, 22);
            this._wofDueTextBox.TabIndex = 26;
            // 
            // _replaceButton
            // 
            this._replaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._replaceButton.Location = new System.Drawing.Point(280, 400);
            this._replaceButton.Name = "_replaceButton";
            this._replaceButton.Size = new System.Drawing.Size(336, 32);
            this._replaceButton.TabIndex = 27;
            this._replaceButton.Text = "Replace";
            this._replaceButton.UseVisualStyleBackColor = true;
            this._replaceButton.Click += new System.EventHandler(this._replaceButton_Click);
            // 
            // _deleteButton
            // 
            this._deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._deleteButton.Location = new System.Drawing.Point(280, 362);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(336, 32);
            this._deleteButton.TabIndex = 28;
            this._deleteButton.Text = "Delete";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Click += new System.EventHandler(this._deleteButton_Click);
            // 
            // _rentalRateTextBox
            // 
            this._rentalRateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._rentalRateTextBox.Location = new System.Drawing.Point(138, 504);
            this._rentalRateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._rentalRateTextBox.Name = "_rentalRateTextBox";
            this._rentalRateTextBox.ReadOnly = true;
            this._rentalRateTextBox.Size = new System.Drawing.Size(120, 22);
            this._rentalRateTextBox.TabIndex = 5;
            // 
            // _lendButton
            // 
            this._lendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lendButton.Location = new System.Drawing.Point(282, 488);
            this._lendButton.Name = "_lendButton";
            this._lendButton.Size = new System.Drawing.Size(336, 42);
            this._lendButton.TabIndex = 29;
            this._lendButton.Text = "Lend";
            this._lendButton.UseVisualStyleBackColor = true;
            this._lendButton.Click += new System.EventHandler(this._lendButton_Click);
            // 
            // _maintainanceButton
            // 
            this._maintainanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._maintainanceButton.Location = new System.Drawing.Point(282, 535);
            this._maintainanceButton.Name = "_maintainanceButton";
            this._maintainanceButton.Size = new System.Drawing.Size(336, 42);
            this._maintainanceButton.TabIndex = 30;
            this._maintainanceButton.Text = "Maintainance View";
            this._maintainanceButton.UseVisualStyleBackColor = true;
            this._maintainanceButton.Click += new System.EventHandler(this._maintainanceButton_Click);
            // 
            // _fleetButton
            // 
            this._fleetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._fleetButton.Location = new System.Drawing.Point(282, 584);
            this._fleetButton.Name = "_fleetButton";
            this._fleetButton.Size = new System.Drawing.Size(336, 42);
            this._fleetButton.TabIndex = 31;
            this._fleetButton.Text = "Fleet View";
            this._fleetButton.UseVisualStyleBackColor = true;
            this._fleetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 649);
            this.Controls.Add(this._fleetButton);
            this.Controls.Add(this._maintainanceButton);
            this.Controls.Add(this._lendButton);
            this.Controls.Add(this._deleteButton);
            this.Controls.Add(this._replaceButton);
            this.Controls.Add(this._wofDueTextBox);
            this.Controls.Add(this._dateDueBackTextBox);
            this.Controls.Add(this._lentTypeComboBox);
            this.Controls.Add(this._fuelTypeComboBox);
            this.Controls.Add(this._navigationComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._vehicleTypeComboBox);
            this.Controls.Add(this._rentalRateTextBox);
            this.Controls.Add(this._regoTextBox);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this._listBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(646, 696);
            this.Name = "RentalForm";
            this.Text = "RentalForm";
            this.SizeChanged += new System.EventHandler(this.RentalForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _listBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox _regoTextBox;
        private System.Windows.Forms.ComboBox _vehicleTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox _navigationComboBox;
        private System.Windows.Forms.ComboBox _fuelTypeComboBox;
        private System.Windows.Forms.ComboBox _lentTypeComboBox;
        private System.Windows.Forms.TextBox _dateDueBackTextBox;
        private System.Windows.Forms.TextBox _wofDueTextBox;
        private System.Windows.Forms.Button _replaceButton;
        private System.Windows.Forms.Button _deleteButton;
        private System.Windows.Forms.TextBox _rentalRateTextBox;
        private System.Windows.Forms.Button _lendButton;
        private System.Windows.Forms.Button _maintainanceButton;
        private System.Windows.Forms.Button _fleetButton;
    }
}

