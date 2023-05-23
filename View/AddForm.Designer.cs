
namespace View
{
    partial class AddForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.RandomValueButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.Item2TextBox = new System.Windows.Forms.TextBox();
            this.Item1TextBox = new System.Windows.Forms.TextBox();
            this.ElementNameComboBox = new System.Windows.Forms.ComboBox();
            this.Item2Label = new System.Windows.Forms.Label();
            this.ElementNameLabel = new System.Windows.Forms.Label();
            this.Item1Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(191, 95);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 37);
            this.ExitButton.TabIndex = 24;
            this.ExitButton.Text = "Отмена";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RandomValueButton
            // 
            this.RandomValueButton.Location = new System.Drawing.Point(102, 95);
            this.RandomValueButton.Name = "RandomValueButton";
            this.RandomValueButton.Size = new System.Drawing.Size(76, 37);
            this.RandomValueButton.TabIndex = 25;
            this.RandomValueButton.Text = "Случайное значение";
            this.RandomValueButton.UseVisualStyleBackColor = true;
            this.RandomValueButton.Click += new System.EventHandler(this.RandomValueButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(18, 95);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 37);
            this.AddButton.TabIndex = 26;
            this.AddButton.Text = "Ok";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Item2TextBox
            // 
            this.Item2TextBox.Location = new System.Drawing.Point(153, 69);
            this.Item2TextBox.MaxLength = 10;
            this.Item2TextBox.Name = "Item2TextBox";
            this.Item2TextBox.Size = new System.Drawing.Size(113, 20);
            this.Item2TextBox.TabIndex = 23;
            // 
            // Item1TextBox
            // 
            this.Item1TextBox.Location = new System.Drawing.Point(153, 42);
            this.Item1TextBox.MaxLength = 10;
            this.Item1TextBox.Name = "Item1TextBox";
            this.Item1TextBox.Size = new System.Drawing.Size(113, 20);
            this.Item1TextBox.TabIndex = 22;
            // 
            // ElementNameComboBox
            // 
            this.ElementNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ElementNameComboBox.FormattingEnabled = true;
            this.ElementNameComboBox.Items.AddRange(new object[] {
            "Резистор",
            "Конденсатор",
            "Катушка"});
            this.ElementNameComboBox.Location = new System.Drawing.Point(153, 12);
            this.ElementNameComboBox.Name = "ElementNameComboBox";
            this.ElementNameComboBox.Size = new System.Drawing.Size(113, 21);
            this.ElementNameComboBox.TabIndex = 21;
            this.ElementNameComboBox.SelectedIndexChanged += new System.EventHandler(this.ElementNameComboBox_SelectedIndexChanged);
            // 
            // Item2Label
            // 
            this.Item2Label.AutoSize = true;
            this.Item2Label.Location = new System.Drawing.Point(18, 69);
            this.Item2Label.Name = "Item2Label";
            this.Item2Label.Size = new System.Drawing.Size(59, 13);
            this.Item2Label.TabIndex = 18;
            this.Item2Label.Text = "Item2Label";
            // 
            // ElementNameLabel
            // 
            this.ElementNameLabel.AutoSize = true;
            this.ElementNameLabel.Location = new System.Drawing.Point(18, 15);
            this.ElementNameLabel.Name = "ElementNameLabel";
            this.ElementNameLabel.Size = new System.Drawing.Size(109, 13);
            this.ElementNameLabel.TabIndex = 19;
            this.ElementNameLabel.Text = "Название элемента";
            // 
            // Item1Label
            // 
            this.Item1Label.AutoSize = true;
            this.Item1Label.Location = new System.Drawing.Point(18, 42);
            this.Item1Label.Name = "Item1Label";
            this.Item1Label.Size = new System.Drawing.Size(59, 13);
            this.Item1Label.TabIndex = 20;
            this.Item1Label.Text = "Item1Label";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(281, 142);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RandomValueButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Item2TextBox);
            this.Controls.Add(this.Item1TextBox);
            this.Controls.Add(this.ElementNameComboBox);
            this.Controls.Add(this.Item2Label);
            this.Controls.Add(this.ElementNameLabel);
            this.Controls.Add(this.Item1Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление элемента";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RandomValueButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox Item2TextBox;
        private System.Windows.Forms.TextBox Item1TextBox;
        private System.Windows.Forms.ComboBox ElementNameComboBox;
        private System.Windows.Forms.Label Item2Label;
        private System.Windows.Forms.Label ElementNameLabel;
        private System.Windows.Forms.Label Item1Label;
    }
}