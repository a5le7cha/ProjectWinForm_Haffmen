
namespace WindowsFormsApp1
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
            this.DictBtn = new System.Windows.Forms.Button();
            this.CodeBtn = new System.Windows.Forms.Button();
            this.EncodeBtn = new System.Windows.Forms.Button();
            this.DecodeBtn = new System.Windows.Forms.Button();
            this.ChoseBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DictBtn
            // 
            this.DictBtn.BackColor = System.Drawing.Color.White;
            this.DictBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DictBtn.FlatAppearance.BorderSize = 10;
            this.DictBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DictBtn.Location = new System.Drawing.Point(25, 24);
            this.DictBtn.Name = "DictBtn";
            this.DictBtn.Size = new System.Drawing.Size(366, 90);
            this.DictBtn.TabIndex = 1;
            this.DictBtn.Text = "Make a dictionary";
            this.DictBtn.UseVisualStyleBackColor = false;
            this.DictBtn.Click += new System.EventHandler(this.DictBtn_Click);
            // 
            // CodeBtn
            // 
            this.CodeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeBtn.Location = new System.Drawing.Point(25, 133);
            this.CodeBtn.Name = "CodeBtn";
            this.CodeBtn.Size = new System.Drawing.Size(366, 90);
            this.CodeBtn.TabIndex = 2;
            this.CodeBtn.Text = "Make a code";
            this.CodeBtn.UseVisualStyleBackColor = true;
            this.CodeBtn.Click += new System.EventHandler(this.CodeBtn_Click);
            // 
            // EncodeBtn
            // 
            this.EncodeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncodeBtn.Location = new System.Drawing.Point(25, 244);
            this.EncodeBtn.Name = "EncodeBtn";
            this.EncodeBtn.Size = new System.Drawing.Size(170, 90);
            this.EncodeBtn.TabIndex = 3;
            this.EncodeBtn.Text = "Encode";
            this.EncodeBtn.UseVisualStyleBackColor = true;
            this.EncodeBtn.Click += new System.EventHandler(this.EncodeBtn_Click);
            // 
            // DecodeBtn
            // 
            this.DecodeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecodeBtn.Location = new System.Drawing.Point(221, 244);
            this.DecodeBtn.Name = "DecodeBtn";
            this.DecodeBtn.Size = new System.Drawing.Size(170, 90);
            this.DecodeBtn.TabIndex = 4;
            this.DecodeBtn.Text = "Decode";
            this.DecodeBtn.UseVisualStyleBackColor = true;
            this.DecodeBtn.Click += new System.EventHandler(this.DecodeBtn_Click);
            // 
            // ChoseBtn
            // 
            this.ChoseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoseBtn.Location = new System.Drawing.Point(25, 363);
            this.ChoseBtn.Name = "ChoseBtn";
            this.ChoseBtn.Size = new System.Drawing.Size(366, 90);
            this.ChoseBtn.TabIndex = 5;
            this.ChoseBtn.Text = "Choose the file";
            this.ChoseBtn.UseVisualStyleBackColor = true;
            this.ChoseBtn.Click += new System.EventHandler(this.ChoseBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(424, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(591, 520);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1041, 544);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ChoseBtn);
            this.Controls.Add(this.DecodeBtn);
            this.Controls.Add(this.EncodeBtn);
            this.Controls.Add(this.CodeBtn);
            this.Controls.Add(this.DictBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DictBtn;
        private System.Windows.Forms.Button CodeBtn;
        private System.Windows.Forms.Button EncodeBtn;
        private System.Windows.Forms.Button DecodeBtn;
        private System.Windows.Forms.Button ChoseBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

