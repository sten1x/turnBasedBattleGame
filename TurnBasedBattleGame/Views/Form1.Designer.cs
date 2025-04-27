namespace TurnBasedBattleGame.Views
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlCharacterSelection;
        private System.Windows.Forms.ComboBox comboBoxTeam1;
        private System.Windows.Forms.ComboBox comboBoxTeam2;
        private System.Windows.Forms.Button btnStartBattle;

        private System.Windows.Forms.Panel pnlBattle;
        private System.Windows.Forms.Label lblTeam1Char;
        private System.Windows.Forms.Label lblCurrentTurn;
        private System.Windows.Forms.Label lblTeam2Char;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnMoveCloser;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.ListBox listBoxLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlCharacterSelection = new System.Windows.Forms.Panel();
            this.comboBoxTeam1 = new System.Windows.Forms.ComboBox();
            this.comboBoxTeam2 = new System.Windows.Forms.ComboBox();
            this.btnStartBattle = new System.Windows.Forms.Button();

            this.pnlBattle = new System.Windows.Forms.Panel();
            this.lblTeam1Char = new System.Windows.Forms.Label();
            this.lblCurrentTurn = new System.Windows.Forms.Label();
            this.lblTeam2Char = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnMoveCloser = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();

            this.pnlCharacterSelection.SuspendLayout();
            this.pnlBattle.SuspendLayout();
            this.SuspendLayout();

            // pnlCharacterSelection
            this.pnlCharacterSelection.Controls.Add(this.comboBoxTeam1);
            this.pnlCharacterSelection.Controls.Add(this.comboBoxTeam2);
            this.pnlCharacterSelection.Controls.Add(this.btnStartBattle);
            this.pnlCharacterSelection.Location = new System.Drawing.Point(300, 200);
            this.pnlCharacterSelection.Name = "pnlCharacterSelection";
            this.pnlCharacterSelection.Size = new System.Drawing.Size(400, 150);
            this.pnlCharacterSelection.TabIndex = 0;
            this.pnlCharacterSelection.Anchor = System.Windows.Forms.AnchorStyles.None;

            // comboBoxTeam1
            this.comboBoxTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeam1.FormattingEnabled = true;
            this.comboBoxTeam1.Location = new System.Drawing.Point(30, 30);
            this.comboBoxTeam1.Name = "comboBoxTeam1";
            this.comboBoxTeam1.Size = new System.Drawing.Size(150, 28);

            // comboBoxTeam2
            this.comboBoxTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeam2.FormattingEnabled = true;
            this.comboBoxTeam2.Location = new System.Drawing.Point(220, 30);
            this.comboBoxTeam2.Name = "comboBoxTeam2";
            this.comboBoxTeam2.Size = new System.Drawing.Size(150, 28);

            // btnStartBattle
            this.btnStartBattle.Location = new System.Drawing.Point(150, 80);
            this.btnStartBattle.Name = "btnStartBattle";
            this.btnStartBattle.Size = new System.Drawing.Size(100, 40);
            this.btnStartBattle.Text = "Start Battle";
            this.btnStartBattle.UseVisualStyleBackColor = true;
            this.btnStartBattle.Click += new System.EventHandler(this.btnStartBattle_Click);

            // pnlBattle
            this.pnlBattle.Controls.Add(this.lblTeam1Char);
            this.pnlBattle.Controls.Add(this.lblCurrentTurn);
            this.pnlBattle.Controls.Add(this.lblTeam2Char);
            this.pnlBattle.Controls.Add(this.btnAttack);
            this.pnlBattle.Controls.Add(this.btnMoveCloser);
            this.pnlBattle.Controls.Add(this.btnHeal);
            this.pnlBattle.Controls.Add(this.listBoxLog);
            this.pnlBattle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBattle.Location = new System.Drawing.Point(0, 0);
            this.pnlBattle.Name = "pnlBattle";
            this.pnlBattle.Size = new System.Drawing.Size(1000, 800);
            this.pnlBattle.TabIndex = 1;
            this.pnlBattle.Visible = false;
            this.pnlBattle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBattle_Paint);

            // lblTeam1Char
            this.lblTeam1Char.AutoSize = true;
            this.lblTeam1Char.Location = new System.Drawing.Point(100, 20);
            this.lblTeam1Char.Name = "lblTeam1Char";
            this.lblTeam1Char.Size = new System.Drawing.Size(90, 20);
            this.lblTeam1Char.Text = "Warrior HP: 120";

            // lblCurrentTurn
            this.lblCurrentTurn.AutoSize = true;
            this.lblCurrentTurn.Location = new System.Drawing.Point(450, 20);
            this.lblCurrentTurn.Name = "lblCurrentTurn";
            this.lblCurrentTurn.Size = new System.Drawing.Size(140, 20);
            this.lblCurrentTurn.Text = "Current Turn: Team 1 - Warrior";

            // lblTeam2Char
            this.lblTeam2Char.AutoSize = true;
            this.lblTeam2Char.Location = new System.Drawing.Point(800, 20);
            this.lblTeam2Char.Name = "lblTeam2Char";
            this.lblTeam2Char.Size = new System.Drawing.Size(90, 20);
            this.lblTeam2Char.Text = "Archer HP: 80";

            // btnAttack
            this.btnAttack.Location = new System.Drawing.Point(400, 500);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(80, 40);
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);

            // btnMoveCloser
            this.btnMoveCloser.Location = new System.Drawing.Point(500, 500);
            this.btnMoveCloser.Name = "btnMoveCloser";
            this.btnMoveCloser.Size = new System.Drawing.Size(80, 40);
            this.btnMoveCloser.Text = "Move";
            this.btnMoveCloser.UseVisualStyleBackColor = true;
            this.btnMoveCloser.Click += new System.EventHandler(this.btnMoveCloser_Click);

            // btnHeal
            this.btnHeal.Location = new System.Drawing.Point(600, 500);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(80, 40);
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.Visible = false;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);

            // listBoxLog
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.ItemHeight = 20;
            this.listBoxLog.Location = new System.Drawing.Point(50, 560);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(900, 200);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.pnlBattle);
            this.Controls.Add(this.pnlCharacterSelection);
            this.Name = "Form1";
            this.Text = "Turn-Based Battle Game";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.pnlCharacterSelection.ResumeLayout(false);
            this.pnlBattle.ResumeLayout(false);
            this.pnlBattle.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
