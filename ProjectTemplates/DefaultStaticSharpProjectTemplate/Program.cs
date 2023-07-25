using DefaultStaticSharpProjectTemplate.Root;

namespace DefaultStaticSharpProjectTemplate {

    internal class Program : StaticSharp.Program {

        private static Task Main() => RunEntryPointFromEnvironmentVariable<Program>();

        public static async Task Server() {
            Cache.Directory = Configuration.GetVariable("cachePath", MakeAbsolutePath(".cache"));

            await new Server(
                new DefaultMultilanguagePageFinder<Language>((language) => new αRoot(language)),
                new DefaultMultilanguageNodeToPath<Language>()
                ).RunAsync();
        }

        public static async Task Generator() {
            var targetHostName = Configuration.GetVariable("targetHostName");
            Cache.Directory = Configuration.GetVariable("cachePath", MakeAbsolutePath(".cache"));

            var outputDirectory = Configuration.GetVariable("outputDirectory");
            if (!Path.IsPathFullyQualified(outputDirectory)) {
                outputDirectory = Path.GetFullPath(Path.Combine(GetThisFileDirectory(), outputDirectory));
            }

            Directory.CreateDirectory(outputDirectory);

            var generator = new MultilanguageStaticGenerator<Language>(
                new DefaultMultilanguageNodeToPath<Language>(),
                new AbsoluteUrl("http", targetHostName),
                FilePath.FromOsPath(outputDirectory)
                );

            await generator.GenerateAsync(new αRoot(default));
        }
    }
}