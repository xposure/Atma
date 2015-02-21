using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EasyTabs;

namespace Atma.Editor
{
    public partial class TabWindow : Form
    {
	    protected TitleBarTabs ParentTabs
	    {
		    get
		    {
			    return (ParentForm as TitleBarTabs);
		    }
	    }

        public TabWindow()
        {
            InitializeComponent();
        }
    }
}
