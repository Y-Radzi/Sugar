using System.Windows.Forms;

namespace Sugar
{
    public static partial class RichTextBoxExtra
    {
        
        public static void DragEnter_File(this RichTextBox richTextBox, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
    }
}
