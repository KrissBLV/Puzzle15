using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle15
{
    class PuzzleBlock : Button
    {
        public PuzzleBlock()
        {
            InitializePuzzleBlock();
        }

        private void InitializePuzzleBlock()
        {
            this.BackColor = Color.LightYellow;
            this.Height = 150;
            this.Width = 150;
            this.Text = "0";
            this.Font = new Font("Roboto", 18);
        }
    }
}
