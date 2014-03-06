using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DesktopNote
{
    class Note
    {
        private string s_Content;
        public string Content {
            get { return s_Content; }
            set { s_Content = value; }
        }
        private DateTime dt_CreateDateTime;
        public DateTime CreateDateTime {
            get { return dt_CreateDateTime; }
            set { dt_CreateDateTime = value;}
        }

        private DateTime dt_ModifyDateTime;
        public DateTime ModifyDateTime
        {
            get { return dt_ModifyDateTime; }
            set { dt_ModifyDateTime = value; }
        }

        private Color cl_BackColor;
        public Color BackColor
        {
            get { return cl_BackColor; }
            set { cl_BackColor = value; }
        }
        private Color cl_ForeColor;
        public Color ForeColor
        {
            get { return cl_ForeColor; }
            set { cl_ForeColor = value; }
        }
        private Font ft_Font;
        public Font Font
        {
            get { return ft_Font; }
            set { ft_Font = value; }
        }

    }
}
