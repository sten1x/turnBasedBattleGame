using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TurnBasedBattleGame.Models;

namespace TurnBasedBattleGame.Views
{
    public partial class Form1 : Form
    {
        private Character team1Character;
        private Character team2Character;

        private PictureBox team1PictureBox;
        private PictureBox team2PictureBox;

        private bool team1Turn = true;

        private int gridStartX;
        private int gridStartY;
        private const int cellWidth = 70;
        private const int cellHeight = 70;
        private const int columns = 10;
        private const int rows = 1;

        public Form1()
        {
            InitializeComponent();
            SetupCharacterSelection();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterCharacterSelectionPanel();
        }

        private void SetupCharacterSelection()
        {
            comboBoxTeam1.DataSource = Enum.GetValues(typeof(CharacterType));
            comboBoxTeam2.DataSource = Enum.GetValues(typeof(CharacterType));
        }

        private void CenterGrid()
        {
            gridStartX = (pnlBattle.Width - (columns * cellWidth)) / 2;
            gridStartY = 150;
        }

        private void CenterCharacterSelectionPanel()
        {
            pnlCharacterSelection.Left = (this.ClientSize.Width - pnlCharacterSelection.Width) / 2;
            pnlCharacterSelection.Top = (this.ClientSize.Height - pnlCharacterSelection.Height) / 2;
        }

        private void btnStartBattle_Click(object sender, EventArgs e)
        {
            CenterGrid();

            team1Character = CharacterFactory.CreateCharacter((CharacterType)comboBoxTeam1.SelectedItem, 1, 1);
            team2Character = CharacterFactory.CreateCharacter((CharacterType)comboBoxTeam2.SelectedItem, 10, 1);

            pnlCharacterSelection.Visible = false;
            pnlBattle.Visible = true;

            InitializeCharactersGraphics();
            UpdateUI();
            UpdateCurrentTurnLabel();
        }

        private void InitializeCharactersGraphics()
        {
            team1PictureBox = CreatePictureBoxForCharacter(team1Character);
            team2PictureBox = CreatePictureBoxForCharacter(team2Character);

            pnlBattle.Controls.Add(team1PictureBox);
            pnlBattle.Controls.Add(team2PictureBox);

            UpdateCharacterGraphic(team1Character);
            UpdateCharacterGraphic(team2Character);
        }

        private PictureBox CreatePictureBoxForCharacter(Character character)
        {
            PictureBox pic = new PictureBox
            {
                Size = new Size(70, 70),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };

            SetCharacterImage(character, pic);

            return pic;
        }

        private void SetCharacterImage(Character character, PictureBox pictureBox)
        {
            string fullPath = Path.Combine(Application.StartupPath, character.ImagePath);

            if (File.Exists(fullPath))
            {
                pictureBox.Image = Image.FromFile(fullPath);
            }
            else
            {
                pictureBox.BackColor = Color.Gray;
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            Character attacker = GetCurrentCharacter();
            Character target = GetEnemyCharacter();

            bool success = attacker.Attack(target);
            if (success)
            {
                listBoxLog.Items.Add($"{attacker.Name} attacked {target.Name}! {target.Name} HP: {target.Health}");
            }
            else
            {
                listBoxLog.Items.Add($"{attacker.Name} tried to attack but was too far!");
            }

            CheckCharacterDeath();
            NextTurn();
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            Character healer = GetCurrentCharacter();

            bool success = healer.Heal(healer);
            if (success)
            {
                listBoxLog.Items.Add($"{healer.Name} healed themselves! {healer.Name} HP: {healer.Health}");
            }
            else
            {
                listBoxLog.Items.Add($"{healer.Name} tried to heal but was too far!");
            }

            NextTurn();
        }

        private void btnMoveCloser_Click(object sender, EventArgs e)
        {
            Character mover = GetCurrentCharacter();
            Character target = GetEnemyCharacter();

            int newX = mover.X;
            int newY = mover.Y;

            if (mover.X < target.X) newX++;
            else if (mover.X > target.X) newX--;

            if (mover.Y < target.Y) newY++;
            else if (mover.Y > target.Y) newY--;

            if (newX == target.X && newY == target.Y)
            {
                listBoxLog.Items.Add($"{mover.Name} tried to move but the space was occupied!");
                return;
            }

            mover.X = newX;
            mover.Y = newY;

            UpdateCharacterGraphic(mover);

            listBoxLog.Items.Add($"{mover.Name} moved closer to {target.Name}. Now at ({mover.X},{mover.Y})");

            UpdateUI();
            NextTurn();
        }

        private void UpdateCharacterGraphic(Character character)
        {
            PictureBox pic = character == team1Character ? team1PictureBox : team2PictureBox;

            int xCoord = gridStartX + (character.X - 1) * cellWidth + (cellWidth - pic.Width) / 2;
            int yCoord = gridStartY + (character.Y - 1) * cellHeight + (cellHeight - pic.Height) / 2;

            if (team1Character.X == team2Character.X && team1Character.Y == team2Character.Y)
            {
                if (character == team1Character)
                    xCoord -= 5;
                else
                    xCoord += 5;
            }

            pic.Location = new Point(xCoord, yCoord);
        }

        private void NextTurn()
        {
            team1Turn = !team1Turn;
            UpdateUI();
            UpdateCurrentTurnLabel();
            pnlBattle.Invalidate();
        }

        private void CheckCharacterDeath()
        {
            if (team1Character.Health <= 0)
            {
                MessageBox.Show("Team 2 wins!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EndGame();
            }
            else if (team2Character.Health <= 0)
            {
                MessageBox.Show("Team 1 wins!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EndGame();
            }
        }

        private void EndGame()
        {
            btnAttack.Enabled = false;
            btnHeal.Enabled = false;
            btnMoveCloser.Enabled = false;
        }

        private Character GetCurrentCharacter()
        {
            return team1Turn ? team1Character : team2Character;
        }

        private Character GetEnemyCharacter()
        {
            return team1Turn ? team2Character : team1Character;
        }

        private void UpdateUI()
        {
            lblTeam1Char.Text = $"{team1Character.Name} HP: {team1Character.Health}";
            lblTeam2Char.Text = $"{team2Character.Name} HP: {team2Character.Health}";
        }

        private void UpdateCurrentTurnLabel()
        {
            Character current = GetCurrentCharacter();
            string team = team1Turn ? "Team 1" : "Team 2";
            lblCurrentTurn.Text = $"Current Turn: {team} - {current.Name}";
            btnHeal.Visible = current.HealingAbility != null;
        }

        private void pnlBattle_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid(e.Graphics);
        }

        private void DrawGrid(Graphics g)
        {
            Pen gridPen = new Pen(Color.Gray, 2);
            Brush team1Brush = new SolidBrush(Color.FromArgb(50, Color.Blue));
            Brush team2Brush = new SolidBrush(Color.FromArgb(50, Color.Red));

            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    int xPos = gridStartX + x * cellWidth;
                    int yPos = gridStartY + y * cellHeight;

                    Rectangle rect = new Rectangle(xPos, yPos, cellWidth, cellHeight);

                    if (team1Character.X == x + 1 && team1Character.Y == y + 1)
                    {
                        g.FillRectangle(team1Brush, rect);
                    }
                    if (team2Character.X == x + 1 && team2Character.Y == y + 1)
                    {
                        g.FillRectangle(team2Brush, rect);
                    }

                    g.DrawRectangle(gridPen, rect);
                }
            }

            gridPen.Dispose();
            team1Brush.Dispose();
            team2Brush.Dispose();
        }
    }
}
