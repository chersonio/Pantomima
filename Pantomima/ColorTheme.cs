using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantomima
{
    public class ColorTheme
    {
        //From Settings is better.
        public Color MainBackgroundColor { get; set; } 
        public Color MainText { get; set; } 
        public Color MainTextDisabledColor { get; set; }
        public int MovieTextSize { get; set; } 
        public int SubTextSize { get; set; } 
        public int TimerTextStartingSize { get; set; } 
        public Color DetailsColor { get; set; } 
        public Color ButtonEnabledColor { get; set; } 
        public Color ButtonDisabledColor { get; set; }
        public Font TextFont { get; set; } = new Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public ColorTheme()
        {
            MainBackgroundColor = Color.FromName("Purple");
            MainText = Color.FromArgb(255, 255, 246, 229);
            MainTextDisabledColor = Color.FromArgb(255, 255, 246, 229);
            MovieTextSize = 15;
            SubTextSize = 12;
            TimerTextStartingSize = 20;
            DetailsColor = Color.FromName("Yellow");
            ButtonEnabledColor = Color.FromName("Purple");
            ButtonDisabledColor = Color.FromName("Grey");
        }
    }
}
