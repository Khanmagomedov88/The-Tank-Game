
namespace Гонки
{
    partial class StartWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
            this.Button_Start = new System.Windows.Forms.Button();
            this.Ariazs = new System.Windows.Forms.Label();
            this.Button_KnowledgeBase = new System.Windows.Forms.Button();
            this.Button_Develop = new System.Windows.Forms.Button();
            this.Button_Record = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Start
            // 
            this.Button_Start.AutoSize = true;
            this.Button_Start.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Button_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Start.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Start.ForeColor = System.Drawing.Color.White;
            this.Button_Start.Location = new System.Drawing.Point(12, 184);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(191, 33);
            this.Button_Start.TabIndex = 1;
            this.Button_Start.Text = "Запустить игру";
            this.Button_Start.UseVisualStyleBackColor = false;
            this.Button_Start.Click += new System.EventHandler(this.Button_StartGame_Click);
            // 
            // Ariazs
            // 
            this.Ariazs.AutoSize = true;
            this.Ariazs.BackColor = System.Drawing.Color.Transparent;
            this.Ariazs.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ariazs.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Ariazs.Location = new System.Drawing.Point(118, 9);
            this.Ariazs.Name = "Ariazs";
            this.Ariazs.Size = new System.Drawing.Size(486, 129);
            this.Ariazs.TabIndex = 2;
            this.Ariazs.Text = "Tank Game";
            // 
            // Button_KnowledgeBase
            // 
            this.Button_KnowledgeBase.BackColor = System.Drawing.SystemColors.Control;
            this.Button_KnowledgeBase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_KnowledgeBase.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_KnowledgeBase.Location = new System.Drawing.Point(12, 223);
            this.Button_KnowledgeBase.Name = "Button_KnowledgeBase";
            this.Button_KnowledgeBase.Size = new System.Drawing.Size(191, 33);
            this.Button_KnowledgeBase.TabIndex = 3;
            this.Button_KnowledgeBase.Text = "База знаний";
            this.Button_KnowledgeBase.UseVisualStyleBackColor = false;
            this.Button_KnowledgeBase.Click += new System.EventHandler(this.Button_KnowledgeBase_Click);
            // 
            // Button_Develop
            // 
            this.Button_Develop.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Develop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Develop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Develop.Location = new System.Drawing.Point(12, 301);
            this.Button_Develop.Name = "Button_Develop";
            this.Button_Develop.Size = new System.Drawing.Size(191, 33);
            this.Button_Develop.TabIndex = 4;
            this.Button_Develop.Text = "О разработке";
            this.Button_Develop.UseVisualStyleBackColor = false;
            this.Button_Develop.Click += new System.EventHandler(this.Button_Develop_Click);
            // 
            // Button_Record
            // 
            this.Button_Record.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Record.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Record.Location = new System.Drawing.Point(12, 262);
            this.Button_Record.Name = "Button_Record";
            this.Button_Record.Size = new System.Drawing.Size(191, 33);
            this.Button_Record.TabIndex = 5;
            this.Button_Record.Text = "Рекорды";
            this.Button_Record.UseVisualStyleBackColor = false;
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Exit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Exit.Location = new System.Drawing.Point(12, 340);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(191, 33);
            this.Button_Exit.TabIndex = 6;
            this.Button_Exit.Text = "Выйти из игры";
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-14, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(735, 512);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 492);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Record);
            this.Controls.Add(this.Button_Develop);
            this.Controls.Add(this.Button_KnowledgeBase);
            this.Controls.Add(this.Ariazs);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "StartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tank Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Label Ariazs;
        private System.Windows.Forms.Button Button_KnowledgeBase;
        private System.Windows.Forms.Button Button_Develop;
        private System.Windows.Forms.Button Button_Record;
        private System.Windows.Forms.Button Button_Exit;
    }
}