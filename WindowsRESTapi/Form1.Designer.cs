﻿
namespace WindowsRESTapi
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
            this.listBox_Adatok = new System.Windows.Forms.ListBox();
            this.Azonosito = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.textBox_fizetes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Adatok
            // 
            this.listBox_Adatok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Adatok.FormattingEnabled = true;
            this.listBox_Adatok.Location = new System.Drawing.Point(0, 0);
            this.listBox_Adatok.Name = "listBox_Adatok";
            this.listBox_Adatok.Size = new System.Drawing.Size(328, 450);
            this.listBox_Adatok.TabIndex = 0;
            // 
            // Azonosito
            // 
            this.Azonosito.AutoSize = true;
            this.Azonosito.Location = new System.Drawing.Point(399, 33);
            this.Azonosito.Name = "Azonosito";
            this.Azonosito.Size = new System.Drawing.Size(56, 13);
            this.Azonosito.TabIndex = 1;
            this.Azonosito.Text = "Azonositó:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(498, 33);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 2;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(498, 77);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 4;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(399, 77);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(30, 13);
            this.Name.TabIndex = 3;
            this.Name.Text = "Név:";
            this.Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_fizetes
            // 
            this.textBox_fizetes.Location = new System.Drawing.Point(498, 118);
            this.textBox_fizetes.Name = "textBox_fizetes";
            this.textBox_fizetes.Size = new System.Drawing.Size(100, 20);
            this.textBox_fizetes.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fizetés:";
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(379, 186);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(361, 40);
            this.button_Create.TabIndex = 7;
            this.button_Create.Text = "Beszúrás";
            this.button_Create.UseVisualStyleBackColor = true;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(379, 245);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(361, 40);
            this.button_Update.TabIndex = 8;
            this.button_Update.Text = "Módosítás";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(379, 309);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(361, 40);
            this.button_Delete.TabIndex = 9;
            this.button_Delete.Text = "Törlés";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.textBox_fizetes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.Azonosito);
            this.Controls.Add(this.listBox_Adatok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Adatok;
        private System.Windows.Forms.Label Azonosito;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox textBox_fizetes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
    }
}

