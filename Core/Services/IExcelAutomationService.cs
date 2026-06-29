// ==========================================
// Core/Interfaces/IExcelAutomationService.cs
// ==========================================

using Core.Models;

namespace Core.Interfaces;

public interface IExcelAutomationService
{
    Task ProcessWorkbookAsync(Job job);

    Task ApplyFormattingAsync(string workbookPath);

    Task GenerateChartsAsync(string workbookPath);

    Task<string> ExportPdfAsync(string workbookPath);
}