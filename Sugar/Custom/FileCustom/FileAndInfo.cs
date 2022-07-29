using System.IO;

namespace Sugar
{
    public static partial class FileCustom
    {
        /// <summary>
        /// Class only for keeping data.
        /// Please, don't add any new methods.
        /// </summary>
        public class FileAndInfo
        {
            public FileInfo Info { get; set; }

            /// <summary>
            /// File.ReadAllBytes(...).GetHashCode()
            /// </summary>
            public int DataHashCode { get; set; } = -1;


            /////////////////////////////////////////////Methods

            /// <summary>
            /// Initiate FileAndInfo.Info
            /// </summary>
            /// <param name="fileFullname"></param>
            /// <returns></returns>
            public void GetInfo(string fileFullname)
            {
                this.Info = new FileInfo(fileFullname);
            }

            /// <summary>
            /// Initiate FileAndInfo.DataHashCode by fileFullname
            /// </summary>
            /// <param name="fileFullname"></param>
            /// <returns></returns>
            public void GetDataHashCode(string fileFullname)
            {
                var data = File.ReadAllBytes(fileFullname);
                this.DataHashCode = Array<byte>.GetHashCodeOfArray(data);
            }

        }


    }
}
