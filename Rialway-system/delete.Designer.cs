﻿namespace Rialway_system
{
    partial class delete
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete));
            this.label1 = new System.Windows.Forms.Label();
            this.deletebott = new Bunifu.Framework.UI.BunifuImageButton();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.deletebott)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(397, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Delete Castomer By ID";
            // 
            // deletebott
            // 
            this.deletebott.BackColor = System.Drawing.Color.Transparent;
            this.deletebott.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebott.Image = ((System.Drawing.Image)(resources.GetObject("deletebott.Image")));
            this.deletebott.ImageActive = null;
            this.deletebott.Location = new System.Drawing.Point(311, 34);
            this.deletebott.Margin = new System.Windows.Forms.Padding(4);
            this.deletebott.Name = "deletebott";
            this.deletebott.Size = new System.Drawing.Size(79, 62);
            this.deletebott.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deletebott.TabIndex = 5;
            this.deletebott.TabStop = false;
            this.deletebott.Zoom = 10;
            this.deletebott.Click += new System.EventHandler(this.deletebott_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(401, 59);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(216, 22);
            this.textBox.TabIndex = 4;
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletebott);
            this.Controls.Add(this.textBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "delete";
            this.Size = new System.Drawing.Size(961, 428);
            ((System.ComponentModel.ISupportInitialize)(this.deletebott)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton deletebott;
        private System.Windows.Forms.TextBox textBox;
    }
}
