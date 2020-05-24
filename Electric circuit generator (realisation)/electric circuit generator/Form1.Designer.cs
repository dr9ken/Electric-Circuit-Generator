namespace electric_circuit_generator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToL = new System.Windows.Forms.RichTextBox();
            this.FromL = new System.Windows.Forms.RichTextBox();
            this.InductorsValueTag = new System.Windows.Forms.RichTextBox();
            this.ResistorsValueTag = new System.Windows.Forms.RichTextBox();
            this.ToR = new System.Windows.Forms.RichTextBox();
            this.FromR = new System.Windows.Forms.RichTextBox();
            this.ToC = new System.Windows.Forms.RichTextBox();
            this.FromC = new System.Windows.Forms.RichTextBox();
            this.CapacitorValueTag = new System.Windows.Forms.RichTextBox();
            this.NumberR = new System.Windows.Forms.RichTextBox();
            this.ResistorsNumberTag = new System.Windows.Forms.RichTextBox();
            this.NumberL = new System.Windows.Forms.RichTextBox();
            this.InductorsNumberTag = new System.Windows.Forms.RichTextBox();
            this.NumberC = new System.Windows.Forms.RichTextBox();
            this.CapacitorsNumberTag = new System.Windows.Forms.RichTextBox();
            this.SourceNumberTag = new System.Windows.Forms.RichTextBox();
            this.SourcesBox = new System.Windows.Forms.ComboBox();
            this.ToS = new System.Windows.Forms.RichTextBox();
            this.FromS = new System.Windows.Forms.RichTextBox();
            this.SourceValueTag = new System.Windows.Forms.RichTextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ToL
            // 
            this.ToL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToL.Location = new System.Drawing.Point(510, 51);
            this.ToL.MaxLength = 2;
            this.ToL.Multiline = false;
            this.ToL.Name = "ToL";
            this.ToL.Size = new System.Drawing.Size(27, 24);
            this.ToL.TabIndex = 6;
            this.ToL.Text = "";
            this.ToL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToL_Pressed);
            // 
            // FromL
            // 
            this.FromL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromL.Location = new System.Drawing.Point(477, 51);
            this.FromL.MaxLength = 2;
            this.FromL.Multiline = false;
            this.FromL.Name = "FromL";
            this.FromL.Size = new System.Drawing.Size(27, 24);
            this.FromL.TabIndex = 5;
            this.FromL.Text = "";
            this.FromL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FromL_Pressed);
            // 
            // InductorsValueTag
            // 
            this.InductorsValueTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InductorsValueTag.CausesValidation = false;
            this.InductorsValueTag.Enabled = false;
            this.InductorsValueTag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InductorsValueTag.Location = new System.Drawing.Point(294, 51);
            this.InductorsValueTag.Multiline = false;
            this.InductorsValueTag.Name = "InductorsValueTag";
            this.InductorsValueTag.ReadOnly = true;
            this.InductorsValueTag.Size = new System.Drawing.Size(192, 29);
            this.InductorsValueTag.TabIndex = 4;
            this.InductorsValueTag.Text = "Value of Inductors";
            // 
            // ResistorsValueTag
            // 
            this.ResistorsValueTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResistorsValueTag.CausesValidation = false;
            this.ResistorsValueTag.Enabled = false;
            this.ResistorsValueTag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResistorsValueTag.ForeColor = System.Drawing.Color.Black;
            this.ResistorsValueTag.Location = new System.Drawing.Point(294, 16);
            this.ResistorsValueTag.Multiline = false;
            this.ResistorsValueTag.Name = "ResistorsValueTag";
            this.ResistorsValueTag.ReadOnly = true;
            this.ResistorsValueTag.Size = new System.Drawing.Size(192, 29);
            this.ResistorsValueTag.TabIndex = 1;
            this.ResistorsValueTag.Text = "Value of Resistors";
            // 
            // ToR
            // 
            this.ToR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToR.Location = new System.Drawing.Point(510, 16);
            this.ToR.MaxLength = 2;
            this.ToR.Multiline = false;
            this.ToR.Name = "ToR";
            this.ToR.Size = new System.Drawing.Size(27, 24);
            this.ToR.TabIndex = 3;
            this.ToR.Text = "";
            this.ToR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToR_Pressed);
            // 
            // FromR
            // 
            this.FromR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromR.Location = new System.Drawing.Point(477, 16);
            this.FromR.MaxLength = 2;
            this.FromR.Multiline = false;
            this.FromR.Name = "FromR";
            this.FromR.Size = new System.Drawing.Size(27, 24);
            this.FromR.TabIndex = 2;
            this.FromR.Text = "";
            this.FromR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FromR_Pressed);
            // 
            // ToC
            // 
            this.ToC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToC.Location = new System.Drawing.Point(510, 86);
            this.ToC.MaxLength = 2;
            this.ToC.Multiline = false;
            this.ToC.Name = "ToC";
            this.ToC.Size = new System.Drawing.Size(27, 24);
            this.ToC.TabIndex = 9;
            this.ToC.Text = "";
            this.ToC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToC_Pressed);
            // 
            // FromC
            // 
            this.FromC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromC.Location = new System.Drawing.Point(477, 86);
            this.FromC.MaxLength = 2;
            this.FromC.Multiline = false;
            this.FromC.Name = "FromC";
            this.FromC.Size = new System.Drawing.Size(27, 24);
            this.FromC.TabIndex = 8;
            this.FromC.Text = "";
            this.FromC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fromC_Pressed);
            // 
            // CapacitorValueTag
            // 
            this.CapacitorValueTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CapacitorValueTag.CausesValidation = false;
            this.CapacitorValueTag.Enabled = false;
            this.CapacitorValueTag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacitorValueTag.Location = new System.Drawing.Point(294, 86);
            this.CapacitorValueTag.Multiline = false;
            this.CapacitorValueTag.Name = "CapacitorValueTag";
            this.CapacitorValueTag.ReadOnly = true;
            this.CapacitorValueTag.Size = new System.Drawing.Size(192, 29);
            this.CapacitorValueTag.TabIndex = 7;
            this.CapacitorValueTag.Text = "Value of Capacitors";
            // 
            // NumberR
            // 
            this.NumberR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberR.Location = new System.Drawing.Point(217, 16);
            this.NumberR.MaxLength = 2;
            this.NumberR.Multiline = false;
            this.NumberR.Name = "NumberR";
            this.NumberR.Size = new System.Drawing.Size(27, 24);
            this.NumberR.TabIndex = 11;
            this.NumberR.Text = "";
            // 
            // ResistorsNumberTag
            // 
            this.ResistorsNumberTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResistorsNumberTag.CausesValidation = false;
            this.ResistorsNumberTag.Enabled = false;
            this.ResistorsNumberTag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResistorsNumberTag.ForeColor = System.Drawing.Color.Black;
            this.ResistorsNumberTag.Location = new System.Drawing.Point(14, 16);
            this.ResistorsNumberTag.Multiline = false;
            this.ResistorsNumberTag.Name = "ResistorsNumberTag";
            this.ResistorsNumberTag.ReadOnly = true;
            this.ResistorsNumberTag.Size = new System.Drawing.Size(200, 29);
            this.ResistorsNumberTag.TabIndex = 10;
            this.ResistorsNumberTag.Text = "Number of Resistors";
            // 
            // NumberL
            // 
            this.NumberL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberL.Location = new System.Drawing.Point(217, 51);
            this.NumberL.MaxLength = 2;
            this.NumberL.Multiline = false;
            this.NumberL.Name = "NumberL";
            this.NumberL.Size = new System.Drawing.Size(27, 24);
            this.NumberL.TabIndex = 13;
            this.NumberL.Text = "";
            // 
            // InductorsNumberTag
            // 
            this.InductorsNumberTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InductorsNumberTag.CausesValidation = false;
            this.InductorsNumberTag.Enabled = false;
            this.InductorsNumberTag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InductorsNumberTag.ForeColor = System.Drawing.Color.Black;
            this.InductorsNumberTag.Location = new System.Drawing.Point(14, 51);
            this.InductorsNumberTag.Multiline = false;
            this.InductorsNumberTag.Name = "InductorsNumberTag";
            this.InductorsNumberTag.ReadOnly = true;
            this.InductorsNumberTag.Size = new System.Drawing.Size(200, 29);
            this.InductorsNumberTag.TabIndex = 12;
            this.InductorsNumberTag.Text = "Number of Inductors";
            // 
            // NumberC
            // 
            this.NumberC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberC.Location = new System.Drawing.Point(217, 86);
            this.NumberC.MaxLength = 2;
            this.NumberC.Multiline = false;
            this.NumberC.Name = "NumberC";
            this.NumberC.Size = new System.Drawing.Size(27, 24);
            this.NumberC.TabIndex = 15;
            this.NumberC.Text = "";
            // 
            // CapacitorsNumberTag
            // 
            this.CapacitorsNumberTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CapacitorsNumberTag.CausesValidation = false;
            this.CapacitorsNumberTag.Enabled = false;
            this.CapacitorsNumberTag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacitorsNumberTag.ForeColor = System.Drawing.Color.Black;
            this.CapacitorsNumberTag.Location = new System.Drawing.Point(14, 86);
            this.CapacitorsNumberTag.Multiline = false;
            this.CapacitorsNumberTag.Name = "CapacitorsNumberTag";
            this.CapacitorsNumberTag.ReadOnly = true;
            this.CapacitorsNumberTag.Size = new System.Drawing.Size(200, 29);
            this.CapacitorsNumberTag.TabIndex = 14;
            this.CapacitorsNumberTag.Text = "Number of Capacitor";
            // 
            // SourceNumberTag
            // 
            this.SourceNumberTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SourceNumberTag.CausesValidation = false;
            this.SourceNumberTag.Enabled = false;
            this.SourceNumberTag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceNumberTag.ForeColor = System.Drawing.Color.Black;
            this.SourceNumberTag.Location = new System.Drawing.Point(14, 121);
            this.SourceNumberTag.Multiline = false;
            this.SourceNumberTag.Name = "SourceNumberTag";
            this.SourceNumberTag.ReadOnly = true;
            this.SourceNumberTag.Size = new System.Drawing.Size(200, 29);
            this.SourceNumberTag.TabIndex = 16;
            this.SourceNumberTag.Text = "Name of Source";
            // 
            // SourcesBox
            // 
            this.SourcesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SourcesBox.FormattingEnabled = true;
            this.SourcesBox.Items.AddRange(new object[] {
            "i(t)",
            "u(t)"});
            this.SourcesBox.Location = new System.Drawing.Point(179, 123);
            this.SourcesBox.MaxDropDownItems = 2;
            this.SourcesBox.Name = "SourcesBox";
            this.SourcesBox.Size = new System.Drawing.Size(65, 24);
            this.SourcesBox.TabIndex = 18;
            this.SourcesBox.Text = "source";
            this.SourcesBox.TextUpdate += new System.EventHandler(this.SourcesBox_TextUpdate);
            // 
            // ToS
            // 
            this.ToS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ToS.Location = new System.Drawing.Point(510, 118);
            this.ToS.MaxLength = 2;
            this.ToS.Multiline = false;
            this.ToS.Name = "ToS";
            this.ToS.Size = new System.Drawing.Size(27, 24);
            this.ToS.TabIndex = 21;
            this.ToS.Text = "";
            this.ToS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToS_Pressed);
            // 
            // FromS
            // 
            this.FromS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromS.Location = new System.Drawing.Point(477, 118);
            this.FromS.MaxLength = 2;
            this.FromS.Multiline = false;
            this.FromS.Name = "FromS";
            this.FromS.Size = new System.Drawing.Size(27, 24);
            this.FromS.TabIndex = 20;
            this.FromS.Text = "";
            this.FromS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FromS_Pressed);
            // 
            // SourceValueTag
            // 
            this.SourceValueTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SourceValueTag.CausesValidation = false;
            this.SourceValueTag.Enabled = false;
            this.SourceValueTag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceValueTag.Location = new System.Drawing.Point(294, 118);
            this.SourceValueTag.Multiline = false;
            this.SourceValueTag.Name = "SourceValueTag";
            this.SourceValueTag.ReadOnly = true;
            this.SourceValueTag.Size = new System.Drawing.Size(192, 29);
            this.SourceValueTag.TabIndex = 19;
            this.SourceValueTag.Text = "Values of Source";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Enabled = false;
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.Location = new System.Drawing.Point(217, 171);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(211, 30);
            this.GenerateButton.TabIndex = 22;
            this.GenerateButton.Text = "Generate electrical сircuit";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(14, 171);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(188, 30);
            this.SaveButton.TabIndex = 23;
            this.SaveButton.Text = "Find a file to save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = global::electric_circuit_generator.Properties.Resources.Refresh;
            this.RefreshButton.Enabled = false;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.Location = new System.Drawing.Point(510, 171);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(30, 30);
            this.RefreshButton.TabIndex = 25;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::electric_circuit_generator.Properties.Resources.no;
            this.PictureBox.Location = new System.Drawing.Point(456, 171);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(30, 30);
            this.PictureBox.TabIndex = 24;
            this.PictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(554, 221);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.ToS);
            this.Controls.Add(this.FromS);
            this.Controls.Add(this.SourceValueTag);
            this.Controls.Add(this.SourcesBox);
            this.Controls.Add(this.SourceNumberTag);
            this.Controls.Add(this.NumberC);
            this.Controls.Add(this.CapacitorsNumberTag);
            this.Controls.Add(this.NumberL);
            this.Controls.Add(this.InductorsNumberTag);
            this.Controls.Add(this.NumberR);
            this.Controls.Add(this.ResistorsNumberTag);
            this.Controls.Add(this.ToC);
            this.Controls.Add(this.FromC);
            this.Controls.Add(this.CapacitorValueTag);
            this.Controls.Add(this.ToL);
            this.Controls.Add(this.FromL);
            this.Controls.Add(this.InductorsValueTag);
            this.Controls.Add(this.ToR);
            this.Controls.Add(this.FromR);
            this.Controls.Add(this.ResistorsValueTag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(814, 484);
            this.Name = "Form1";
            this.Text = "Electric circuit generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox ToL;
        private System.Windows.Forms.RichTextBox FromL;
        private System.Windows.Forms.RichTextBox InductorsValueTag;
        private System.Windows.Forms.RichTextBox ResistorsValueTag;
        private System.Windows.Forms.RichTextBox ToR;
        private System.Windows.Forms.RichTextBox FromR;
        private System.Windows.Forms.RichTextBox ToC;
        private System.Windows.Forms.RichTextBox FromC;
        private System.Windows.Forms.RichTextBox CapacitorValueTag;
        private System.Windows.Forms.RichTextBox NumberR;
        private System.Windows.Forms.RichTextBox ResistorsNumberTag;
        private System.Windows.Forms.RichTextBox NumberL;
        private System.Windows.Forms.RichTextBox InductorsNumberTag;
        private System.Windows.Forms.RichTextBox NumberC;
        private System.Windows.Forms.RichTextBox CapacitorsNumberTag;
        private System.Windows.Forms.RichTextBox SourceNumberTag;
        private System.Windows.Forms.ComboBox SourcesBox;
        private System.Windows.Forms.RichTextBox ToS;
        private System.Windows.Forms.RichTextBox FromS;
        private System.Windows.Forms.RichTextBox SourceValueTag;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button RefreshButton;
    }
}

