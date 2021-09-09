# Splash-Screen-Animation
Software splash screen with color cycle animation

# Development Tools
* [Bunifu Framework](https://bunifuframework.com/)
* [Visual Studio](https://visualstudio.microsoft.com/)

# Color Cycle Animation
```sh
 List<Color> colors = new List<Color>();
        public Splash()
        {
            colors.Add(Color.FromArgb(0, 158, 71));
            colors.Add(Color.FromArgb(112, 191, 83));
            colors.Add(Color.FromArgb(216, 155, 40));
            colors.Add(Color.FromArgb(217, 102, 42));
            colors.Add(Color.FromArgb(217, 102, 42));
            colors.Add(Color.FromArgb(235, 83, 104));
            colors.Add(Color.FromArgb(223, 128, 255));
            colors.Add(Color.FromArgb(112, 48, 160));
            colors.Add(Color.FromArgb(107, 122, 187));
            colors.Add(Color.FromArgb(95, 136, 176));
            colors.Add(Color.FromArgb(70, 175, 227));
            colors.Add(Color.FromArgb(0, 158, 71));
            
            InitializeComponent();
        }
        private void BunifuClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        int curcolor = 0;
        int loop = 0;

        private void fader_Tick(object sender, EventArgs e)
        {
            fader.Enabled = false;
            if (curcolor < colors.Count - 1)
            {
                this.BackColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(loop, colors[curcolor], colors[curcolor + 1]);
                if (loop < 100)
                {
                    loop++;
                }
                else
                {
                    loop = 0;
                    curcolor++;
                }
                fader.Enabled = true;
            }
            else
            {
                MessageBox.Show("Complete.");
            }
        }
```
# Preview
![Splash Screen](https://user-images.githubusercontent.com/68661362/88498302-beb51480-cf90-11ea-8b7b-037da9a0b5a6.gif)
