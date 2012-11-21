namespace Calculator
{
    partial class Calc
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bResult = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bCE = new System.Windows.Forms.Button();
            this.bMp = new System.Windows.Forms.Button();
            this.bMR = new System.Windows.Forms.Button();
            this.bBackspace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(4, 8);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(150, 20);
            this.tbDisplay.TabIndex = 0;
            this.tbDisplay.TextChanged += new System.EventHandler(this.tbDisplay_TextChanged);
            this.tbDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDisplay_KeyPress);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.White;
            this.b4.Location = new System.Drawing.Point(4, 136);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(33, 28);
            this.b4.TabIndex = 1;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.White;
            this.b5.Location = new System.Drawing.Point(43, 136);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(33, 28);
            this.b5.TabIndex = 2;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.White;
            this.b6.Location = new System.Drawing.Point(82, 136);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(33, 28);
            this.b6.TabIndex = 3;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.White;
            this.b9.Location = new System.Drawing.Point(82, 102);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(33, 28);
            this.b9.TabIndex = 6;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.White;
            this.b8.Location = new System.Drawing.Point(43, 102);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(33, 28);
            this.b8.TabIndex = 5;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.White;
            this.b7.Location = new System.Drawing.Point(4, 102);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(33, 28);
            this.b7.TabIndex = 4;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.White;
            this.b3.Location = new System.Drawing.Point(82, 170);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(33, 28);
            this.b3.TabIndex = 9;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.White;
            this.b2.Location = new System.Drawing.Point(43, 170);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(33, 28);
            this.b2.TabIndex = 8;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.White;
            this.b1.Location = new System.Drawing.Point(4, 170);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(33, 28);
            this.b1.TabIndex = 7;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.Color.White;
            this.b0.Location = new System.Drawing.Point(4, 204);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(72, 28);
            this.b0.TabIndex = 10;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bResult
            // 
            this.bResult.BackColor = System.Drawing.Color.White;
            this.bResult.Location = new System.Drawing.Point(121, 170);
            this.bResult.Name = "bResult";
            this.bResult.Size = new System.Drawing.Size(33, 62);
            this.bResult.TabIndex = 13;
            this.bResult.Text = "=";
            this.bResult.UseVisualStyleBackColor = false;
            this.bResult.Click += new System.EventHandler(this.bResult_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(121, 102);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(33, 28);
            this.bAdd.TabIndex = 12;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bSub
            // 
            this.bSub.BackColor = System.Drawing.Color.White;
            this.bSub.Location = new System.Drawing.Point(121, 136);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(33, 28);
            this.bSub.TabIndex = 11;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = false;
            this.bSub.Click += new System.EventHandler(this.bSub_Click);
            // 
            // bDiv
            // 
            this.bDiv.BackColor = System.Drawing.Color.White;
            this.bDiv.Location = new System.Drawing.Point(121, 68);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(33, 28);
            this.bDiv.TabIndex = 15;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = false;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // bDot
            // 
            this.bDot.BackColor = System.Drawing.Color.White;
            this.bDot.Location = new System.Drawing.Point(82, 204);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(33, 28);
            this.bDot.TabIndex = 14;
            this.bDot.Text = ".";
            this.bDot.UseVisualStyleBackColor = false;
            this.bDot.Click += new System.EventHandler(this.bDot_Click);
            // 
            // bMul
            // 
            this.bMul.BackColor = System.Drawing.Color.White;
            this.bMul.Location = new System.Drawing.Point(82, 68);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(33, 28);
            this.bMul.TabIndex = 16;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = false;
            this.bMul.Click += new System.EventHandler(this.bMul_Click);
            // 
            // bC
            // 
            this.bC.BackColor = System.Drawing.Color.White;
            this.bC.Location = new System.Drawing.Point(4, 68);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(33, 28);
            this.bC.TabIndex = 18;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = false;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bCE
            // 
            this.bCE.BackColor = System.Drawing.Color.White;
            this.bCE.Location = new System.Drawing.Point(43, 68);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(33, 28);
            this.bCE.TabIndex = 17;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = false;
            this.bCE.Click += new System.EventHandler(this.bCE_Click);
            // 
            // bMp
            // 
            this.bMp.BackColor = System.Drawing.Color.White;
            this.bMp.Location = new System.Drawing.Point(4, 34);
            this.bMp.Name = "bMp";
            this.bMp.Size = new System.Drawing.Size(33, 28);
            this.bMp.TabIndex = 22;
            this.bMp.Text = "M+";
            this.bMp.UseVisualStyleBackColor = false;
            this.bMp.Click += new System.EventHandler(this.bMp_Click);
            // 
            // bMR
            // 
            this.bMR.BackColor = System.Drawing.Color.White;
            this.bMR.Location = new System.Drawing.Point(43, 34);
            this.bMR.Name = "bMR";
            this.bMR.Size = new System.Drawing.Size(33, 28);
            this.bMR.TabIndex = 21;
            this.bMR.Text = "MR";
            this.bMR.UseVisualStyleBackColor = false;
            this.bMR.Click += new System.EventHandler(this.bMR_Click);
            // 
            // bBackspace
            // 
            this.bBackspace.BackColor = System.Drawing.Color.White;
            this.bBackspace.Location = new System.Drawing.Point(82, 34);
            this.bBackspace.Name = "bBackspace";
            this.bBackspace.Size = new System.Drawing.Size(72, 28);
            this.bBackspace.TabIndex = 19;
            this.bBackspace.Text = "Backspace";
            this.bBackspace.UseVisualStyleBackColor = false;
            this.bBackspace.Click += new System.EventHandler(this.bBackspace_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(159, 237);
            this.Controls.Add(this.bMp);
            this.Controls.Add(this.bMR);
            this.Controls.Add(this.bBackspace);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bDot);
            this.Controls.Add(this.bResult);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bSub);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.tbDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calc";
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bResult;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bDot;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.Button bMp;
        private System.Windows.Forms.Button bMR;
        private System.Windows.Forms.Button bBackspace;
    }
}

