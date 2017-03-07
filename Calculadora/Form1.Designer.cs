namespace Calculadora
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
            this.result = new System.Windows.Forms.TextBox();
            this.btnIgual = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(12, 12);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(231, 29);
            this.result.TabIndex = 0;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(204, 129);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(39, 79);
            this.btnIgual.TabIndex = 1;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.igual);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.digito);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.digito);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.digito);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(156, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 36);
            this.button4.TabIndex = 5;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.operacoes);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(156, 89);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 36);
            this.button5.TabIndex = 9;
            this.button5.Text = "*";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.operacoes);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(108, 89);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 36);
            this.button6.TabIndex = 8;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.digito);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(60, 89);
            this.button7.MaximumSize = new System.Drawing.Size(42, 36);
            this.button7.MinimumSize = new System.Drawing.Size(42, 36);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 36);
            this.button7.TabIndex = 7;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.digito);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 89);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 36);
            this.button8.TabIndex = 6;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.digito);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(108, 131);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(42, 36);
            this.button10.TabIndex = 12;
            this.button10.Text = "3";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.digito);
            // 
            // button11button11
            // 
            this.button11button11.Location = new System.Drawing.Point(60, 131);
            this.button11button11.Name = "button11button11";
            this.button11button11.Size = new System.Drawing.Size(42, 36);
            this.button11button11.TabIndex = 11;
            this.button11button11.Text = "2";
            this.button11button11.UseVisualStyleBackColor = true;
            this.button11button11.Click += new System.EventHandler(this.digito);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 131);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(42, 36);
            this.button12.TabIndex = 10;
            this.button12.Text = "1";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.digito);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(108, 173);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(42, 36);
            this.button14.TabIndex = 16;
            this.button14.Text = ",";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.digito);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(12, 173);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(90, 36);
            this.button16.TabIndex = 14;
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.digito);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(156, 171);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 36);
            this.button9.TabIndex = 18;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.operacoes);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(156, 129);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(42, 36);
            this.button13.TabIndex = 17;
            this.button13.Text = "+";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.operacoes);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(204, 47);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(42, 36);
            this.button11.TabIndex = 19;
            this.button11.Text = "C";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.limpar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 220);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.result);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
    }
}

