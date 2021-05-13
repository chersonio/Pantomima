
namespace Pantomima
{
    partial class PantomimaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantomimaForm));
            this.btnNext = new System.Windows.Forms.Button();
            this.lblMovie = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblMovieAppear = new System.Windows.Forms.Label();
            this.btnNextPlayer = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.lblSettings = new System.Windows.Forms.LinkLabel();
            this.btnPause = new System.Windows.Forms.Button();
            this.linkTutorial = new System.Windows.Forms.LinkLabel();
            this.imgPanel = new System.Windows.Forms.ImageList(this.components);
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnNext.FlatAppearance.BorderSize = 3;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Caladea", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(229)))));
            this.btnNext.Location = new System.Drawing.Point(228, 484);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(219, 31);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblMovie.Location = new System.Drawing.Point(21, 115);
            this.lblMovie.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(0, 19);
            this.lblMovie.TabIndex = 1;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnPrevious.FlatAppearance.BorderSize = 3;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Caladea", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(229)))));
            this.btnPrevious.Location = new System.Drawing.Point(8, 484);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(219, 31);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblMovieAppear
            // 
            this.lblMovieAppear.AutoSize = true;
            this.lblMovieAppear.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieAppear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(229)))));
            this.lblMovieAppear.Location = new System.Drawing.Point(22, 31);
            this.lblMovieAppear.Name = "lblMovieAppear";
            this.lblMovieAppear.Size = new System.Drawing.Size(364, 18);
            this.lblMovieAppear.TabIndex = 3;
            this.lblMovieAppear.Text = "Press buttons: Next/Previous. A random movie will appear!";
            // 
            // btnNextPlayer
            // 
            this.btnNextPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.btnNextPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPlayer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnNextPlayer.FlatAppearance.BorderSize = 3;
            this.btnNextPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.btnNextPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.btnNextPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPlayer.Font = new System.Drawing.Font("Caladea", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(229)))));
            this.btnNextPlayer.Location = new System.Drawing.Point(169, 567);
            this.btnNextPlayer.Name = "btnNextPlayer";
            this.btnNextPlayer.Size = new System.Drawing.Size(115, 31);
            this.btnNextPlayer.TabIndex = 4;
            this.btnNextPlayer.Text = "Next Player";
            this.btnNextPlayer.UseVisualStyleBackColor = false;
            this.btnNextPlayer.Click += new System.EventHandler(this.btnNextPlayer_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.btnChoose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnChoose.FlatAppearance.BorderSize = 3;
            this.btnChoose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.btnChoose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.Font = new System.Drawing.Font("Caladea", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(229)))));
            this.btnChoose.Location = new System.Drawing.Point(183, 530);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(90, 31);
            this.btnChoose.TabIndex = 5;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(191, 429);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(73, 40);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "60";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCoudntdown_Tick_1);
            // 
            // lblSettings
            // 
            this.lblSettings.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Caladea", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(229)))));
            this.lblSettings.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(229)))));
            this.lblSettings.Location = new System.Drawing.Point(14, 605);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(58, 15);
            this.lblSettings.TabIndex = 7;
            this.lblSettings.TabStop = true;
            this.lblSettings.Text = "Settings";
            this.lblSettings.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(229)))));
            this.lblSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSettings_LinkClicked);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnPause.FlatAppearance.BorderSize = 3;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Caladea", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(229)))));
            this.btnPause.Location = new System.Drawing.Point(183, 530);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(90, 31);
            this.btnPause.TabIndex = 8;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // linkTutorial
            // 
            this.linkTutorial.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.linkTutorial.AutoSize = true;
            this.linkTutorial.Font = new System.Drawing.Font("Caladea", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTutorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(229)))));
            this.linkTutorial.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(229)))));
            this.linkTutorial.Location = new System.Drawing.Point(384, 605);
            this.linkTutorial.Name = "linkTutorial";
            this.linkTutorial.Size = new System.Drawing.Size(59, 15);
            this.linkTutorial.TabIndex = 9;
            this.linkTutorial.TabStop = true;
            this.linkTutorial.Text = "Tutorial";
            this.linkTutorial.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(229)))));
            this.linkTutorial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTutorial_LinkClicked);
            // 
            // imgPanel
            // 
            this.imgPanel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgPanel.ImageStream")));
            this.imgPanel.TransparentColor = System.Drawing.Color.Transparent;
            this.imgPanel.Images.SetKeyName(0, "Add a heading.jpg");
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(25, 169);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(213, 215);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 10;
            this.picBox.TabStop = false;
            // 
            // PantomimaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(454, 630);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.linkTutorial);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnNextPlayer);
            this.Controls.Add(this.lblMovieAppear);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.btnNext);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(229)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PantomimaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantomima - Random movie titles - by St.Chersoniotakis";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblMovieAppear;
        private System.Windows.Forms.Button btnNextPlayer;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer tmrCountdown;
        private System.Windows.Forms.LinkLabel lblSettings;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.LinkLabel linkTutorial;
        private System.Windows.Forms.ImageList imgPanel;
        private System.Windows.Forms.PictureBox picBox;
    }
}

