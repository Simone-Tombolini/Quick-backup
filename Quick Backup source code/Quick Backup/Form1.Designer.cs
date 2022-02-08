
namespace Quick_Backup
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBoxDefault = new System.Windows.Forms.CheckBox();
            this.buttonSearchDestiantion = new System.Windows.Forms.Button();
            this.buttonSearchSource = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.textBoxSouce = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(522, 58);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(71, 21);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Modify";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(522, 23);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 21);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Modify";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxDefault
            // 
            this.checkBoxDefault.AutoSize = true;
            this.checkBoxDefault.Location = new System.Drawing.Point(15, 101);
            this.checkBoxDefault.Name = "checkBoxDefault";
            this.checkBoxDefault.Size = new System.Drawing.Size(153, 21);
            this.checkBoxDefault.TabIndex = 4;
            this.checkBoxDefault.Text = "Use as default path\r\n";
            this.checkBoxDefault.UseVisualStyleBackColor = true;
            // 
            // buttonSearchDestiantion
            // 
            this.buttonSearchDestiantion.Location = new System.Drawing.Point(447, 55);
            this.buttonSearchDestiantion.Name = "buttonSearchDestiantion";
            this.buttonSearchDestiantion.Size = new System.Drawing.Size(69, 23);
            this.buttonSearchDestiantion.TabIndex = 2;
            this.buttonSearchDestiantion.Text = "Search";
            this.buttonSearchDestiantion.UseVisualStyleBackColor = true;
            this.buttonSearchDestiantion.Click += new System.EventHandler(this.buttonSearchDestiantion_Click);
            // 
            // buttonSearchSource
            // 
            this.buttonSearchSource.Location = new System.Drawing.Point(447, 21);
            this.buttonSearchSource.Name = "buttonSearchSource";
            this.buttonSearchSource.Size = new System.Drawing.Size(69, 23);
            this.buttonSearchSource.TabIndex = 1;
            this.buttonSearchSource.Text = "Search";
            this.buttonSearchSource.UseVisualStyleBackColor = true;
            this.buttonSearchSource.Click += new System.EventHandler(this.buttonSearchSource_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Destination Folder\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Source Folder\r\n";
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(152, 55);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(289, 22);
            this.textBoxDestination.TabIndex = 13;
            this.textBoxDestination.Text = "<Select folder>";
            // 
            // textBoxSouce
            // 
            this.textBoxSouce.Location = new System.Drawing.Point(152, 21);
            this.textBoxSouce.Name = "textBoxSouce";
            this.textBoxSouce.Size = new System.Drawing.Size(289, 22);
            this.textBoxSouce.TabIndex = 12;
            this.textBoxSouce.Text = "<Select folder>";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(447, 93);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(146, 35);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 141);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBoxDefault);
            this.Controls.Add(this.buttonSearchDestiantion);
            this.Controls.Add(this.buttonSearchSource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.textBoxSouce);
            this.Controls.Add(this.buttonRun);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBoxDefault;
        private System.Windows.Forms.Button buttonSearchDestiantion;
        private System.Windows.Forms.Button buttonSearchSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.TextBox textBoxSouce;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

