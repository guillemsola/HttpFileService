// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileEntry.cs" company="guillemsola">
//   Guillem Solà WTFPL
// </copyright>
// <summary>
//   Defines the FileEntry type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FileService.Common.Domain
{
    using System.IO;

    /// <summary>
    /// The file entry.
    /// </summary>
    public class FileEntry : Entry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileEntry"/> class.
        /// </summary>
        public FileEntry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileEntry"/> class.
        /// </summary>
        /// <param name="path">
        /// The path.
        /// </param>
        public FileEntry(string path) : base(path)
        {
            if (File.Exists(path))
            {
                this.Size = new FileInfo(path).Length;
            }
        }

        /// <summary>
        /// Gets file size.
        /// </summary>
        public long Size { get; private set; }

        /// <summary>
        /// Gets the file extension.
        /// </summary>
        public string Extension
        {
            get
            {
                var extension = Path.GetExtension(this.Name) ?? string.Empty;
                return extension.ToLower().Replace(".", string.Empty);
            }
        }
    }
}
