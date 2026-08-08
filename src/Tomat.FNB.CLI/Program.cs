using System.Threading.Tasks;

using CliFx;

namespace Tomat.FNB.CLI;

internal static class Program
{
    public static async Task<int> Main(string[] args)
    {
        return await new CliApplicationBuilder()
                    .SetExecutableName("fnb")
                    .SetTitle("fnb")
                    .SetDescription(
                         "tmod & xnb file packer and unpacker"
                       + "\nCopyright (C) 2026  tomat et al."
                     )
                    .AddCommandsFromThisAssembly()
                    .Build()
                    .RunAsync(args);
    }
}