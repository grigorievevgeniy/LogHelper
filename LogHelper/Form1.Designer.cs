
namespace LogHelper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogValue = new System.Windows.Forms.Button();
            this.btnLogName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(12, 12);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(151, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Logger.Error(\"Enter\");";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 181);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Logger.Error(\"Exit\");";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogValue
            // 
            this.btnLogValue.Location = new System.Drawing.Point(12, 52);
            this.btnLogValue.Name = "btnLogValue";
            this.btnLogValue.Size = new System.Drawing.Size(151, 50);
            this.btnLogValue.TabIndex = 2;
            this.btnLogValue.Text = "Logger.Error($\"x - {x}\")";
            this.btnLogValue.UseVisualStyleBackColor = true;
            this.btnLogValue.Click += new System.EventHandler(this.btnLogValue_Click);
            // 
            // btnLogName
            // 
            this.btnLogName.Location = new System.Drawing.Point(12, 108);
            this.btnLogName.Name = "btnLogName";
            this.btnLogName.Size = new System.Drawing.Size(151, 50);
            this.btnLogName.TabIndex = 3;
            this.btnLogName.Text = "Logger.Error(\"x\")";
            this.btnLogName.UseVisualStyleBackColor = true;
            this.btnLogName.Click += new System.EventHandler(this.btnLogName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 212);
            this.Controls.Add(this.btnLogName);
            this.Controls.Add(this.btnLogValue);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Help";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogValue;
        private System.Windows.Forms.Button btnLogName;
    }
}

