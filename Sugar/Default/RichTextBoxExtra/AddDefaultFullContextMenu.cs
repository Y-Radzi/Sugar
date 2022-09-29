using System.Windows.Forms;

namespace Sugar
{
    public static partial class RichTextBoxExtra
    {
        /// <summary>
        /// Undo, Redo, Cut, Copy, Paste, Delete, Select All
        /// </summary>
        /// <param name="richTextBox"></param>
        public static void AddDefaultFullContextMenu(this RichTextBox richTextBox)
        {
            if (richTextBox.ContextMenuStrip == null)
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip()
                {
                    ShowImageMargin = false
                };

                ToolStripMenuItem toolStripMenuItemUndo = new ToolStripMenuItem("Undo");
                toolStripMenuItemUndo.Click += (sender, e) => richTextBox.Undo();
                contextMenuStrip.Items.Add(toolStripMenuItemUndo);

                ToolStripMenuItem toolStripMenuItemRedo = new ToolStripMenuItem("Redo");
                toolStripMenuItemRedo.Click += (sender, e) => richTextBox.Redo();
                contextMenuStrip.Items.Add(toolStripMenuItemRedo);

                contextMenuStrip.Items.Add(new ToolStripSeparator());

                ToolStripMenuItem toolStripMenuItemCut = new ToolStripMenuItem("Cut");
                toolStripMenuItemCut.Click += (sender, e) => richTextBox.Cut();
                contextMenuStrip.Items.Add(toolStripMenuItemCut);

                ToolStripMenuItem toolStripMenuItemCopy = new ToolStripMenuItem("Copy");
                toolStripMenuItemCopy.Click += (sender, e) => richTextBox.Copy();
                contextMenuStrip.Items.Add(toolStripMenuItemCopy);

                ToolStripMenuItem toolStripMenuItemPaste = new ToolStripMenuItem("Paste");
                toolStripMenuItemPaste.Click += (sender, e) => richTextBox.Paste();
                contextMenuStrip.Items.Add(toolStripMenuItemPaste);

                ToolStripMenuItem toolStripMenuItemDelete = new ToolStripMenuItem("Delete");
                toolStripMenuItemDelete.Click += (sender, e) => richTextBox.SelectedText = "";
                contextMenuStrip.Items.Add(toolStripMenuItemDelete);

                contextMenuStrip.Items.Add(new ToolStripSeparator());

                ToolStripMenuItem toolStripMenuItemSelectAll = new ToolStripMenuItem("Select All");
                toolStripMenuItemSelectAll.Click += (sender, e) => richTextBox.SelectAll();
                contextMenuStrip.Items.Add(toolStripMenuItemSelectAll);

                contextMenuStrip.Opening += (sender, e) =>
                {
                    toolStripMenuItemUndo.Enabled = !richTextBox.ReadOnly && richTextBox.CanUndo;
                    toolStripMenuItemRedo.Enabled = !richTextBox.ReadOnly && richTextBox.CanRedo;
                    toolStripMenuItemCut.Enabled = !richTextBox.ReadOnly && richTextBox.SelectionLength > 0;
                    toolStripMenuItemCopy.Enabled = richTextBox.SelectionLength > 0;
                    toolStripMenuItemPaste.Enabled = !richTextBox.ReadOnly && Clipboard.ContainsText();
                    toolStripMenuItemDelete.Enabled = !richTextBox.ReadOnly && richTextBox.SelectionLength > 0;
                    toolStripMenuItemSelectAll.Enabled = richTextBox.TextLength > 0 && richTextBox.SelectionLength < richTextBox.TextLength;
                };

                richTextBox.ContextMenuStrip = contextMenuStrip;
            }
        }
    }
}
