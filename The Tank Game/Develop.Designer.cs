
namespace Гонки
{
    partial class Develop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Develop));
            this.label3 = new System.Windows.Forms.Label();
            this.Ariazs = new System.Windows.Forms.Label();
            this.Obnov2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(510, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Текущая версия: v.0.0.3";
            // 
            // Ariazs
            // 
            this.Ariazs.AutoSize = true;
            this.Ariazs.BackColor = System.Drawing.Color.Transparent;
            this.Ariazs.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ariazs.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Ariazs.Location = new System.Drawing.Point(281, -6);
            this.Ariazs.Name = "Ariazs";
            this.Ariazs.Size = new System.Drawing.Size(486, 129);
            this.Ariazs.TabIndex = 5;
            this.Ariazs.Text = "Tank Game";
            // 
            // Obnov2
            // 
            this.Obnov2.AutoSize = true;
            this.Obnov2.Location = new System.Drawing.Point(12, 9);
            this.Obnov2.Name = "Obnov2";
            this.Obnov2.Size = new System.Drawing.Size(0, 16);
            this.Obnov2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 96);
            this.label1.TabIndex = 6;
            this.label1.Text = "В планах:\r\n   1. Добавить систему жизней ✓\r\n   2. Добавить звуковое сопровождение" +
    " ✓\r\n   3. Добавить возможность производить выстрел ✓\r\n   4. Добавить новые уровн" +
    "и\r\n   5. Добавить режим \"Игра на двоих\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 368);
            this.label2.TabIndex = 7;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Develop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ariazs);
            this.Controls.Add(this.Obnov2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Develop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О разработке";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Ariazs;
        private System.Windows.Forms.Label Obnov2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}