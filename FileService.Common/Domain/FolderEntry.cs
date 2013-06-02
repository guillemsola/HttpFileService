// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FolderEntry.cs" company="guillemsola">
//   Guillem Solà WTFPL
// </copyright>
// <summary>
//   Defines the FolderEntry type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FileService.Common.Domain
{
    using System.Collections.Generic;
using System.IO;

    /// <summary>
    /// Represents a folder entry.
    /// </summary>
    public class FolderEntry : Entry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderEntry"/> class.
        /// </summary>
        public FolderEntry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderEntry"/> class based on a path.
        /// </summary>
        /// <param name="path">
        /// The starting path.
        /// </param>
        public FolderEntry(string path)
            : base(path)
        {
        }

        /// <summary>
        /// Gets or sets the list of directories for a given path.
        /// </summary>
        public List<FolderEntry> Directories { get; set; }

        /// <summary>
        /// Gets or sets the list of files for a given path..
        /// </summary>
        public List<FileEntry> Files { get; set; }
    }
}
