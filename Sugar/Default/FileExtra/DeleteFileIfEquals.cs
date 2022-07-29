using System.IO;
using System;
using System.Linq;

namespace Sugar
{
    public static partial class FileExtra
    {
        /// <summary>
        /// Delete file if data equals to other
        /// </summary>
        /// <param name="fileFullNameToDelete"></param>
        /// <param name="dataToDelete"></param>
        /// <param name="dataToCompare"></param>
        /// <returns>"true" if deleted, "false" if not</returns>
        /// <exception cref="Exception"></exception>
        public static bool DeleteFileIfEquals(string fileFullNameToDelete, byte[] dataToDelete, byte[] dataToCompare)
        {
            if (!IsFile(fileFullNameToDelete, true))
                throw new Exception($"Can't \"DeleteFileIfEquals\" {fileFullNameToDelete}, fileFullNameToDelete is not a file");

            if (dataToDelete.SequenceEqual(dataToCompare))
            {
                File.Delete(fileFullNameToDelete);
                return true;
            }
            else
                return false;
        }


        /// <summary>
        /// Delete file if data equals to other
        /// </summary>
        /// <param name="fileFullNameToDelete"></param>
        /// <param name="fileFullNameToCompare"></param>
        /// <returns>"true" if deleted, "false" if not</returns>
        /// <exception cref="Exception"></exception>
        public static bool DeleteFileIfEquals(string fileFullNameToDelete, string fileFullNameToCompare)
        {
            if (!IsFile(fileFullNameToCompare, true))
                throw new Exception($"Can't \"DeleteFileIfEquals\" {fileFullNameToCompare}, fileFullNameToCompare is not a file");

            var dataToDelete = File.ReadAllBytes(fileFullNameToDelete);
            var dataToCompare = File.ReadAllBytes(fileFullNameToCompare);

            return DeleteFileIfEquals(fileFullNameToDelete, dataToDelete, dataToCompare);
        }

        /// <summary>
        /// Delete file if data equals to other
        /// </summary>
        /// <param name="fileFullNameToDelete"></param>
        /// <param name="dataToCompare"></param>
        /// <returns>"true" if deleted, "false" if not</returns>
        /// <exception cref="Exception"></exception>
        public static bool DeleteFileIfEquals(string fileFullNameToDelete, byte[] dataToCompare)
        {
            var dataToDelete = File.ReadAllBytes(fileFullNameToDelete);

            return DeleteFileIfEquals(fileFullNameToDelete, dataToDelete, dataToCompare);
        }


    }
}
