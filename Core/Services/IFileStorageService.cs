// =====================================
// Core/Interfaces/IFileStorageService.cs
// =====================================

namespace Core.Interfaces;

public interface IFileStorageService
{
    Task<string> SaveFileAsync(string sourcePath);

    Task<byte[]> GetFileAsync(string filePath);

    Task DeleteFileAsync(string filePath);

    Task<string> MoveFileAsync(string sourcePath, string destinationPath);
}