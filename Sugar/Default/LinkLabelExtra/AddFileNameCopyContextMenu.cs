using System.Windows.Forms;

namespace Sugar
{
    public static partial class LinkLabelExtra
    {
        /// <summary>
        /// Copy file fullname, path, shortname no ext.
        /// </summary>
        /// <param name="linkLabel"></param>
        public static void AddFileNameCopyContextMenu(this LinkLabel linkLabel)
        {
            if (linkLabel.ContextMenuStrip == null && !linkLabel.Text.IsNullOrEmpty() && FileExtra.IsFile(linkLabel.Text, false))
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip()
                {
                    ShowImageMargin = false
                };

                ToolStripMenuItem toolStripMenuItemCopyFileFullname = new ToolStripMenuItem("Copy file fullname");
                toolStripMenuItemCopyFileFullname.Click += (sender, e) => Clipboard.SetText(linkLabel.Text);
                contextMenuStrip.Items.Add(toolStripMenuItemCopyFileFullname);

                ToolStripMenuItem toolStripMenuItemCopyPath = new ToolStripMenuItem("Copy path");
                toolStripMenuItemCopyPath.Click += (sender, e) => Clipboard.SetText(FileExtra.GetFileFolder(linkLabel.Text));
                contextMenuStrip.Items.Add(toolStripMenuItemCopyPath);

                ToolStripMenuItem toolStripMenuItemCopyFileShortnameNoExt = new ToolStripMenuItem("Copy file shortname no ext.");
                toolStripMenuItemCopyFileShortnameNoExt.Click += (sender, e) => Clipboard.SetText(FileExtra.GetFileShortNameNoExtention(linkLabel.Text));
                contextMenuStrip.Items.Add(toolStripMenuItemCopyFileShortnameNoExt);

                contextMenuStrip.Opening += (sender, e) => {
                    toolStripMenuItemCopyFileFullname.Enabled = true;
                    toolStripMenuItemCopyPath.Enabled = true;
                    toolStripMenuItemCopyFileShortnameNoExt.Enabled = true;

                };

                linkLabel.ContextMenuStrip = contextMenuStrip;
            }
        }
    }
}
