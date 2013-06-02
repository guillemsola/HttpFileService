// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FolderService.cs" company="guillemsola">
//   Guillem Sola WTFPL.
// </copyright>
// <summary>
//   The folder service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FileService.Common.Service
{
    using System.IO;
    using System.Linq;

    using FileService.Common.Domain;

    /// <summary>
    /// The folder service.
    /// </summary>
    public class FolderService : IFolderService
    {
        /// <summary>
        /// The get folders.
        /// </summary>
        /// <param name="folder">
        /// The folder.
        /// </param>
        /// <returns>
        /// The <see cref="FolderEntry"/>.
        /// </returns>
        public FolderEntry GetFolders(string folder)
        {
            var folderContent = new FolderEntry(folder);
            folderContent.Directories =
                Directory.GetDirectories(folder).Select(entry => new FolderEntry(entry)).ToList();
            if (!string.IsNullOrEmpty(folderContent.BasePath))
            {
                var backFolder = new FolderEntry(folderContent.BasePath) { Name = ".." };
                folderContent.Directories.Insert(0, backFolder);
            }

            folderContent.Files = Directory.GetFiles(folder).Select(entry => new FileEntry(entry)).ToList();

            return folderContent;
        }
    }
}
