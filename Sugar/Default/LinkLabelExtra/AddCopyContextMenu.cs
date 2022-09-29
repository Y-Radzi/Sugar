using System.Windows.Forms;

namespace Sugar
{
    public static partial class LinkLabelExtra
    {
        /// <summary>
        /// Copy
        /// </summary>
        /// <param name="linkLabel"></param>
        public static void AddCopyContextMenu(this LinkLabel linkLabel)
        {
            if (linkLabel.ContextMenuStrip == null)
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip()
                {
                    ShowImageMargin = false
                };

                ToolStripMenuItem toolStripMenuItemCopy = new ToolStripMenuItem("Copy");
                toolStripMenuItemCopy.Click += (sender, e) => Clipboard.SetText(linkLabel.Text);
                contextMenuStrip.Items.Add(toolStripMenuItemCopy);

                contextMenuStrip.Opening += (sender, e) => { toolStripMenuItemCopy.Enabled = true; };

                linkLabel.ContextMenuStrip = contextMenuStrip;
            }
        }
    }
}
