namespace calculators
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
            this.textBox_input_1 = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_subtract = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.textBox_input_2 = new System.Windows.Forms.TextBox();
            this.label_equals = new System.Windows.Forms.Label();
            this.textBox_results = new System.Windows.Forms.TextBox();
            this.button_Power = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_input_1
            // 
            this.textBox_input_1.Location = new System.Drawing.Point(12, 173);
            this.textBox_input_1.Name = "textBox_input_1";
            this.textBox_input_1.Size = new System.Drawing.Size(100, 20);
            this.textBox_input_1.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(147, 128);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_subtract
            // 
            this.button_subtract.Location = new System.Drawing.Point(147, 157);
            this.button_subtract.Name = "button_subtract";
            this.button_subtract.Size = new System.Drawing.Size(75, 23);
            this.button_subtract.TabIndex = 2;
            this.button_subtract.Text = "-";
            this.button_subtract.UseVisualStyleBackColor = true;
            this.button_subtract.Click += new System.EventHandler(this.button_subtract_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Location = new System.Drawing.Point(147, 186);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(75, 23);
            this.button_multiply.TabIndex = 3;
            this.button_multiply.Text = "*";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_divide
            // 
            this.button_divide.Location = new System.Drawing.Point(147, 215);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(75, 23);
            this.button_divide.TabIndex = 4;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // textBox_input_2
            // 
            this.textBox_input_2.Location = new System.Drawing.Point(248, 173);
            this.textBox_input_2.Name = "textBox_input_2";
            this.textBox_input_2.Size = new System.Drawing.Size(100, 20);
            this.textBox_input_2.TabIndex = 5;
            // 
            // label_equals
            // 
            this.label_equals.AutoSize = true;
            this.label_equals.Location = new System.Drawing.Point(401, 173);
            this.label_equals.Name = "label_equals";
            this.label_equals.Size = new System.Drawing.Size(13, 13);
            this.label_equals.TabIndex = 6;
            this.label_equals.Text = "=";
            // 
            // textBox_results
            // 
            this.textBox_results.Location = new System.Drawing.Point(472, 173);
            this.textBox_results.Name = "textBox_results";
            this.textBox_results.Size = new System.Drawing.Size(100, 20);
            this.textBox_results.TabIndex = 7;
            // 
            // button_Power
            // 
            this.button_Power.Location = new System.Drawing.Point(147, 244);
            this.button_Power.Name = "button_Power";
            this.button_Power.Size = new System.Drawing.Size(75, 23);
            this.button_Power.TabIndex = 8;
            this.button_Power.Text = "^";
            this.button_Power.UseVisualStyleBackColor = true;
            this.button_Power.Click += new System.EventHandler(this.button_Power_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(621, 353);
            this.Controls.Add(this.button_Power);
            this.Controls.Add(this.textBox_results);
            this.Controls.Add(this.label_equals);
            this.Controls.Add(this.textBox_input_2);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_subtract);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_input_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input_1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_subtract;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.TextBox textBox_input_2;
        private System.Windows.Forms.Label label_equals;
        private System.Windows.Forms.TextBox textBox_results;
        private System.Windows.Forms.Button button_Power;
    }
}

