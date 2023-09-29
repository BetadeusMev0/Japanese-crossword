namespace CrossWord_JaPon
{
    partial class GameForm
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
            this.gameArea = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCheckWin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameArea)).BeginInit();
            this.SuspendLayout();
            // 
            // gameArea
            // 
            this.gameArea.Location = new System.Drawing.Point(12, 12);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(481, 521);
            this.gameArea.TabIndex = 0;
            this.gameArea.TabStop = false;
            this.gameArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gameArea_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Not Win";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(499, 12);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCheckWin
            // 
            this.buttonCheckWin.Location = new System.Drawing.Point(499, 41);
            this.buttonCheckWin.Name = "buttonCheckWin";
            this.buttonCheckWin.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckWin.TabIndex = 3;
            this.buttonCheckWin.Text = "Check Win";
            this.buttonCheckWin.UseVisualStyleBackColor = true;
            this.buttonCheckWin.Click += new System.EventHandler(this.buttonCheckWin_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 536);
            this.Controls.Add(this.buttonCheckWin);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameArea);
            this.MaximumSize = new System.Drawing.Size(600, 575);
            this.MinimumSize = new System.Drawing.Size(600, 575);
            this.Name = "GameForm";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.gameArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private PictureBox gameArea;
        private Label label1;
        private Button buttonClear;
        private Button buttonCheckWin;
    }
}