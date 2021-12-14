﻿
namespace Goksysteem
{
    partial class StakeForm
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
            this.lbStake = new System.Windows.Forms.Label();
            this.lbLogout = new System.Windows.Forms.Label();
            this.lbSummary = new System.Windows.Forms.Label();
            this.lbLogo = new System.Windows.Forms.Label();
            this.lbGames = new System.Windows.Forms.Label();
            this.lbGamble = new System.Windows.Forms.Label();
            this.lbTokenBalance = new System.Windows.Forms.Label();
            this.lbTokens = new System.Windows.Forms.Label();
            this.lbStakes = new System.Windows.Forms.Label();
            this.txbStakeAmount = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.listboxGames = new System.Windows.Forms.ListBox();
            this.lbSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbStake
            // 
            this.lbStake.AutoSize = true;
            this.lbStake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbStake.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStake.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbStake.Location = new System.Drawing.Point(588, 31);
            this.lbStake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStake.Name = "lbStake";
            this.lbStake.Size = new System.Drawing.Size(132, 38);
            this.lbStake.TabIndex = 15;
            this.lbStake.Text = "Inzetten";
            this.lbStake.Click += new System.EventHandler(this.lbStake_Click);
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.Location = new System.Drawing.Point(793, 31);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(154, 38);
            this.lbLogout.TabIndex = 14;
            this.lbLogout.Text = "Uitloggen";
            this.lbLogout.Click += new System.EventHandler(this.lbLogout_Click);
            // 
            // lbSummary
            // 
            this.lbSummary.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lbSummary.AutoSize = true;
            this.lbSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSummary.Location = new System.Drawing.Point(252, 31);
            this.lbSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSummary.Name = "lbSummary";
            this.lbSummary.Size = new System.Drawing.Size(217, 38);
            this.lbSummary.TabIndex = 13;
            this.lbSummary.Text = "Mijn overzicht";
            this.lbSummary.Click += new System.EventHandler(this.lbSummary_Click);
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbLogo.Location = new System.Drawing.Point(16, 11);
            this.lbLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(78, 58);
            this.lbLogo.TabIndex = 12;
            this.lbLogo.Text = "4s";
            this.lbLogo.Click += new System.EventHandler(this.lbLogo_Click);
            // 
            // lbGames
            // 
            this.lbGames.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lbGames.AutoSize = true;
            this.lbGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbGames.Location = new System.Drawing.Point(96, 130);
            this.lbGames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGames.Name = "lbGames";
            this.lbGames.Size = new System.Drawing.Size(290, 58);
            this.lbGames.TabIndex = 16;
            this.lbGames.Text = "Wedstrijden";
            // 
            // lbGamble
            // 
            this.lbGamble.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lbGamble.AutoSize = true;
            this.lbGamble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbGamble.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbGamble.Location = new System.Drawing.Point(627, 130);
            this.lbGamble.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGamble.Name = "lbGamble";
            this.lbGamble.Size = new System.Drawing.Size(198, 58);
            this.lbGamble.TabIndex = 17;
            this.lbGamble.Text = "Gokken";
            // 
            // lbTokenBalance
            // 
            this.lbTokenBalance.AutoSize = true;
            this.lbTokenBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTokenBalance.Location = new System.Drawing.Point(647, 229);
            this.lbTokenBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTokenBalance.Name = "lbTokenBalance";
            this.lbTokenBalance.Size = new System.Drawing.Size(137, 20);
            this.lbTokenBalance.TabIndex = 19;
            this.lbTokenBalance.Text = "Uw token balans:";
            // 
            // lbTokens
            // 
            this.lbTokens.AutoSize = true;
            this.lbTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTokens.Location = new System.Drawing.Point(855, 229);
            this.lbTokens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTokens.Name = "lbTokens";
            this.lbTokens.Size = new System.Drawing.Size(27, 20);
            this.lbTokens.TabIndex = 20;
            this.lbTokens.Text = "50";
            // 
            // lbStakes
            // 
            this.lbStakes.AutoSize = true;
            this.lbStakes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbStakes.Location = new System.Drawing.Point(573, 352);
            this.lbStakes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStakes.Name = "lbStakes";
            this.lbStakes.Size = new System.Drawing.Size(192, 20);
            this.lbStakes.TabIndex = 21;
            this.lbStakes.Text = "Aantal token inzettingen:";
            // 
            // txbStakeAmount
            // 
            this.txbStakeAmount.Location = new System.Drawing.Point(865, 352);
            this.txbStakeAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbStakeAmount.Name = "txbStakeAmount";
            this.txbStakeAmount.Size = new System.Drawing.Size(132, 22);
            this.txbStakeAmount.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(729, 470);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 48);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(865, 326);
            this.lbError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 17);
            this.lbError.TabIndex = 24;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(869, 498);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 17);
            this.lbMessage.TabIndex = 25;
            // 
            // listboxGames
            // 
            this.listboxGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listboxGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.listboxGames.FormattingEnabled = true;
            this.listboxGames.ItemHeight = 29;
            this.listboxGames.Items.AddRange(new object[] {
            "FC Dorst - FC Roosendaal",
            "FC Tilburg - FC Breda",
            "FC Breda - FC Dorst",
            "FC Roosendaal - FC Tilburg"});
            this.listboxGames.Location = new System.Drawing.Point(79, 229);
            this.listboxGames.Name = "listboxGames";
            this.listboxGames.Size = new System.Drawing.Size(352, 178);
            this.listboxGames.TabIndex = 26;
            // 
            // lbSelect
            // 
            this.lbSelect.AutoSize = true;
            this.lbSelect.Location = new System.Drawing.Point(172, 209);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(155, 17);
            this.lbSelect.TabIndex = 27;
            this.lbSelect.Text = "Selecteer een wedstrijd";
            // 
            // StakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbSelect);
            this.Controls.Add(this.listboxGames);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbStakeAmount);
            this.Controls.Add(this.lbStakes);
            this.Controls.Add(this.lbTokens);
            this.Controls.Add(this.lbTokenBalance);
            this.Controls.Add(this.lbGamble);
            this.Controls.Add(this.lbGames);
            this.Controls.Add(this.lbStake);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.lbSummary);
            this.Controls.Add(this.lbLogo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StakeForm";
            this.Text = "Stake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStake;
        private System.Windows.Forms.Label lbLogout;
        private System.Windows.Forms.Label lbSummary;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Label lbGames;
        private System.Windows.Forms.Label lbGamble;
        private System.Windows.Forms.Label lbTokenBalance;
        private System.Windows.Forms.Label lbTokens;
        private System.Windows.Forms.Label lbStakes;
        private System.Windows.Forms.TextBox txbStakeAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.ListBox listboxGames;
        private System.Windows.Forms.Label lbSelect;
    }
}