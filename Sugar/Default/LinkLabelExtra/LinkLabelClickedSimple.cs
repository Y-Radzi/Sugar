using System.Windows.Forms;
using System.Diagnostics;

namespace Sugar
{
    public static partial class LinkLabelExtra
    {
        /// <summary>
        /// Simple event for LinkLabel
        /// Process.Start("explorer.exe", e.Link.LinkData...)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void LinkLabelClickedSimple(
            object sender,
            LinkLabelLinkClickedEventArgs e
            )
        {
            (sender as LinkLabel).Links[(sender as LinkLabel).Links.IndexOf(e.Link)].Visited = true;
            Process.Start("explorer.exe", $"\"{e.Link.LinkData as string}\"");
        }
    }
}
