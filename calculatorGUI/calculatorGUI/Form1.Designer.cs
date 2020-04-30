namespace calculatorGUI
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
            this.value1 = new System.Windows.Forms.TextBox();
            this.plusButton = new System.Windows.Forms.Button();
            this.subractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.value2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.useResult1 = new System.Windows.Forms.Button();
            this.UseResult2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // value1
            // 
            this.value1.Location = new System.Drawing.Point(124, 196);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(136, 22);
            this.value1.TabIndex = 0;
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(370, 111);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(75, 23);
            this.plusButton.TabIndex = 1;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // subractButton
            // 
            this.subractButton.Location = new System.Drawing.Point(370, 158);
            this.subractButton.Name = "subractButton";
            this.subractButton.Size = new System.Drawing.Size(75, 23);
            this.subractButton.TabIndex = 2;
            this.subractButton.Text = "-";
            this.subractButton.UseVisualStyleBackColor = true;
            this.subractButton.Click += new System.EventHandler(this.subractButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(370, 207);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 23);
            this.multiplyButton.TabIndex = 3;
            this.multiplyButton.Text = "X";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(370, 260);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 23);
            this.divideButton.TabIndex = 4;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // value2
            // 
            this.value2.Location = new System.Drawing.Point(552, 196);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(137, 22);
            this.value2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Second Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result:";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(333, 388);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(141, 22);
            this.resultBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(672, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Directions:  Put your two values and click on the operation that you would like t" +
    "o perform!";
            // 
            // useResult1
            // 
            this.useResult1.Location = new System.Drawing.Point(74, 387);
            this.useResult1.Name = "useResult1";
            this.useResult1.Size = new System.Drawing.Size(186, 23);
            this.useResult1.TabIndex = 11;
            this.useResult1.Text = "Use Result as First Value";
            this.useResult1.UseVisualStyleBackColor = true;
            this.useResult1.Click += new System.EventHandler(this.useResult1_Click);
            // 
            // UseResult2
            // 
            this.UseResult2.Location = new System.Drawing.Point(536, 387);
            this.UseResult2.Name = "UseResult2";
            this.UseResult2.Size = new System.Drawing.Size(205, 23);
            this.UseResult2.TabIndex = 12;
            this.UseResult2.Text = "Use Result as Second Value";
            this.UseResult2.UseVisualStyleBackColor = true;
            this.UseResult2.Click += new System.EventHandler(this.UseResult2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UseResult2);
            this.Controls.Add(this.useResult1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subractButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.value1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox value1;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button subractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.TextBox value2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button useResult1;
        private System.Windows.Forms.Button UseResult2;
    }
}

