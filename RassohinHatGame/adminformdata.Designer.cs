namespace RassohinHatGame
{
    partial class adminFormData
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.timerSettingsGB = new System.Windows.Forms.GroupBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.setTimerSettingsBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.minutesCount = new System.Windows.Forms.Label();
            this.secTB = new System.Windows.Forms.TextBox();
            this.minTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.setTeamBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.teamNameInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addWordBTN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.wordInput = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.teamDGV = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.wordDGV = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.saveExitBTN = new System.Windows.Forms.Button();
            this.resetTeams = new System.Windows.Forms.Button();
            this.resetWord = new System.Windows.Forms.Button();
            this.timerSettingsGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamDGV)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordDGV)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerSettingsGB
            // 
            this.timerSettingsGB.Controls.Add(this.timerLabel);
            this.timerSettingsGB.Controls.Add(this.setTimerSettingsBTN);
            this.timerSettingsGB.Controls.Add(this.label1);
            this.timerSettingsGB.Controls.Add(this.minutesCount);
            this.timerSettingsGB.Controls.Add(this.secTB);
            this.timerSettingsGB.Controls.Add(this.minTB);
            this.timerSettingsGB.Location = new System.Drawing.Point(21, 17);
            this.timerSettingsGB.Name = "timerSettingsGB";
            this.timerSettingsGB.Size = new System.Drawing.Size(249, 146);
            this.timerSettingsGB.TabIndex = 0;
            this.timerSettingsGB.TabStop = false;
            this.timerSettingsGB.Text = "Настройки таймера";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Montserrat Black", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(6, 16);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(139, 52);
            this.timerLabel.TabIndex = 3;
            this.timerLabel.Text = "00:00";
            // 
            // setTimerSettingsBTN
            // 
            this.setTimerSettingsBTN.Location = new System.Drawing.Point(129, 99);
            this.setTimerSettingsBTN.Name = "setTimerSettingsBTN";
            this.setTimerSettingsBTN.Size = new System.Drawing.Size(103, 23);
            this.setTimerSettingsBTN.TabIndex = 2;
            this.setTimerSettingsBTN.Text = "Установить";
            this.setTimerSettingsBTN.UseVisualStyleBackColor = true;
            this.setTimerSettingsBTN.Click += new System.EventHandler(this.SetTimerSettingsBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Секунды";
            // 
            // minutesCount
            // 
            this.minutesCount.AutoSize = true;
            this.minutesCount.Location = new System.Drawing.Point(12, 83);
            this.minutesCount.Name = "minutesCount";
            this.minutesCount.Size = new System.Drawing.Size(46, 13);
            this.minutesCount.TabIndex = 1;
            this.minutesCount.Text = "Минуты";
            // 
            // secTB
            // 
            this.secTB.Location = new System.Drawing.Point(72, 99);
            this.secTB.Multiline = true;
            this.secTB.Name = "secTB";
            this.secTB.Size = new System.Drawing.Size(51, 23);
            this.secTB.TabIndex = 0;
            this.secTB.Text = "00";
            // 
            // minTB
            // 
            this.minTB.Location = new System.Drawing.Point(15, 99);
            this.minTB.Multiline = true;
            this.minTB.Name = "minTB";
            this.minTB.Size = new System.Drawing.Size(51, 23);
            this.minTB.TabIndex = 0;
            this.minTB.Text = "00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.resetTeams);
            this.groupBox1.Controls.Add(this.setTeamBTN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.teamNameInput);
            this.groupBox1.Location = new System.Drawing.Point(299, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки команд";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.MaximumSize = new System.Drawing.Size(200, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Поочередно добавьте названия команд, которые будут принимать участие в игре";
            // 
            // setTeamBTN
            // 
            this.setTeamBTN.Location = new System.Drawing.Point(15, 128);
            this.setTeamBTN.Name = "setTeamBTN";
            this.setTeamBTN.Size = new System.Drawing.Size(151, 23);
            this.setTeamBTN.TabIndex = 2;
            this.setTeamBTN.Text = "Установить";
            this.setTeamBTN.UseVisualStyleBackColor = true;
            this.setTeamBTN.Click += new System.EventHandler(this.SetTeamBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Название команды";
            // 
            // teamNameInput
            // 
            this.teamNameInput.Location = new System.Drawing.Point(15, 99);
            this.teamNameInput.Multiline = true;
            this.teamNameInput.Name = "teamNameInput";
            this.teamNameInput.Size = new System.Drawing.Size(151, 23);
            this.teamNameInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.resetWord);
            this.groupBox2.Controls.Add(this.addWordBTN);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.wordInput);
            this.groupBox2.Location = new System.Drawing.Point(563, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 207);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление слов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.MaximumSize = new System.Drawing.Size(230, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Добавьте слова. Это должны быть нарицательные именая существительные в единственн" +
    "ом числе";
            // 
            // addWordBTN
            // 
            this.addWordBTN.Location = new System.Drawing.Point(15, 128);
            this.addWordBTN.Name = "addWordBTN";
            this.addWordBTN.Size = new System.Drawing.Size(151, 23);
            this.addWordBTN.TabIndex = 2;
            this.addWordBTN.Text = "Добавить";
            this.addWordBTN.UseVisualStyleBackColor = true;
            this.addWordBTN.Click += new System.EventHandler(this.AddWordBTN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Введите слово";
            // 
            // wordInput
            // 
            this.wordInput.Location = new System.Drawing.Point(15, 99);
            this.wordInput.Multiline = true;
            this.wordInput.Name = "wordInput";
            this.wordInput.Size = new System.Drawing.Size(151, 23);
            this.wordInput.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.teamDGV);
            this.groupBox3.Location = new System.Drawing.Point(21, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 193);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Список команд";
            // 
            // teamDGV
            // 
            this.teamDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teamDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamDGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.teamDGV.Location = new System.Drawing.Point(14, 24);
            this.teamDGV.Name = "teamDGV";
            this.teamDGV.Size = new System.Drawing.Size(203, 153);
            this.teamDGV.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.wordDGV);
            this.groupBox4.Location = new System.Drawing.Point(299, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 193);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Список слов";
            // 
            // wordDGV
            // 
            this.wordDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wordDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordDGV.Location = new System.Drawing.Point(15, 24);
            this.wordDGV.Name = "wordDGV";
            this.wordDGV.Size = new System.Drawing.Size(203, 153);
            this.wordDGV.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.saveExitBTN);
            this.groupBox5.Location = new System.Drawing.Point(563, 354);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(249, 69);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Выход";
            // 
            // saveExitBTN
            // 
            this.saveExitBTN.BackColor = System.Drawing.Color.SeaGreen;
            this.saveExitBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveExitBTN.Location = new System.Drawing.Point(6, 19);
            this.saveExitBTN.Name = "saveExitBTN";
            this.saveExitBTN.Size = new System.Drawing.Size(231, 36);
            this.saveExitBTN.TabIndex = 2;
            this.saveExitBTN.Text = "Сохранить и выйти";
            this.saveExitBTN.UseVisualStyleBackColor = false;
            this.saveExitBTN.Click += new System.EventHandler(this.SaveExitBTN_Click);
            // 
            // resetTeams
            // 
            this.resetTeams.BackColor = System.Drawing.Color.Firebrick;
            this.resetTeams.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetTeams.Location = new System.Drawing.Point(15, 166);
            this.resetTeams.Name = "resetTeams";
            this.resetTeams.Size = new System.Drawing.Size(151, 23);
            this.resetTeams.TabIndex = 2;
            this.resetTeams.Text = "Удалить все команды";
            this.resetTeams.UseVisualStyleBackColor = false;
            this.resetTeams.Click += new System.EventHandler(this.resetTeam_Click);
            // 
            // resetWord
            // 
            this.resetWord.BackColor = System.Drawing.Color.Firebrick;
            this.resetWord.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetWord.Location = new System.Drawing.Point(15, 166);
            this.resetWord.Name = "resetWord";
            this.resetWord.Size = new System.Drawing.Size(151, 23);
            this.resetWord.TabIndex = 2;
            this.resetWord.Text = "Удалить все слова";
            this.resetWord.UseVisualStyleBackColor = false;
            this.resetWord.Click += new System.EventHandler(this.resetWord_Click);
            // 
            // adminFormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.timerSettingsGB);
            this.Name = "adminFormData";
            this.Text = "Панель администратора";
            this.timerSettingsGB.ResumeLayout(false);
            this.timerSettingsGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teamDGV)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordDGV)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox timerSettingsGB;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button setTimerSettingsBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minutesCount;
        private System.Windows.Forms.TextBox secTB;
        private System.Windows.Forms.TextBox minTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button setTeamBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox teamNameInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addWordBTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox wordInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView teamDGV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView wordDGV;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button saveExitBTN;
        private System.Windows.Forms.Button resetTeams;
        private System.Windows.Forms.Button resetWord;
    }
}

