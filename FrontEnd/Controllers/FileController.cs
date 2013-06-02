// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileController.cs" company="guillemsola">
//   Guillem Solà WTFPL
// </copyright>
// <summary>
//   The file controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FrontEnd.Controllers
{
    using System.Web.Mvc;
    using System.IO;

    /// <summary>
    /// The file controller.
    /// </summary>
    public class FileController : Controller
    {
        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="file">
        /// The file.
        /// </param>
        /// <returns>
        /// The <see cref="FileResult"/>.
        /// </returns>
        public FilePathResult Get(string file)
        {
            //return new FilePathResult(file, "application/octet-stream", "name.bin");
            return this.File(file, "application/octet-stream", Path.GetFileName(file));
        }

    }
}
