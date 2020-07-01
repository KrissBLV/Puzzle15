using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle15
{
    public partial class PuzzleArea : Form
    {
        public PuzzleArea()
        {
            InitializeComponent();
            InitializePuzzleArea();
            InitializeBLocks();
        }

        private void InitializePuzzleArea()
        {
            this.BackColor = Color.LightGreen;
            this.Text = "Puzzle 15";
            this.ClientSize = new Size(800, 800);
        }

        private void InitializeBLocks()
        {
            int blockCount = 1;
            PuzzleBlock block;
            for(int row = 1; row < 5; row++ )
            {
                for(int col = 1; col < 5; col++)
                {
                    block = new PuzzleBlock();
                    block.Top = row * 155;
                    block.Left = col * 155;
                    block.Text = blockCount.ToString();
                    Name = "Block" + blockCount.ToString();
                    

                    //block.Click += new EventHandler(Block_Click);
                    block.Click += Block_Click;
                    if(blockCount == 16)
                    {
                        block.Name = "EmptyBlock";
                        block.Text = "";
                        block.BackColor = Color.AntiqueWhite;
                    }
                    blockCount++;
                    this.Controls.Add(block);
                }
            }
        }

        private void Block_Click(object sender, EventArgs e)
        {
            Button block = (Button)sender;
            if (IsAdjacent(block))
            {
                SwapBlocks(block);
            }
        }

        private void SwapBlocks(Button block)
        {
            Button zeroBlock = (Button)this.Controls["EmptyBlock"];
            Point oldLocation = block.Location;
            block.Location = zeroBlock.Location;
            zeroBlock.Location = oldLocation;
            
        }

        private bool IsAdjacent(Button block)
        {
            double a;
            double b;
            double c;
            Button zeroBlock = (Button)this.Controls["EmptyBlock"];

            a = Math.Abs(zeroBlock.Top - block.Top);
            b = Math.Abs(zeroBlock.Left - block.Left);
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            if(c < 156)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
