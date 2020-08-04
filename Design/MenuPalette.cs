namespace R3BinderTools.Design
{
    using System.Drawing;
    using System.Windows.Forms;

    public class MenuPalette : ProfessionalColorTable
    {
        public MenuPalette() 
        {
            UseSystemColors = false;
        }

        public override Color ToolStripDropDownBackground => Color.Blue;

        public override Color ImageMarginGradientBegin => Color.Blue;

        public override Color ImageMarginGradientMiddle => Color.Blue;

        public override Color ImageMarginGradientEnd => Color.Blue;

        public override Color MenuBorder => Color.Black;

        public override Color MenuItemBorder => Color.Black;

        public override Color MenuItemSelected => Color.Navy;

        public override Color MenuStripGradientBegin => Color.Blue;

        public override Color MenuStripGradientEnd => Color.Blue;

        public override Color MenuItemSelectedGradientBegin => Color.Navy;

        public override Color MenuItemSelectedGradientEnd => Color.Navy;

        public override Color MenuItemPressedGradientBegin => Color.Blue;

        public override Color MenuItemPressedGradientEnd => Color.Blue;

        public override Color ButtonSelectedHighlight => Color.FromArgb(51, 153, 255);
    }
}