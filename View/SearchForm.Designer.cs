namespace View
{
    partial class SearchForm
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
            this.ElementNameComboBox = new System.Windows.Forms.ComboBox();
            this.ExitFindButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResistanceLabel = new System.Windows.Forms.Label();
            this.ElementNameLabel = new System.Windows.Forms.Label();
            this.ResistanceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ElementNameComboBox
            // 
            this.ElementNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ElementNameComboBox.FormattingEnabled = true;
            this.ElementNameComboBox.Items.AddRange(new object[] {
            "Резистор",
            "Конденсатор",
            "Катушка"});
            this.ElementNameComboBox.Location = new System.Drawing.Point(132, 7);
            this.ElementNameComboBox.Name = "ElementNameComboBox";
            this.ElementNameComboBox.Size = new System.Drawing.Size(129, 21);
            this.ElementNameComboBox.TabIndex = 21;
            this.ElementNameComboBox.SelectedIndexChanged += new System.EventHandler(this.ElementNameComboBox_SelectedIndexChanged);
            // 
            // ExitFindButton
            // 
            this.ExitFindButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitFindButton.Location = new System.Drawing.Point(186, 63);
            this.ExitFindButton.Name = "ExitFindButton";
            this.ExitFindButton.Size = new System.Drawing.Size(75, 23);
            this.ExitFindButton.TabIndex = 20;
            this.ExitFindButton.Text = "Отмена";
            this.ExitFindButton.UseVisualStyleBackColor = true;
            this.ExitFindButton.Click += new System.EventHandler(this.ExitFindButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(12, 63);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 19;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ResistanceLabel
            // 
            this.ResistanceLabel.AutoSize = true;
            this.ResistanceLabel.Location = new System.Drawing.Point(12, 37);
            this.ResistanceLabel.Name = "ResistanceLabel";
            this.ResistanceLabel.Size = new System.Drawing.Size(85, 13);
            this.ResistanceLabel.TabIndex = 16;
            this.ResistanceLabel.Text = "Сопротивление";
            this.ResistanceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ElementNameLabel
            // 
            this.ElementNameLabel.AutoSize = true;
            this.ElementNameLabel.Location = new System.Drawing.Point(12, 9);
            this.ElementNameLabel.Name = "ElementNameLabel";
            this.ElementNameLabel.Size = new System.Drawing.Size(109, 13);
            this.ElementNameLabel.TabIndex = 17;
            this.ElementNameLabel.Text = "Название элемента";
            // 
            // ResistanceTextBox
            // 
            this.ResistanceTextBox.Location = new System.Drawing.Point(132, 34);
            this.ResistanceTextBox.MaxLength = 10;
            this.ResistanceTextBox.Name = "ResistanceTextBox";
            this.ResistanceTextBox.Size = new System.Drawing.Size(129, 20);
            this.ResistanceTextBox.TabIndex = 18;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitFindButton;
            this.ClientSize = new System.Drawing.Size(266, 95);
            this.Controls.Add(this.ElementNameComboBox);
            this.Controls.Add(this.ExitFindButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ResistanceLabel);
            this.Controls.Add(this.ElementNameLabel);
            this.Controls.Add(this.ResistanceTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(282, 134);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(282, 134);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск элемента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ElementNameComboBox;
        private System.Windows.Forms.Button ExitFindButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label ResistanceLabel;
        private System.Windows.Forms.Label ElementNameLabel;
        private System.Windows.Forms.TextBox ResistanceTextBox;
    }
}