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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.equalBtn = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.TextBox();
            this.num1Btn = new System.Windows.Forms.Button();
            this.num2Btn = new System.Windows.Forms.Button();
            this.num3Btn = new System.Windows.Forms.Button();
            this.num4Btn = new System.Windows.Forms.Button();
            this.num5Btn = new System.Windows.Forms.Button();
            this.num6Btn = new System.Windows.Forms.Button();
            this.num7Btn = new System.Windows.Forms.Button();
            this.num8Btn = new System.Windows.Forms.Button();
            this.num9Btn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.num0Btn = new System.Windows.Forms.Button();
            this.OpacityScrollBar = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // equalBtn
            // 
            this.equalBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.equalBtn.BackColor = System.Drawing.SystemColors.Control;
            this.equalBtn.Font = new System.Drawing.Font("Open Sans Semibold", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalBtn.Location = new System.Drawing.Point(97, 450);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(231, 81);
            this.equalBtn.TabIndex = 1;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = false;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // resultText
            // 
            this.resultText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultText.Font = new System.Drawing.Font("Segoe UI Semibold", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultText.Location = new System.Drawing.Point(10, 37);
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.Size = new System.Drawing.Size(318, 96);
            this.resultText.TabIndex = 2;
            this.resultText.Text = "0";
            this.resultText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num1Btn
            // 
            this.num1Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num1Btn.Font = new System.Drawing.Font("Open Sans Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1Btn.Location = new System.Drawing.Point(10, 364);
            this.num1Btn.Name = "num1Btn";
            this.num1Btn.Size = new System.Drawing.Size(80, 80);
            this.num1Btn.TabIndex = 3;
            this.num1Btn.Text = "1";
            this.num1Btn.UseVisualStyleBackColor = true;
            this.num1Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // num2Btn
            // 
            this.num2Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num2Btn.Font = new System.Drawing.Font("Open Sans Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2Btn.Location = new System.Drawing.Point(96, 364);
            this.num2Btn.Name = "num2Btn";
            this.num2Btn.Size = new System.Drawing.Size(80, 80);
            this.num2Btn.TabIndex = 4;
            this.num2Btn.Text = "2";
            this.num2Btn.UseVisualStyleBackColor = true;
            this.num2Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // num3Btn
            // 
            this.num3Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num3Btn.Font = new System.Drawing.Font("Open Sans Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3Btn.Location = new System.Drawing.Point(182, 364);
            this.num3Btn.Name = "num3Btn";
            this.num3Btn.Size = new System.Drawing.Size(80, 80);
            this.num3Btn.TabIndex = 5;
            this.num3Btn.Text = "3";
            this.num3Btn.UseVisualStyleBackColor = true;
            this.num3Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // num4Btn
            // 
            this.num4Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num4Btn.Font = new System.Drawing.Font("Open Sans Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4Btn.Location = new System.Drawing.Point(11, 278);
            this.num4Btn.Name = "num4Btn";
            this.num4Btn.Size = new System.Drawing.Size(80, 80);
            this.num4Btn.TabIndex = 6;
            this.num4Btn.Text = "4";
            this.num4Btn.UseVisualStyleBackColor = true;
            this.num4Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // num5Btn
            // 
            this.num5Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num5Btn.Font = new System.Drawing.Font("Open Sans Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5Btn.Location = new System.Drawing.Point(97, 278);
            this.num5Btn.Name = "num5Btn";
            this.num5Btn.Size = new System.Drawing.Size(80, 80);
            this.num5Btn.TabIndex = 7;
            this.num5Btn.Text = "5";
            this.num5Btn.UseVisualStyleBackColor = true;
            this.num5Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // num6Btn
            // 
            this.num6Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num6Btn.Font = new System.Drawing.Font("Open Sans Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6Btn.Location = new System.Drawing.Point(182, 278);
            this.num6Btn.Name = "num6Btn";
            this.num6Btn.Size = new System.Drawing.Size(80, 80);
            this.num6Btn.TabIndex = 8;
            this.num6Btn.Text = "6";
            this.num6Btn.UseVisualStyleBackColor = true;
            this.num6Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // num7Btn
            // 
            this.num7Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num7Btn.Font = new System.Drawing.Font("Open Sans Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7Btn.Location = new System.Drawing.Point(10, 192);
            this.num7Btn.Name = "num7Btn";
            this.num7Btn.Size = new System.Drawing.Size(80, 80);
            this.num7Btn.TabIndex = 9;
            this.num7Btn.Text = "7";
            this.num7Btn.UseVisualStyleBackColor = true;
            this.num7Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // num8Btn
            // 
            this.num8Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num8Btn.Font = new System.Drawing.Font("Open Sans Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8Btn.Location = new System.Drawing.Point(96, 192);
            this.num8Btn.Name = "num8Btn";
            this.num8Btn.Size = new System.Drawing.Size(80, 80);
            this.num8Btn.TabIndex = 10;
            this.num8Btn.Text = "8";
            this.num8Btn.UseVisualStyleBackColor = true;
            this.num8Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // num9Btn
            // 
            this.num9Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num9Btn.Font = new System.Drawing.Font("Open Sans Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9Btn.Location = new System.Drawing.Point(182, 192);
            this.num9Btn.Name = "num9Btn";
            this.num9Btn.Size = new System.Drawing.Size(80, 80);
            this.num9Btn.TabIndex = 11;
            this.num9Btn.Text = "9";
            this.num9Btn.UseVisualStyleBackColor = true;
            this.num9Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divideBtn.Font = new System.Drawing.Font("Open Sans Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideBtn.Location = new System.Drawing.Point(268, 192);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(60, 58);
            this.divideBtn.TabIndex = 12;
            this.divideBtn.Text = "÷";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.opBtn_Click);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.multiplyBtn.Font = new System.Drawing.Font("Open Sans Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyBtn.Location = new System.Drawing.Point(268, 254);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(60, 58);
            this.multiplyBtn.TabIndex = 13;
            this.multiplyBtn.Text = "×";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.opBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusBtn.Font = new System.Drawing.Font("Open Sans Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.Location = new System.Drawing.Point(268, 318);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(60, 58);
            this.minusBtn.TabIndex = 14;
            this.minusBtn.Text = "－";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.opBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusBtn.Font = new System.Drawing.Font("Open Sans Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.Location = new System.Drawing.Point(268, 382);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(60, 62);
            this.plusBtn.TabIndex = 15;
            this.plusBtn.Text = "＋";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.opBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn.BackColor = System.Drawing.SystemColors.Control;
            this.clearBtn.Font = new System.Drawing.Font("Open Sans Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(11, 139);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(317, 47);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // num0Btn
            // 
            this.num0Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num0Btn.Font = new System.Drawing.Font("Open Sans Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0Btn.Location = new System.Drawing.Point(11, 451);
            this.num0Btn.Name = "num0Btn";
            this.num0Btn.Size = new System.Drawing.Size(80, 80);
            this.num0Btn.TabIndex = 17;
            this.num0Btn.Text = "0";
            this.num0Btn.UseVisualStyleBackColor = true;
            this.num0Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // OpacityScrollBar
            // 
            this.OpacityScrollBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpacityScrollBar.Location = new System.Drawing.Point(9, 9);
            this.OpacityScrollBar.Minimum = 20;
            this.OpacityScrollBar.Name = "OpacityScrollBar";
            this.OpacityScrollBar.Size = new System.Drawing.Size(318, 17);
            this.OpacityScrollBar.TabIndex = 19;
            this.OpacityScrollBar.Value = 100;
            this.OpacityScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OpacityScrollBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 540);
            this.Controls.Add(this.OpacityScrollBar);
            this.Controls.Add(this.num0Btn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.num9Btn);
            this.Controls.Add(this.num8Btn);
            this.Controls.Add(this.num7Btn);
            this.Controls.Add(this.num6Btn);
            this.Controls.Add(this.num5Btn);
            this.Controls.Add(this.num4Btn);
            this.Controls.Add(this.num3Btn);
            this.Controls.Add(this.num2Btn);
            this.Controls.Add(this.num1Btn);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.equalBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0D;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Button num1Btn;
        private System.Windows.Forms.Button num2Btn;
        private System.Windows.Forms.Button num3Btn;
        private System.Windows.Forms.Button num4Btn;
        private System.Windows.Forms.Button num5Btn;
        private System.Windows.Forms.Button num6Btn;
        private System.Windows.Forms.Button num7Btn;
        private System.Windows.Forms.Button num8Btn;
        private System.Windows.Forms.Button num9Btn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button num0Btn;
        private System.Windows.Forms.HScrollBar OpacityScrollBar;
    }
}

