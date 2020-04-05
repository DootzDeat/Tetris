using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Chess.Model
{
    class KingFirgure : Firgure
    {
        public override void DrawFiruge(PictureBox ptb)
        {
            base.DrawFiruge(ptb);
            ptb.BackColor = Color.Red;
        }
    }
}
