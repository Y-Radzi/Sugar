using System.Windows.Forms;
using System.IO;

namespace Sugar
{
    public static partial class RichTextBoxExtra
    {
        public static void DragDrop_Folder(this RichTextBox richTextBox, DragEventArgs e)
        {
            string dragDropPath = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];
            if (Directory.Exists(dragDropPath))
                richTextBox.Text = dragDropPath;
        }
    }
}
