namespace TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Grid = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ScorePlayerX = new System.Windows.Forms.Label();
            this.ScorePlayerO = new System.Windows.Forms.Label();
            this.PlayerTurn = new System.Windows.Forms.Label();
            this.ScoreBackground = new System.Windows.Forms.PictureBox();
            this.ButtonResetScore = new System.Windows.Forms.Button();
            this.Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.ColumnCount = 3;
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Grid.Controls.Add(this.label9, 2, 2);
            this.Grid.Controls.Add(this.label8, 1, 2);
            this.Grid.Controls.Add(this.label7, 0, 2);
            this.Grid.Controls.Add(this.label6, 2, 1);
            this.Grid.Controls.Add(this.label5, 1, 1);
            this.Grid.Controls.Add(this.label4, 0, 1);
            this.Grid.Controls.Add(this.label3, 2, 0);
            this.Grid.Controls.Add(this.label2, 1, 0);
            this.Grid.Controls.Add(this.label1, 0, 0);
            this.Grid.Location = new System.Drawing.Point(-9, 83);
            this.Grid.Name = "Grid";
            this.Grid.RowCount = 3;
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Grid.Size = new System.Drawing.Size(561, 499);
            this.Grid.TabIndex = 0;
            this.Grid.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.Grid_CellPaint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label9.Location = new System.Drawing.Point(376, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 167);
            this.label9.TabIndex = 8;
            this.label9.Text = "D";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.Player_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.Location = new System.Drawing.Point(189, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 167);
            this.label8.TabIndex = 7;
            this.label8.Text = "D";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.Player_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.Location = new System.Drawing.Point(3, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 167);
            this.label7.TabIndex = 6;
            this.label7.Text = "D";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.Player_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.Location = new System.Drawing.Point(376, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 166);
            this.label6.TabIndex = 5;
            this.label6.Text = "D";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.Player_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(189, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 166);
            this.label5.TabIndex = 4;
            this.label5.Text = "D";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.Player_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(3, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 166);
            this.label4.TabIndex = 3;
            this.label4.Text = "D";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.Player_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(376, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 166);
            this.label3.TabIndex = 2;
            this.label3.Text = "D";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.Player_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(189, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 166);
            this.label2.TabIndex = 1;
            this.label2.Text = "D";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.Player_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 166);
            this.label1.TabIndex = 0;
            this.label1.Text = "D";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Player_Click);
            // 
            // ScorePlayerX
            // 
            this.ScorePlayerX.AutoSize = true;
            this.ScorePlayerX.BackColor = System.Drawing.Color.Transparent;
            this.ScorePlayerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ScorePlayerX.Location = new System.Drawing.Point(276, 9);
            this.ScorePlayerX.Name = "ScorePlayerX";
            this.ScorePlayerX.Size = new System.Drawing.Size(254, 33);
            this.ScorePlayerX.TabIndex = 1;
            this.ScorePlayerX.Text = "Player X score: 0";
            // 
            // ScorePlayerO
            // 
            this.ScorePlayerO.AutoSize = true;
            this.ScorePlayerO.BackColor = System.Drawing.Color.Transparent;
            this.ScorePlayerO.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ScorePlayerO.Location = new System.Drawing.Point(-5, 9);
            this.ScorePlayerO.Name = "ScorePlayerO";
            this.ScorePlayerO.Size = new System.Drawing.Size(258, 33);
            this.ScorePlayerO.TabIndex = 2;
            this.ScorePlayerO.Text = "Player O score: 0";
            // 
            // PlayerTurn
            // 
            this.PlayerTurn.AutoSize = true;
            this.PlayerTurn.BackColor = System.Drawing.Color.Transparent;
            this.PlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PlayerTurn.Location = new System.Drawing.Point(204, 54);
            this.PlayerTurn.Name = "PlayerTurn";
            this.PlayerTurn.Size = new System.Drawing.Size(137, 29);
            this.PlayerTurn.TabIndex = 3;
            this.PlayerTurn.Text = "Player Turn";
            // 
            // ScoreBackground
            // 
            this.ScoreBackground.Location = new System.Drawing.Point(-9, -1);
            this.ScoreBackground.Name = "ScoreBackground";
            this.ScoreBackground.Size = new System.Drawing.Size(561, 90);
            this.ScoreBackground.TabIndex = 4;
            this.ScoreBackground.TabStop = false;
            // 
            // ButtonResetScore
            // 
            this.ButtonResetScore.Location = new System.Drawing.Point(464, 57);
            this.ButtonResetScore.Name = "ButtonResetScore";
            this.ButtonResetScore.Size = new System.Drawing.Size(75, 23);
            this.ButtonResetScore.TabIndex = 5;
            this.ButtonResetScore.Text = "Reset score";
            this.ButtonResetScore.UseVisualStyleBackColor = true;
            this.ButtonResetScore.Click += new System.EventHandler(this.ButtonResetScore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 579);
            this.Controls.Add(this.ButtonResetScore);
            this.Controls.Add(this.PlayerTurn);
            this.Controls.Add(this.ScorePlayerO);
            this.Controls.Add(this.ScorePlayerX);
            this.Controls.Add(this.ScoreBackground);
            this.Controls.Add(this.Grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Grid.ResumeLayout(false);
            this.Grid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Grid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ScorePlayerX;
        private System.Windows.Forms.Label ScorePlayerO;
        private System.Windows.Forms.Label PlayerTurn;
        private System.Windows.Forms.PictureBox ScoreBackground;
        private System.Windows.Forms.Button ButtonResetScore;
    }
}

