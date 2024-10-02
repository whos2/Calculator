namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSq = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.tabMemory = new System.Windows.Forms.TabPage();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPercent
            // 
            this.btnPercent.Enabled = false;
            this.btnPercent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPercent.Location = new System.Drawing.Point(21, 168);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(124, 42);
            this.btnPercent.TabIndex = 0;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            // 
            // btnCE
            // 
            this.btnCE.Enabled = false;
            this.btnCE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCE.Location = new System.Drawing.Point(151, 168);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(124, 42);
            this.btnCE.TabIndex = 0;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnC.Location = new System.Drawing.Point(281, 168);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(124, 42);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnPop
            // 
            this.btnPop.Enabled = false;
            this.btnPop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPop.Location = new System.Drawing.Point(411, 168);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(124, 42);
            this.btnPop.TabIndex = 0;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            // 
            // btnInverse
            // 
            this.btnInverse.Enabled = false;
            this.btnInverse.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInverse.Location = new System.Drawing.Point(21, 213);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(124, 42);
            this.btnInverse.TabIndex = 0;
            this.btnInverse.Text = "1/x";
            this.btnInverse.UseVisualStyleBackColor = true;
            // 
            // btnSqrt
            // 
            this.btnSqrt.Enabled = false;
            this.btnSqrt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSqrt.Location = new System.Drawing.Point(281, 213);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(124, 42);
            this.btnSqrt.TabIndex = 0;
            this.btnSqrt.Text = "x^0.5";
            this.btnSqrt.UseVisualStyleBackColor = true;
            // 
            // btnSq
            // 
            this.btnSq.Enabled = false;
            this.btnSq.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSq.Location = new System.Drawing.Point(151, 213);
            this.btnSq.Name = "btnSq";
            this.btnSq.Size = new System.Drawing.Size(124, 42);
            this.btnSq.TabIndex = 0;
            this.btnSq.Text = "x^2";
            this.btnSq.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDiv.Location = new System.Drawing.Point(411, 213);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(124, 42);
            this.btnDiv.TabIndex = 0;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn7.Location = new System.Drawing.Point(21, 258);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(124, 42);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn9.Location = new System.Drawing.Point(281, 258);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(124, 42);
            this.btn9.TabIndex = 0;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn8.Location = new System.Drawing.Point(151, 258);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(124, 42);
            this.btn8.TabIndex = 0;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMul.Location = new System.Drawing.Point(411, 258);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(124, 42);
            this.btnMul.TabIndex = 0;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4.Location = new System.Drawing.Point(21, 303);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(124, 42);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1.Location = new System.Drawing.Point(21, 348);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(124, 42);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Enabled = false;
            this.btnReverse.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReverse.Location = new System.Drawing.Point(21, 393);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(124, 42);
            this.btnReverse.TabIndex = 0;
            this.btnReverse.Text = "+/-";
            this.btnReverse.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn6.Location = new System.Drawing.Point(281, 303);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(124, 42);
            this.btn6.TabIndex = 0;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn3.Location = new System.Drawing.Point(281, 348);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(124, 42);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPoint.Location = new System.Drawing.Point(281, 393);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(124, 42);
            this.btnPoint.TabIndex = 0;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn5.Location = new System.Drawing.Point(151, 303);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(124, 42);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2.Location = new System.Drawing.Point(151, 348);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(124, 42);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn0.Location = new System.Drawing.Point(151, 393);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(124, 42);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSub.Location = new System.Drawing.Point(411, 303);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(124, 42);
            this.btnSub.TabIndex = 0;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(411, 348);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEqual.Location = new System.Drawing.Point(411, 393);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(124, 42);
            this.btnEqual.TabIndex = 0;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDisplay.Font = new System.Drawing.Font("微软雅黑", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDisplay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDisplay.Location = new System.Drawing.Point(21, 13);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(516, 138);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabMemory
            // 
            this.tabMemory.Location = new System.Drawing.Point(4, 29);
            this.tabMemory.Name = "tabMemory";
            this.tabMemory.Size = new System.Drawing.Size(237, 353);
            this.tabMemory.TabIndex = 1;
            this.tabMemory.Text = "记忆";
            this.tabMemory.UseVisualStyleBackColor = true;
            // 
            // tabHistory
            // 
            this.tabHistory.Location = new System.Drawing.Point(4, 29);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Size = new System.Drawing.Size(237, 353);
            this.tabHistory.TabIndex = 0;
            this.tabHistory.Text = "历史记录";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHistory);
            this.tabControl1.Controls.Add(this.tabMemory);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(543, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(245, 386);
            this.tabControl1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(709, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSq);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn0);
            this.Name = "Form1";
            this.Text = "计算器";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSq;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TabPage tabMemory;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
    }
}

