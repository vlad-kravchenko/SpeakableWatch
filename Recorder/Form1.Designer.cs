namespace Recorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNext = new System.Windows.Forms.Button();
            this.btnListen = new System.Windows.Forms.Button();
            this.lbRecord = new System.Windows.Forms.Label();
            this.lbText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(319, 9);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(151, 66);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Дальше";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnListen
            // 
            this.btnListen.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListen.Location = new System.Drawing.Point(319, 81);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(151, 66);
            this.btnListen.TabIndex = 1;
            this.btnListen.Text = "Прослушать";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // lbRecord
            // 
            this.lbRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRecord.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.Location = new System.Drawing.Point(12, 9);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(301, 138);
            this.lbRecord.TabIndex = 2;
            this.lbRecord.Text = "Наведите мышку для записи";
            this.lbRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbRecord.MouseEnter += new System.EventHandler(this.lbRecord_MouseEnter);
            this.lbRecord.MouseLeave += new System.EventHandler(this.lbRecord_MouseLeave);
            // 
            // lbText
            // 
            this.lbText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbText.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(12, 150);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(458, 61);
            this.lbText.TabIndex = 3;
            this.lbText.Text = "-";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 223);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.lbRecord);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.btnNext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Voice recorder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.Label lbText;
    }
}

