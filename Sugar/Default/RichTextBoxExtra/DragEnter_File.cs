using System.Windows.Forms;

namespace Sugar
{
    public static partial class RichTextBoxExtra
    {
        
        public static void DragEnter_File(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
    }
}
