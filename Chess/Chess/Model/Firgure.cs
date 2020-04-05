using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess.Model
{
    class Firgure
    {
        protected int firgureWidth { get; set; }
        protected int firgureHeight { get; set; }

        public Firgure()
        {
            firgureWidth = 100;
            firgureHeight = 100;
        }

        public virtual void DrawFiruge(PictureBox ptb)
        {
            ptb.Size = new Size(firgureWidth,firgureHeight);
        }

    }
}
