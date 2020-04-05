using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Chess.Controler
{
    class Controller
    {
        List<List<PictureBox>> matrixPtbFirgure = new List<List<PictureBox>>();

        public void DrawMatrix(Panel gameBoard)
        {
            for (int i = 0; i < 8; i++)
            {
                matrixPtbFirgure.Add(new List<PictureBox>());
                for (int j = 0; j < 8; j++)
                {
                    PictureBox ptb = new PictureBox()
                    {
                        Width = Setting.cageWidth,
                        Height = Setting.cageHeight,
                        Location = new Point(j * Setting.cageWidth, i * Setting.cageHeight),
                        Size = new Size(Setting.cageWidth - 1, Setting.cageHeight - 1),
                        BackColor = Color.Black,
                        Tag = i.ToString()
                    };
                    gameBoard.Controls.Add(ptb);
                    matrixPtbFirgure[i].Add(ptb);
                }
            }
        }

        private Point GetPoint (PictureBox ptb)
        {
            Point point = new Point();
            
            int Vertical = Convert.ToInt32(ptb.Tag);


            return point;
        }

    }
}
