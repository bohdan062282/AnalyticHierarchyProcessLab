namespace lab1
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
            this.addNamesBox = new System.Windows.Forms.GroupBox();
            this.endAddingButton = new System.Windows.Forms.Button();
            this.addCriterionButton = new System.Windows.Forms.Button();
            this.criterionTextBox = new System.Windows.Forms.TextBox();
            this.prioritiesAddBox = new System.Windows.Forms.GroupBox();
            this.nextPairButton = new System.Windows.Forms.Button();
            this.valuesComboBox = new System.Windows.Forms.ComboBox();
            this.choice2 = new System.Windows.Forms.RadioButton();
            this.choice1 = new System.Windows.Forms.RadioButton();
            this.addNamesBox.SuspendLayout();
            this.prioritiesAddBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNamesBox
            // 
            this.addNamesBox.Controls.Add(this.endAddingButton);
            this.addNamesBox.Controls.Add(this.addCriterionButton);
            this.addNamesBox.Controls.Add(this.criterionTextBox);
            this.addNamesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNamesBox.Location = new System.Drawing.Point(12, 12);
            this.addNamesBox.Name = "addNamesBox";
            this.addNamesBox.Size = new System.Drawing.Size(320, 171);
            this.addNamesBox.TabIndex = 0;
            this.addNamesBox.TabStop = false;
            this.addNamesBox.Text = "Criterion";
            // 
            // endAddingButton
            // 
            this.endAddingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endAddingButton.Location = new System.Drawing.Point(6, 123);
            this.endAddingButton.Name = "endAddingButton";
            this.endAddingButton.Size = new System.Drawing.Size(302, 38);
            this.endAddingButton.TabIndex = 2;
            this.endAddingButton.Text = "End";
            this.endAddingButton.UseVisualStyleBackColor = true;
            this.endAddingButton.Click += new System.EventHandler(this.endAddingButton_Click);
            // 
            // addCriterionButton
            // 
            this.addCriterionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCriterionButton.Location = new System.Drawing.Point(6, 79);
            this.addCriterionButton.Name = "addCriterionButton";
            this.addCriterionButton.Size = new System.Drawing.Size(302, 38);
            this.addCriterionButton.TabIndex = 1;
            this.addCriterionButton.Text = "Add";
            this.addCriterionButton.UseVisualStyleBackColor = true;
            this.addCriterionButton.Click += new System.EventHandler(this.addCriterionButton_Click);
            // 
            // criterionTextBox
            // 
            this.criterionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.criterionTextBox.Location = new System.Drawing.Point(6, 42);
            this.criterionTextBox.Name = "criterionTextBox";
            this.criterionTextBox.Size = new System.Drawing.Size(302, 31);
            this.criterionTextBox.TabIndex = 0;
            // 
            // prioritiesAddBox
            // 
            this.prioritiesAddBox.Controls.Add(this.nextPairButton);
            this.prioritiesAddBox.Controls.Add(this.valuesComboBox);
            this.prioritiesAddBox.Controls.Add(this.choice2);
            this.prioritiesAddBox.Controls.Add(this.choice1);
            this.prioritiesAddBox.Enabled = false;
            this.prioritiesAddBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prioritiesAddBox.Location = new System.Drawing.Point(12, 209);
            this.prioritiesAddBox.Name = "prioritiesAddBox";
            this.prioritiesAddBox.Size = new System.Drawing.Size(320, 220);
            this.prioritiesAddBox.TabIndex = 1;
            this.prioritiesAddBox.TabStop = false;
            this.prioritiesAddBox.Text = "Priorities Add";
            // 
            // nextPairButton
            // 
            this.nextPairButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextPairButton.Location = new System.Drawing.Point(157, 14);
            this.nextPairButton.Name = "nextPairButton";
            this.nextPairButton.Size = new System.Drawing.Size(157, 200);
            this.nextPairButton.TabIndex = 3;
            this.nextPairButton.Text = "Next";
            this.nextPairButton.UseVisualStyleBackColor = true;
            this.nextPairButton.Click += new System.EventHandler(this.nextPairButton_Click);
            // 
            // valuesComboBox
            // 
            this.valuesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valuesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valuesComboBox.FormattingEnabled = true;
            this.valuesComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.valuesComboBox.Location = new System.Drawing.Point(6, 108);
            this.valuesComboBox.Name = "valuesComboBox";
            this.valuesComboBox.Size = new System.Drawing.Size(59, 33);
            this.valuesComboBox.TabIndex = 2;
            // 
            // choice2
            // 
            this.choice2.AutoSize = true;
            this.choice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choice2.Location = new System.Drawing.Point(6, 74);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(14, 13);
            this.choice2.TabIndex = 1;
            this.choice2.TabStop = true;
            this.choice2.UseVisualStyleBackColor = true;
            // 
            // choice1
            // 
            this.choice1.AutoSize = true;
            this.choice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choice1.Location = new System.Drawing.Point(6, 39);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(14, 13);
            this.choice1.TabIndex = 0;
            this.choice1.TabStop = true;
            this.choice1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(344, 441);
            this.Controls.Add(this.prioritiesAddBox);
            this.Controls.Add(this.addNamesBox);
            this.Name = "Form1";
            this.Text = "AHP";
            this.addNamesBox.ResumeLayout(false);
            this.addNamesBox.PerformLayout();
            this.prioritiesAddBox.ResumeLayout(false);
            this.prioritiesAddBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addNamesBox;
        private System.Windows.Forms.Button endAddingButton;
        private System.Windows.Forms.Button addCriterionButton;
        private System.Windows.Forms.TextBox criterionTextBox;
        private System.Windows.Forms.GroupBox prioritiesAddBox;
        private System.Windows.Forms.RadioButton choice2;
        private System.Windows.Forms.RadioButton choice1;
        private System.Windows.Forms.ComboBox valuesComboBox;
        private System.Windows.Forms.Button nextPairButton;
    }
}

