using EasyTabs;

namespace Atma.Editor
{
	public partial class EditorApp : TitleBarTabs
    {
        public EditorApp()
        {
            InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
            //Icon = Resources.DefaultIcon;
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new TabWindow
                {
                    Text = "New Tab"
                }
            };
        }
    }
}
