namespace The_Tank_Game
{
    partial class PlayGame
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button_Replay = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label_start = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button_Replay
            // 
            this.button_Replay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Replay.Location = new System.Drawing.Point(394, 268);
            this.button_Replay.Name = "button_Replay";
            this.button_Replay.Size = new System.Drawing.Size(146, 44);
            this.button_Replay.TabIndex = 1;
            this.button_Replay.Text = "Начать заново";
            this.button_Replay.UseVisualStyleBackColor = true;
            this.button_Replay.Visible = false;
            this.button_Replay.Click += new System.EventHandler(this.button_Replay_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.Location = new System.Drawing.Point(694, 268);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(129, 44);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "Закрыть";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Visible = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Font = new System.Drawing.Font("Rosewood Std Regular", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_start.Location = new System.Drawing.Point(587, 282);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(0, 70);
            this.label_start.TabIndex = 3;
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1237, 673);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Replay);
            this.Controls.Add(this.label1);
            this.Name = "PlayGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tank Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Replay;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label_start;
    }
}