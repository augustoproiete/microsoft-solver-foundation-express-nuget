#tool "nuget:?package=NuGet.CommandLine&version=6.0.0"

#addin "nuget:?package=Cake.MinVer&version=2.0.0"
#addin "nuget:?package=Cake.Args&version=2.0.0"

var target       = ArgumentOrDefault<string>("target") ?? "pack";
var buildVersion = MinVer(s => s.WithTagPrefix("v").WithDefaultPreReleasePhase("preview"));

Task("clean")
    .Does(() =>
{
    CleanDirectories("./artifact/**");
});

Task("pack")
    .IsDependentOn("clean")
    .Does(() =>
{
    NuGetPack("./src/nuspec/Unofficial.Microsoft.Solver.Foundation.Express.nuspec", new NuGetPackSettings
    {
        Version = buildVersion.PackageVersion,
        OutputDirectory = "./artifact/nuget",
    });
});

Task("push")
    .IsDependentOn("pack")
    .Does(context =>
{
    var url =  context.EnvironmentVariable("NUGET_URL");
    if (string.IsNullOrWhiteSpace(url))
    {
        context.Information("No NuGet URL specified. Skipping publishing of NuGet packages");
        return;
    }

    var apiKey =  context.EnvironmentVariable("NUGET_API_KEY");
    if (string.IsNullOrWhiteSpace(apiKey))
    {
        context.Information("No NuGet API key specified. Skipping publishing of NuGet packages");
        return;
    }

    var nugetPushSettings = new DotNetNuGetPushSettings
    {
        Source = url,
        ApiKey = apiKey,
    };

    foreach (var nugetPackageFile in GetFiles("./artifact/nuget/*.nupkg"))
    {
        DotNetNuGetPush(nugetPackageFile.FullPath, nugetPushSettings);
    }
});

RunTarget(target);
