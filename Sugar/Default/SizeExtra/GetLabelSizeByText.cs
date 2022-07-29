using System.Drawing;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class SizeExtra
    {
        /// <summary>
        /// System.Drawing.Label size
        /// </summary>
        /// <param name="text"></param>
        /// <param name="font"></param>
        /// <returns>{ int Width, int Height }</returns>
        public static Size GetLabelSizeByText(string text, Font font)
        {
            var panel = new Panel();
            var label = new Label()
            {
                Name = "label",
                Size = new Size(1, 1),
                Font = font,
                AutoSize = true,
                Text = text,
            };
            panel.Controls.Add(label);
            return new Size(panel.Controls["label"].Size.Width, panel.Controls["label"].Size.Height);
        }

        /// <summary>
        /// System.Drawing.Label size
        /// </summary>
        /// <param name="text"></param>
        /// <param name="font"></param>
        /// <param name="maximumSize"></param>
        /// <returns>{ int Width, int Height }</returns>
        public static Size GetLabelSizeByText(string text, Font font, Size maximumSize)
        {
            var panel = new Panel();
            var label = new Label()
            {
                Name = "label1",
                Size = new Size(1, 1),
                Font = font,
                AutoSize = true,
                Text = text,
                MaximumSize = maximumSize,
            };
            panel.Controls.Add(label);
            return new Size(panel.Controls["label1"].Size.Width, panel.Controls["label1"].Size.Height);
        }
    }
}