namespace checkboxApp
{
    partial class naslov
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
            this.dorucakCB = new System.Windows.Forms.CheckBox();
            this.rucakCB = new System.Windows.Forms.CheckBox();
            this.veceraCB = new System.Windows.Forms.CheckBox();
            this.odabranoTB = new System.Windows.Forms.RichTextBox();
            this.posaljiBtn = new System.Windows.Forms.Button();
            this.sakrijCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dorucakCB
            // 
            this.dorucakCB.AutoSize = true;
            this.dorucakCB.Location = new System.Drawing.Point(25, 39);
            this.dorucakCB.Name = "dorucakCB";
            this.dorucakCB.Size = new System.Drawing.Size(67, 17);
            this.dorucakCB.TabIndex = 0;
            this.dorucakCB.Text = "Doručak";
            this.dorucakCB.UseVisualStyleBackColor = true;
            this.dorucakCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rucakCB
            // 
            this.rucakCB.AutoSize = true;
            this.rucakCB.Location = new System.Drawing.Point(25, 77);
            this.rucakCB.Name = "rucakCB";
            this.rucakCB.Size = new System.Drawing.Size(58, 17);
            this.rucakCB.TabIndex = 1;
            this.rucakCB.Text = "Ručak";
            this.rucakCB.UseVisualStyleBackColor = true;
            // 
            // veceraCB
            // 
            this.veceraCB.AutoSize = true;
            this.veceraCB.Location = new System.Drawing.Point(25, 110);
            this.veceraCB.Name = "veceraCB";
            this.veceraCB.Size = new System.Drawing.Size(60, 17);
            this.veceraCB.TabIndex = 2;
            this.veceraCB.Text = "Večera";
            this.veceraCB.UseVisualStyleBackColor = true;
            // 
            // odabranoTB
            // 
            this.odabranoTB.Location = new System.Drawing.Point(141, 39);
            this.odabranoTB.Name = "odabranoTB";
            this.odabranoTB.Size = new System.Drawing.Size(181, 90);
            this.odabranoTB.TabIndex = 3;
            this.odabranoTB.Text = "Odabrali ste";
            // 
            // posaljiBtn
            // 
            this.posaljiBtn.Location = new System.Drawing.Point(25, 159);
            this.posaljiBtn.Name = "posaljiBtn";
            this.posaljiBtn.Size = new System.Drawing.Size(75, 23);
            this.posaljiBtn.TabIndex = 4;
            this.posaljiBtn.Text = "Pošalji";
            this.posaljiBtn.UseVisualStyleBackColor = true;
            // 
            // sakrijCB
            // 
            this.sakrijCB.AutoSize = true;
            this.sakrijCB.Location = new System.Drawing.Point(141, 159);
            this.sakrijCB.Name = "sakrijCB";
            this.sakrijCB.Size = new System.Drawing.Size(101, 17);
            this.sakrijCB.TabIndex = 5;
            this.sakrijCB.Text = "Sakrij Narudžbu";
            this.sakrijCB.UseVisualStyleBackColor = true;
            this.sakrijCB.CheckedChanged += new System.EventHandler(this.sakrijCB_CheckedChanged);
            // 
            // naslov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 212);
            this.Controls.Add(this.sakrijCB);
            this.Controls.Add(this.posaljiBtn);
            this.Controls.Add(this.odabranoTB);
            this.Controls.Add(this.veceraCB);
            this.Controls.Add(this.rucakCB);
            this.Controls.Add(this.dorucakCB);
            this.Name = "naslov";
            this.Text = "Upotreba CheckBox Kontrole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox dorucakCB;
        private System.Windows.Forms.CheckBox rucakCB;
        private System.Windows.Forms.CheckBox veceraCB;
        private System.Windows.Forms.RichTextBox odabranoTB;
        private System.Windows.Forms.Button posaljiBtn;
        private System.Windows.Forms.CheckBox sakrijCB;
    }
}

