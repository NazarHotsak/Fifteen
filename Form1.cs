using System;

namespace Fifteen
{
    public partial class Form1 : Form
    {
        private TableLayoutPanel tableLayoutPanelX3;

        private int[,] _map;
        private const byte _emptyButton = 0;
        Game game = new Game();
        Sorting sorting = new Sorting();    

        public Form1()
        {
            InitializeComponent();
            TableLayoutPanelX3Create();
            ButtonEnableFalse();
            MapCreateNew(4, 4);
            UpDate();
            StopTimer();
            PlayToolStripMenuItem.Enabled = false;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int tag = Convert.ToInt16(((Button)sender).Tag);
            
            int BtnPositionY = tag / _map.GetLength(0);
            
            int BtnPositionX = tag - _map.GetLength(1) * BtnPositionY;
            
            if (game.doesButtonsMove(_map, BtnPositionY, BtnPositionX))
            {
                UpDate();
                IsWinning(_map);
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopTimer();

            ButtonEnableFalse();

            PlayToolStripMenuItem.Enabled = true;

            MapCreateNew(_map.GetLength(1), _map.GetLength(0));
            //Array.Copy(_startMap, _map, _startMap.Length);

            sorting.SortMapOfBtn(_map);

            UpDate();
        }

        private void UpDate()
        {
            int indexOfBtn = 0;
            for (int y = 0; y < _map.GetLength(0); y++)
            {
                for (int x = 0; x < _map.GetLength(1); x++)
                {
                    if (Button(indexOfBtn).Visible == false)
                    {
                        Button(indexOfBtn).Visible = true;
                    }
                    if (_map[y, x] != _emptyButton)
                    {
                        Button(indexOfBtn).Text = $"{_map[y, x]}";
                    }
                    else
                    {
                        Button(indexOfBtn).Text = $"{_map[y, x]}";
                        Button(indexOfBtn).Visible = false;
                    }
                    indexOfBtn++;
                }
            }
        }

        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayToolStripMenuItem.Enabled = false;
            ButtonEnableTrue();
            timer.Start();
        }

        private void ButtonEnableTrue()
        {
            button1.Enabled =  true;
            button2.Enabled =  true;
            button3.Enabled =  true;
            button4.Enabled =  true;
            button5.Enabled =  true;
            button6.Enabled =  true;
            button7.Enabled =  true;
            button8.Enabled =  true;
            button9.Enabled =  true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
        }

        private void ButtonEnableFalse()
        {
            button1.Enabled =  false;
            button2.Enabled =  false;
            button3.Enabled =  false;
            button4.Enabled =  false;
            button5.Enabled =  false;
            button6.Enabled =  false;
            button7.Enabled =  false;
            button8.Enabled =  false;
            button9.Enabled =  false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
        }

        private void IsWinning(int[,] map)
        {
            int correctOrder = 0;

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    correctOrder++;
                    if (y == map.GetLength(0) - 1 && x == map.GetLength(1) - 1)
                    {
                        ButtonEnableFalse();
                        PlayToolStripMenuItem.Enabled = false;
                        timer.Stop();
                        MessageBox.Show($"Ви зібрали п'ятнашки за {this.Text}");
                        StopTimer();
                        return;
                    }
                    if (map[y, x] != correctOrder)
                    {
                        return;
                    }
                }
            }
        }

        private Button Button(int position)
        {
            return position switch
            {
                0 => button1,
                1 => button2,
                2 => button3,
                3 => button4,
                4 => button5,
                5 => button6,
                6 => button7,
                7 => button8,
                8 => button9,
                9 => button10,
                10 => button11,
                11 => button12,
                12 => button13,
                13 => button14,
                14 => button15,
                15 => button16,
                _ => throw new Exception("error position"),
            };
        }

        private int second;
        private int minute;
        private void timer_Tick(object sender, EventArgs e)
        {
            second++;
            if (second == 60)
            {
                minute++;
                second = 0;
            }
            if (second < 10)
            {
                this.Text = $"{minute}:0{second}";
            }
            else
            {
                this.Text = $"{minute}:{second}";     
            }
        }

        private void StopTimer()
        {
            second = 0;
            minute = 0;
            this.Text = "0:00";
            timer.Stop();
        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.tableLayoutPanelX4.Visible)
            {
                return;
            }
            this.tableLayoutPanelX4.Visible = true;

            this.tableLayoutPanelX4.Controls.Add(this.button9, 0, 2);
            this.tableLayoutPanelX4.Controls.Add(this.button8, 3, 1);
            this.tableLayoutPanelX4.Controls.Add(this.button7, 2, 1);
            this.tableLayoutPanelX4.Controls.Add(this.button6, 1, 1);
            this.tableLayoutPanelX4.Controls.Add(this.button5, 0, 1);
            this.tableLayoutPanelX4.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanelX4.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanelX4.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanelX4.Controls.Add(this.button1, 0, 0);

            MapCreateNew(4, 4);
            UpDate();
            ButtonEnableFalse();
            timer.Stop();
            PlayToolStripMenuItem.Enabled = false;

            this.tableLayoutPanelX3.Visible = false;
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.tableLayoutPanelX3.Visible)
            {
                return;
            }
            this.tableLayoutPanelX3.Visible = true;

            this.tableLayoutPanelX3.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanelX3.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanelX3.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanelX3.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanelX3.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanelX3.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanelX3.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanelX3.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanelX3.Controls.Add(this.button1, 0, 0);

            MapCreateNew(3, 3);
            UpDate();
            ButtonEnableFalse();
            timer.Stop();
            PlayToolStripMenuItem.Enabled = false;

            this.tableLayoutPanelX4.Visible = false;
        }

        private void TableLayoutPanelX3Create()
        {
            this.tableLayoutPanelX3 = new TableLayoutPanel();

            this.tableLayoutPanelX3.BackColor = System.Drawing.Color.Ivory;
            this.tableLayoutPanelX3.ColumnCount = 3;
            this.tableLayoutPanelX3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f / 3));
            this.tableLayoutPanelX3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f / 3));
            this.tableLayoutPanelX3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f / 3));
            this.tableLayoutPanelX3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanelX3.Name = "tableLayoutPanelX3";
            this.tableLayoutPanelX3.RowCount = 3;
            this.tableLayoutPanelX3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f / 3));
            this.tableLayoutPanelX3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f / 3));
            this.tableLayoutPanelX3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f / 3));
            this.tableLayoutPanelX3.Size = new System.Drawing.Size(232, 232);
            this.tableLayoutPanelX3.Visible = false;
            Controls.Add(tableLayoutPanelX3);
        }

        private void MapCreateNew(int columnCount, int rowCount)
        {
            _map = new int[rowCount, columnCount];
            int order = 0;
            for (int y = 0; y < rowCount; y++)
            {
                for (int x = 0; x < columnCount; x++)
                {
                    if (y == rowCount - 1 && x == columnCount - 1)
                    {
                        _map[y, x] = 0;
                    }
                    else
                    {
                        order++;
                        _map[y, x] = order;
                    }
                }
            }
        }
    }
}



