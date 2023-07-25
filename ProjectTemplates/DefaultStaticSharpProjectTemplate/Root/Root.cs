namespace DefaultStaticSharpProjectTemplate.Root {

    public partial class Root : PageBase {
        public override string Title => "DefaultStaticSharpProjectTemplate - Home page";

        public override Inlines? Description => "Home page of StaticSharp sample project";

        public override Blocks Content => new() {
            """
            Text text text text text text text text text text text text text
            text text text text text text text text text text text text text.
            """
        };
    }
}
