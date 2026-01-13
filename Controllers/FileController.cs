using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[api]")]
public class FileController : ControllerBase
{

    private List<FileUpload> files = new List<FileUpload>()
    {
        new FileUpload {Id = 1, FileName = "Example.txt", FileSize = 0, Guid = Guid.NewGuid()}
    };

    [HttpGet]
    public IActionResult GetFiles()
    {
        return Ok(files);
    }

    [HttpPost]
    public IActionResult Post([FromBody] FileUpload upload)
    {
        var file = new
        {
            upload.Id,
            upload.FileName,
            upload.FileSize,
            upload.Guid
        };
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        return Ok(file);
    }
}