namespace INF_PAPP_Lampes_fazzien
{
    partial class int_lampes
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(int_lampes));
            this.btn_demarrer = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.txt_player1 = new System.Windows.Forms.TextBox();
            this.txt_player2 = new System.Windows.Forms.TextBox();
            this.lbl_player1 = new System.Windows.Forms.Label();
            this.lbl_player2 = new System.Windows.Forms.Label();
            this.lbl_sec = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.lbl_2pts_min = new System.Windows.Forms.Label();
            this.lbl_2pts_sec = new System.Windows.Forms.Label();
            this.lbl_msec = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_Grille = new System.Windows.Forms.Panel();
            this.Timer_Chrono = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réinitialiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_music = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_demarrer
            // 
            this.btn_demarrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_demarrer.ForeColor = System.Drawing.Color.Blue;
            this.btn_demarrer.Location = new System.Drawing.Point(22, 148);
            this.btn_demarrer.Name = "btn_demarrer";
            this.btn_demarrer.Size = new System.Drawing.Size(168, 67);
            this.btn_demarrer.TabIndex = 0;
            this.btn_demarrer.Text = "Démarrer";
            this.btn_demarrer.UseVisualStyleBackColor = true;
            this.btn_demarrer.Click += new System.EventHandler(this.btn_demarrer_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_valider.ForeColor = System.Drawing.Color.Blue;
            this.btn_valider.Location = new System.Drawing.Point(310, 148);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(168, 67);
            this.btn_valider.TabIndex = 1;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // txt_player1
            // 
            this.txt_player1.Location = new System.Drawing.Point(583, 148);
            this.txt_player1.MaxLength = 15;
            this.txt_player1.Name = "txt_player1";
            this.txt_player1.Size = new System.Drawing.Size(100, 20);
            this.txt_player1.TabIndex = 2;
            this.txt_player1.TextChanged += new System.EventHandler(this.txt_player1_TextChanged);
            // 
            // txt_player2
            // 
            this.txt_player2.Location = new System.Drawing.Point(583, 195);
            this.txt_player2.MaxLength = 15;
            this.txt_player2.Name = "txt_player2";
            this.txt_player2.Size = new System.Drawing.Size(100, 20);
            this.txt_player2.TabIndex = 3;
            this.txt_player2.TextChanged += new System.EventHandler(this.txt_player2_TextChanged);
            // 
            // lbl_player1
            // 
            this.lbl_player1.AutoSize = true;
            this.lbl_player1.ForeColor = System.Drawing.Color.Blue;
            this.lbl_player1.Location = new System.Drawing.Point(516, 151);
            this.lbl_player1.Name = "lbl_player1";
            this.lbl_player1.Size = new System.Drawing.Size(48, 13);
            this.lbl_player1.TabIndex = 4;
            this.lbl_player1.Text = "Joueur 1";
            // 
            // lbl_player2
            // 
            this.lbl_player2.AutoSize = true;
            this.lbl_player2.ForeColor = System.Drawing.Color.Blue;
            this.lbl_player2.Location = new System.Drawing.Point(516, 198);
            this.lbl_player2.Name = "lbl_player2";
            this.lbl_player2.Size = new System.Drawing.Size(48, 13);
            this.lbl_player2.TabIndex = 5;
            this.lbl_player2.Text = "Joueur 2";
            // 
            // lbl_sec
            // 
            this.lbl_sec.AutoSize = true;
            this.lbl_sec.ForeColor = System.Drawing.Color.Blue;
            this.lbl_sec.Location = new System.Drawing.Point(822, 184);
            this.lbl_sec.Name = "lbl_sec";
            this.lbl_sec.Size = new System.Drawing.Size(19, 13);
            this.lbl_sec.TabIndex = 6;
            this.lbl_sec.Text = "00";
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.ForeColor = System.Drawing.Color.Blue;
            this.lbl_min.Location = new System.Drawing.Point(781, 184);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(19, 13);
            this.lbl_min.TabIndex = 7;
            this.lbl_min.Text = "00";
            // 
            // lbl_2pts_min
            // 
            this.lbl_2pts_min.AutoSize = true;
            this.lbl_2pts_min.ForeColor = System.Drawing.Color.Blue;
            this.lbl_2pts_min.Location = new System.Drawing.Point(806, 184);
            this.lbl_2pts_min.Name = "lbl_2pts_min";
            this.lbl_2pts_min.Size = new System.Drawing.Size(10, 13);
            this.lbl_2pts_min.TabIndex = 8;
            this.lbl_2pts_min.Text = ":";
            // 
            // lbl_2pts_sec
            // 
            this.lbl_2pts_sec.AutoSize = true;
            this.lbl_2pts_sec.ForeColor = System.Drawing.Color.Blue;
            this.lbl_2pts_sec.Location = new System.Drawing.Point(847, 184);
            this.lbl_2pts_sec.Name = "lbl_2pts_sec";
            this.lbl_2pts_sec.Size = new System.Drawing.Size(10, 13);
            this.lbl_2pts_sec.TabIndex = 9;
            this.lbl_2pts_sec.Text = ":";
            // 
            // lbl_msec
            // 
            this.lbl_msec.AutoSize = true;
            this.lbl_msec.ForeColor = System.Drawing.Color.Blue;
            this.lbl_msec.Location = new System.Drawing.Point(864, 184);
            this.lbl_msec.Name = "lbl_msec";
            this.lbl_msec.Size = new System.Drawing.Size(19, 13);
            this.lbl_msec.TabIndex = 10;
            this.lbl_msec.Text = "00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(715, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_Grille
            // 
            this.pnl_Grille.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Grille.Location = new System.Drawing.Point(23, 39);
            this.pnl_Grille.Name = "pnl_Grille";
            this.pnl_Grille.Size = new System.Drawing.Size(850, 50);
            this.pnl_Grille.TabIndex = 12;
            // 
            // Timer_Chrono
            // 
            this.Timer_Chrono.Tick += new System.EventHandler(this.Timer_Chrono_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideToolStripMenuItem,
            this.musiqueToolStripMenuItem,
            this.réinitialiserToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.aideToolStripMenuItem.Text = "Aide";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // musiqueToolStripMenuItem
            // 
            this.musiqueToolStripMenuItem.Name = "musiqueToolStripMenuItem";
            this.musiqueToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.musiqueToolStripMenuItem.Text = "Musique";
            this.musiqueToolStripMenuItem.Click += new System.EventHandler(this.musiqueToolStripMenuItem_Click);
            // 
            // réinitialiserToolStripMenuItem
            // 
            this.réinitialiserToolStripMenuItem.Name = "réinitialiserToolStripMenuItem";
            this.réinitialiserToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.réinitialiserToolStripMenuItem.Text = "Réinitialiser";
            this.réinitialiserToolStripMenuItem.Click += new System.EventHandler(this.réinitialiserToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // btn_music
            // 
            this.btn_music.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_music.Location = new System.Drawing.Point(222, 160);
            this.btn_music.Name = "btn_music";
            this.btn_music.Size = new System.Drawing.Size(57, 42);
            this.btn_music.TabIndex = 14;
            this.btn_music.Text = "OFF";
            this.btn_music.UseVisualStyleBackColor = true;
            this.btn_music.Visible = false;
            this.btn_music.Click += new System.EventHandler(this.btn_music_Click);
            // 
            // int_lampes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(910, 266);
            this.Controls.Add(this.btn_music);
            this.Controls.Add(this.pnl_Grille);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_msec);
            this.Controls.Add(this.lbl_2pts_sec);
            this.Controls.Add(this.lbl_2pts_min);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.lbl_sec);
            this.Controls.Add(this.lbl_player2);
            this.Controls.Add(this.lbl_player1);
            this.Controls.Add(this.txt_player2);
            this.Controls.Add(this.txt_player1);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_demarrer);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "int_lampes";
            this.Text = "Jeu des lampes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.int_lampes_FormClosing);
            this.Load += new System.EventHandler(this.Tableau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_demarrer;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.TextBox txt_player1;
        private System.Windows.Forms.TextBox txt_player2;
        private System.Windows.Forms.Label lbl_player1;
        private System.Windows.Forms.Label lbl_player2;
        private System.Windows.Forms.Label lbl_sec;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.Label lbl_2pts_min;
        private System.Windows.Forms.Label lbl_2pts_sec;
        private System.Windows.Forms.Label lbl_msec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_Grille;
        private System.Windows.Forms.Timer Timer_Chrono;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réinitialiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musiqueToolStripMenuItem;
        private System.Windows.Forms.Button btn_music;
    }
}

