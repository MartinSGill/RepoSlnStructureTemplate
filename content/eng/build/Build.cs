using System.Collections.Generic;
using System.Linq;
using Nuke.Common;
using Nuke.Common.ProjectModel;
using Nuke.Components;

class Build : NukeBuild, IReportCoverage, IReportDuplicates
{
    [Solution]
    public Solution Solution;

    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode
    public static int Main() => Execute<Build>(x => ((ICompile)x).Compile);

    /// <inheritdoc />
    public IEnumerable<Project> TestProjects => Solution.AllProjects.Where(p => p.Name.EndsWith(".Tests")).ToList();

    /// <inheritdoc />
    public bool CreateCoverageHtmlReport { get; } = true;

    /// <inheritdoc />
    public bool ReportToCodecov { get; } = false;
}
