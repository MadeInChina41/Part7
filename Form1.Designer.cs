namespace Part7
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
            this.btnStats = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.grpPlayerChoice = new System.Windows.Forms.GroupBox();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radScissor = new System.Windows.Forms.RadioButton();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.lblCPU = new System.Windows.Forms.Label();
            this.picCPU = new System.Windows.Forms.PictureBox();
            this.lblTaunt = new System.Windows.Forms.Label();
            this.grpPlayerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(12, 166);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(75, 23);
            this.btnStats.TabIndex = 0;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // btnInstructions
            // 
            this.btnInstructions.Location = new System.Drawing.Point(12, 137);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(75, 23);
            this.btnInstructions.TabIndex = 1;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            // 
            // grpPlayerChoice
            // 
            this.grpPlayerChoice.Controls.Add(this.radScissor);
            this.grpPlayerChoice.Controls.Add(this.radPaper);
            this.grpPlayerChoice.Controls.Add(this.radRock);
            this.grpPlayerChoice.Location = new System.Drawing.Point(12, 44);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Size = new System.Drawing.Size(88, 87);
            this.grpPlayerChoice.TabIndex = 2;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "PlayerChoice";
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Location = new System.Drawing.Point(7, 19);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(51, 17);
            this.radRock.TabIndex = 0;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Location = new System.Drawing.Point(7, 42);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(53, 17);
            this.radPaper.TabIndex = 1;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            // 
            // radScissor
            // 
            this.radScissor.AutoSize = true;
            this.radScissor.Location = new System.Drawing.Point(7, 65);
            this.radScissor.Name = "radScissor";
            this.radScissor.Size = new System.Drawing.Size(59, 17);
            this.radScissor.TabIndex = 2;
            this.radScissor.TabStop = true;
            this.radScissor.Text = "Scissor";
            this.radScissor.UseVisualStyleBackColor = true;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 13);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(290, 13);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "You are playing rock paper scissors. Please select an option";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(175, 44);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer.TabIndex = 4;
            this.lblPlayer.Text = "Player";
            // 
            // picPlayer
            // 
            this.picPlayer.Location = new System.Drawing.Point(159, 60);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(67, 71);
            this.picPlayer.TabIndex = 5;
            this.picPlayer.TabStop = false;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(266, 44);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(29, 13);
            this.lblCPU.TabIndex = 6;
            this.lblCPU.Text = "CPU";
            // 
            // picCPU
            // 
            this.picCPU.Location = new System.Drawing.Point(249, 60);
            this.picCPU.Name = "picCPU";
            this.picCPU.Size = new System.Drawing.Size(67, 71);
            this.picCPU.TabIndex = 7;
            this.picCPU.TabStop = false;
            // 
            // lblTaunt
            // 
            this.lblTaunt.AutoSize = true;
            this.lblTaunt.Location = new System.Drawing.Point(246, 142);
            this.lblTaunt.Name = "lblTaunt";
            this.lblTaunt.Size = new System.Drawing.Size(35, 13);
            this.lblTaunt.TabIndex = 8;
            this.lblTaunt.Text = "Taunt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 199);
            this.Controls.Add(this.lblTaunt);
            this.Controls.Add(this.picCPU);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.grpPlayerChoice);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnStats);
            this.Name = "Form1";
            this.Text = "RPS";
            this.grpPlayerChoice.ResumeLayout(false);
            this.grpPlayerChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.GroupBox grpPlayerChoice;
        private System.Windows.Forms.RadioButton radScissor;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.PictureBox picCPU;
        private System.Windows.Forms.Label lblTaunt;
    }
}

