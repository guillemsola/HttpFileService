// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoldersController.cs" company="guillem sola">
//   Copyright (c) Guillem Solà. All rights reserved.
// </copyright>
// <summary>
//   The folders controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FrontEnd.Controllers
{
    using System.Collections.Generic;
    using System.Web;
    using System.Web.Http;
    using System.Web.Http.ModelBinding;

    using FileService.Common.Domain;
    using FileService.Common.Service;

    /// <summary>
    /// The folders controller.
    /// </summary>
    public class FoldersController : ApiController
    {
        /// <summary>
        /// The folder service.
        /// </summary>
        private readonly IFolderService folderService;

        /// <summary>
        /// Initializes a new instance of the <see cref="FoldersController"/> class.
        /// </summary>
        public FoldersController()
        {
            // TODO use DI
            this.folderService = new FolderService();
        }

        /// <summary>
        /// Get all items for the default base path.
        /// </summary>
        /// <returns>
        /// An <see cref="FolderEntry"/> for the default path.
        /// </returns>
        public FolderEntry Get()
        {
            // return this.Get(ConfigurationManager.AppSettings["BaseFolder"]);
            return this.Get(HttpContext.Current.Server.MapPath(@"~"));
        }

        /// <summary>
        /// Get all items for a given folder.
        /// </summary>
        /// <param name="path">
        /// Path to get.
        /// </param>
        /// <returns>
        /// The <see cref="FolderEntry"/>.
        /// </returns>
        public FolderEntry Get(string path)
        {
            return this.folderService.GetFolders(path);
        
        }
    }
}
