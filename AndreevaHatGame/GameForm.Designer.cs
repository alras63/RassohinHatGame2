namespace AndreevaHatGame
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.h1 = new System.Windows.Forms.Label();
            this.timerGB = new System.Windows.Forms.GroupBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teamName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.currentScore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tryWordInput = new System.Windows.Forms.TextBox();
            this.tryButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.wordToGameGB = new System.Windows.Forms.GroupBox();
            this.gameoverGB = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.winTeam = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.hideWord_Click = new System.Windows.Forms.Button();
            this.wordToPlayer = new System.Windows.Forms.Label();
            this.MainTImer = new System.Windows.Forms.Timer(this.components);
            this.teamsDGV = new System.Windows.Forms.DataGridView();
            this.gameGB = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.timerGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.wordToGameGB.SuspendLayout();
            this.gameoverGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDGV)).BeginInit();
            this.gameGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AndreevaHatGame.Properties.Resources.abstractbg1;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 67);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // h1
            // 
            this.h1.AutoSize = true;
            this.h1.BackColor = System.Drawing.Color.Transparent;
            this.h1.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.h1.ForeColor = System.Drawing.Color.Black;
            this.h1.Location = new System.Drawing.Point(12, 25);
            this.h1.Name = "h1";
            this.h1.Padding = new System.Windows.Forms.Padding(2);
            this.h1.Size = new System.Drawing.Size(140, 30);
            this.h1.TabIndex = 1;
            this.h1.Text = "Игра Шляпа";
            // 
            // timerGB
            // 
            this.timerGB.Controls.Add(this.timerLabel);
            this.timerGB.Location = new System.Drawing.Point(17, 82);
            this.timerGB.Name = "timerGB";
            this.timerGB.Size = new System.Drawing.Size(168, 80);
            this.timerGB.TabIndex = 2;
            this.timerGB.TabStop = false;
            this.timerGB.Text = "Таймер";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Montserrat Black", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(6, 16);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(139, 52);
            this.timerLabel.TabIndex = 4;
            this.timerLabel.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(643, 36);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "by Andreeva Elizaveta";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(643, 9);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Специально для СГК";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сможете угадать слово?!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 32);
            this.label4.MaximumSize = new System.Drawing.Size(500, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(496, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Внимательно смотрите на объясняющего игрока и всеми способами пытайтесь понять, к" +
    "акое слово он объясняет. А свои догадки пишите ниже!";
            // 
            // teamName
            // 
            this.teamName.AutoSize = true;
            this.teamName.Font = new System.Drawing.Font("Montserrat Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamName.Location = new System.Drawing.Point(22, 198);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(163, 37);
            this.teamName.TabIndex = 4;
            this.teamName.Text = "Название";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Команда";
            // 
            // currentScore
            // 
            this.currentScore.AutoSize = true;
            this.currentScore.Font = new System.Drawing.Font("Montserrat Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentScore.Location = new System.Drawing.Point(22, 267);
            this.currentScore.Name = "currentScore";
            this.currentScore.Size = new System.Drawing.Size(36, 37);
            this.currentScore.TabIndex = 4;
            this.currentScore.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(25, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Набрано очков";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(7, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "#вЭтотРазТочноУгадаю";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 138);
            this.label10.MaximumSize = new System.Drawing.Size(500, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Я думаю, что это слово:";
            // 
            // tryWordInput
            // 
            this.tryWordInput.Location = new System.Drawing.Point(11, 164);
            this.tryWordInput.Multiline = true;
            this.tryWordInput.Name = "tryWordInput";
            this.tryWordInput.Size = new System.Drawing.Size(183, 33);
            this.tryWordInput.TabIndex = 5;
            // 
            // tryButton
            // 
            this.tryButton.Location = new System.Drawing.Point(11, 207);
            this.tryButton.Name = "tryButton";
            this.tryButton.Size = new System.Drawing.Size(182, 35);
            this.tryButton.TabIndex = 6;
            this.tryButton.Text = "Испытать удачу";
            this.tryButton.UseVisualStyleBackColor = true;
            this.tryButton.Click += new System.EventHandler(this.TryButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(239, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 158);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Правила игры";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 32);
            this.label11.MaximumSize = new System.Drawing.Size(250, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(249, 104);
            this.label11.TabIndex = 0;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // wordToGameGB
            // 
            this.wordToGameGB.BackColor = System.Drawing.SystemColors.Control;
            this.wordToGameGB.Controls.Add(this.hideWord_Click);
            this.wordToGameGB.Controls.Add(this.label5);
            this.wordToGameGB.Controls.Add(this.wordToPlayer);
            this.wordToGameGB.Location = new System.Drawing.Point(196, 72);
            this.wordToGameGB.Name = "wordToGameGB";
            this.wordToGameGB.Size = new System.Drawing.Size(574, 279);
            this.wordToGameGB.TabIndex = 5;
            this.wordToGameGB.TabStop = false;
            this.wordToGameGB.Text = "Информация для объясняющего игрока";
            // 
            // gameoverGB
            // 
            this.gameoverGB.BackColor = System.Drawing.SystemColors.Control;
            this.gameoverGB.Controls.Add(this.teamsDGV);
            this.gameoverGB.Controls.Add(this.button3);
            this.gameoverGB.Controls.Add(this.label13);
            this.gameoverGB.Controls.Add(this.winTeam);
            this.gameoverGB.Controls.Add(this.label14);
            this.gameoverGB.Location = new System.Drawing.Point(193, 70);
            this.gameoverGB.Name = "gameoverGB";
            this.gameoverGB.Size = new System.Drawing.Size(547, 279);
            this.gameoverGB.TabIndex = 5;
            this.gameoverGB.TabStop = false;
            this.gameoverGB.Text = "Конец игры!";
            this.gameoverGB.Enter += new System.EventHandler(this.GameoverGB_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ура! Закрываем игровое окно";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(400, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Это окно видите только Вы, ниже написано слово, которое нужно объяснить";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Вот сводная таблица команд:";
            // 
            // winTeam
            // 
            this.winTeam.AutoSize = true;
            this.winTeam.Font = new System.Drawing.Font("Montserrat Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winTeam.Location = new System.Drawing.Point(14, 179);
            this.winTeam.Name = "winTeam";
            this.winTeam.Size = new System.Drawing.Size(163, 37);
            this.winTeam.TabIndex = 4;
            this.winTeam.Text = "Название";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat SemiBold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(10, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Победила команда";
            // 
            // hideWord_Click
            // 
            this.hideWord_Click.Location = new System.Drawing.Point(14, 117);
            this.hideWord_Click.Name = "hideWord_Click";
            this.hideWord_Click.Size = new System.Drawing.Size(215, 39);
            this.hideWord_Click.TabIndex = 5;
            this.hideWord_Click.Text = "Понял, запускаем таймер!";
            this.hideWord_Click.UseVisualStyleBackColor = true;
            this.hideWord_Click.Click += new System.EventHandler(this.HideWord_Click_Click);
            // 
            // wordToPlayer
            // 
            this.wordToPlayer.AutoSize = true;
            this.wordToPlayer.Font = new System.Drawing.Font("Montserrat Black", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordToPlayer.Location = new System.Drawing.Point(5, 48);
            this.wordToPlayer.Name = "wordToPlayer";
            this.wordToPlayer.Size = new System.Drawing.Size(151, 52);
            this.wordToPlayer.TabIndex = 4;
            this.wordToPlayer.Text = "Слово";
            // 
            // MainTImer
            // 
            this.MainTImer.Interval = 1000;
            this.MainTImer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // teamsDGV
            // 
            this.teamsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamsDGV.Location = new System.Drawing.Point(14, 41);
            this.teamsDGV.Name = "teamsDGV";
            this.teamsDGV.Size = new System.Drawing.Size(482, 109);
            this.teamsDGV.TabIndex = 6;
            // 
            // gameGB
            // 
            this.gameGB.Controls.Add(this.tryButton);
            this.gameGB.Controls.Add(this.tryWordInput);
            this.gameGB.Controls.Add(this.label10);
            this.gameGB.Controls.Add(this.label9);
            this.gameGB.Controls.Add(this.groupBox2);
            this.gameGB.Controls.Add(this.groupBox1);
            this.gameGB.Location = new System.Drawing.Point(196, 70);
            this.gameGB.Name = "gameGB";
            this.gameGB.Size = new System.Drawing.Size(550, 287);
            this.gameGB.TabIndex = 7;
            this.gameGB.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 400);
            this.Controls.Add(this.gameoverGB);
            this.Controls.Add(this.wordToGameGB);
            this.Controls.Add(this.gameGB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.currentScore);
            this.Controls.Add(this.teamName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.h1);
            this.Controls.Add(this.timerGB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GameForm";
            this.Text = "GameForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.timerGB.ResumeLayout(false);
            this.timerGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.wordToGameGB.ResumeLayout(false);
            this.wordToGameGB.PerformLayout();
            this.gameoverGB.ResumeLayout(false);
            this.gameoverGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDGV)).EndInit();
            this.gameGB.ResumeLayout(false);
            this.gameGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label h1;
        private System.Windows.Forms.GroupBox timerGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label teamName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label currentScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tryWordInput;
        private System.Windows.Forms.Button tryButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox wordToGameGB;
        private System.Windows.Forms.Button hideWord_Click;
        private System.Windows.Forms.Label wordToPlayer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gameoverGB;

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label winTeam;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer MainTImer;
        private System.Windows.Forms.DataGridView teamsDGV;
        private System.Windows.Forms.GroupBox gameGB;
    }
}