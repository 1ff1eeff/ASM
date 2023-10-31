namespace ASM
{
    partial class CreateMAC
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
            textBox1 = new TextBox();
            label2 = new Label();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 7);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 9;
            label2.Text = "MAC-адрес";
            // 
            // button7
            // 
            button7.Location = new Point(12, 54);
            button7.Name = "button7";
            button7.Size = new Size(90, 23);
            button7.TabIndex = 7;
            button7.Text = "ОК";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(108, 53);
            button8.Name = "button8";
            button8.Size = new Size(90, 23);
            button8.TabIndex = 8;
            button8.Text = "Отмена";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // CreateMAC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(210, 88);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(button8);
            MaximizeBox = false;
            MaximumSize = new Size(226, 127);
            MinimumSize = new Size(226, 127);
            Name = "CreateMAC";
            Text = "Добавление MAC";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label2;
        private Button button7;
        private Button button8;
    }
}