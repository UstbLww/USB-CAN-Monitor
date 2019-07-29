using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Svpwm_Can
{

    /// <summary> 
    /// 解决系统TabControl多余白线边距问题 
    /// </summary>
    class FullTabControl  : TabControl
    {
        public override Rectangle DisplayRectangle
        {
            get
            {
                Rectangle rect = base.DisplayRectangle;
                return new Rectangle(rect.Left - 2, rect.Top + 0, rect.Width + 2, rect.Height + 1);
            }
        }
    }
}
