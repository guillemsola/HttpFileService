using FileService.Common.Domain;

namespace FileService.Common.Service
{
    public interface IFolderService
    {
        FolderEntry GetFolders(string folder);
    }
}
