using AppRazorTrainingSite.Options;

namespace AppRazorTrainingSite.Services;

public class PathService
{
    private readonly IConfiguration configuration;
    private readonly IWebHostEnvironment env;

    public PathService(IConfiguration configuration,IWebHostEnvironment env)
    {
        this.configuration = configuration;
        this.env = env;
    }

    public string GetUploadsPath(string? filename = null,bool withWebRootPath = true)
    {
        var pathOptions = new PathOption();

        configuration.GetSection(PathOption.Path).Bind(pathOptions);

        var uploadPath = pathOptions.FruitsImages;

        if(null != filename)
            uploadPath= Path.Combine(uploadPath, filename);

        return withWebRootPath == true ? Path.Combine(env.WebRootPath, uploadPath) : uploadPath;
    }
}
