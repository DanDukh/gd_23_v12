namespace Fibonacci
{
    partial class Form1
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
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputTextbox = new System.Windows.Forms.TextBox();
            this.getResultButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.manualButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextbox
            // 
            this.inputTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextbox.Location = new System.Drawing.Point(49, 247);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(293, 44);
            this.inputTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите порядковый номер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Число Фибоначчи:";
            // 
            // outputTextbox
            // 
            this.outputTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.outputTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTextbox.Location = new System.Drawing.Point(316, 369);
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.ReadOnly = true;
            this.outputTextbox.Size = new System.Drawing.Size(468, 40);
            this.outputTextbox.TabIndex = 3;
            // 
            // getResultButton
            // 
            this.getResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getResultButton.Location = new System.Drawing.Point(511, 247);
            this.getResultButton.Name = "getResultButton";
            this.getResultButton.Size = new System.Drawing.Size(273, 44);
            this.getResultButton.TabIndex = 4;
            this.getResultButton.Text = "Получить ответ";
            this.getResultButton.UseVisualStyleBackColor = true;
            this.getResultButton.Click += new System.EventHandler(this.getResultButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(348, 246);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(157, 45);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Сбросить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(745, 118);
            this.label3.TabIndex = 6;
            this.label3.Text = "Калькулятор чисел Фибоначчи";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // manualButton
            // 
            this.manualButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manualButton.Location = new System.Drawing.Point(12, 14);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(146, 63);
            this.manualButton.TabIndex = 7;
            this.manualButton.Text = "Руководство пользователя";
            this.manualButton.UseVisualStyleBackColor = true;
            this.manualButton.Click += new System.EventHandler(this.manualButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 498);
            this.Controls.Add(this.manualButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.getResultButton);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextbox);
            this.Name = "Form1";
            this.Text = "Числа Фибоначчи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputTextbox;
        private System.Windows.Forms.Button getResultButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button manualButton;
    }
}

