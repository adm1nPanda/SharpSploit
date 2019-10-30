// Author: Ryan Cobb (@cobbr_io)
// Project: SharpSploit (https://github.com/cobbr/SharpSploit)
// License: BSD 3-Clause

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SharpSploit.Enumeration
{
    /// <summary>
    /// Screenshot allows taking an image of the current user screen.
    /// </summary>
    public class Screenshot
    {

        public static void screenshot(Rectangle bounds , string path) {
            
            Bitmap bmp = new Bitmap(bounds.Width, bounds.Height);
            Graphics g = Graphics.FromImage(bmp);

            g.CopyFromScreen(bounds.Width,bounds.Height, 0,0,);

            bmp.Save(path);

            graphics.Dispose();
            bmp.Dispose();
        }

        
    }
}
