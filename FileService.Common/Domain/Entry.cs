// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Entry.cs" company="guillemsola">
//   Guillem Solà WTFPL
// </copyright>
// <summary>
//   Defines the FolderEntry type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FileService.Common.Domain
{
    using System.IO;

    /// <summary>
    /// Represents a common entry.
    /// </summary>
    public abstract class Entry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Entry"/> class.
        /// </summary>
        protected Entry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Entry"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        protected Entry(string name)
        {
            this.FullPath = name;
            this.BasePath = Path.GetDirectoryName(name);
            this.Name = Path.GetFileName(name);
        }

        /// <summary>
        /// Gets or sets the current base path.
        /// </summary>
        public string BasePath { get; set; }

        /// <summary>
        /// Gets or sets the full path.
        /// </summary>
        public string FullPath { get; set; }

        /// <summary>
        /// Gets or sets the display name for an entry.
        /// </summary>
        public string Name { get; set; }
    }
}
