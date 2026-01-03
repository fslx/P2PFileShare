public class FileUpload
{
    public int Id { get; set; }
    public string FileName { get; set; } = string.Empty;
    public long FileSize { get; set; }
    /// <summary>
    /// Automatically set this server-side
    /// </summary>
    public Guid Guid { get; set; } = Guid.NewGuid();
}