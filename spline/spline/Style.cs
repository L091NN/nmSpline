using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace spline
{
    class Style
    {
        public Dictionary<string, Color> colors;

        public Style()
        {
            colors = new Dictionary<string, Color>();
            colors.Add("black.vs", Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28))))));
            colors.Add("red.vs", Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(33))))));
            colors.Add("green.vs", Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(209)))), ((int)(((byte)(132))))));
            colors.Add("blue.vs", Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))));
            colors.Add("pink.my", Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))));
            colors.Add("red.man of steel", Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(6))))));
            colors.Add("blue.man of steel", Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(97))))));
            colors.Add("black.argon", Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(30))))));
            colors.Add("purple.argon", Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(3)))), ((int)(((byte)(192))))));
            colors.Add("pink.argon", Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188))))));
            colors.Add("white.argon", Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(239)))), ((int)(((byte)(249))))));
            colors.Add("green.argon", Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(252)))), ((int)(((byte)(63))))));
            colors.Add("blue.king yna", Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(108))))));
            colors.Add("red.king yna", Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(31)))), ((int)(((byte)(31))))));
            colors.Add("yellow.king yna", Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(187)))), ((int)(((byte)(45))))));
        }
    }
}
