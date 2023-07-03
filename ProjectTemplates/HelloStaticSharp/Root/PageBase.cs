using StaticSharp;
using StaticSharp.Gears;

namespace HelloStaticSharp.Root
{
    /// <summary>
    /// Base page for a site. Can be used to define common layout patterns, styles and metadata.
    /// This page is useful but not mandatory, it is possible to inherit pages directly from StaticSharp.Page
    /// </summary>
    public abstract partial class PageBase : Page
    {
        public override string? SiteName => "HelloStaticSharp";

        /// <summary>
        /// Language for <html lang="...">
        /// Could be defined once per whole site in a base page, if your site supports single language,
        /// or it could be overriden per page to match particular page language
        /// </summary>
        public override string PageLanguage => "en-us";

        public override Genome<IAsset>? Favicon => Static.LoadFile("FavIcon.svg");

        public override Block? MainVisual => new Image("LogoHorizontal.png");

        /// <summary>
        /// Most basic and abstract content property. 
        /// It can be used to construct common page layout out of more granular custom parts like 
        /// Content, Header, Footer, Menu, etc, which are declared as abstract in a base page 
        /// and defined in exact pages
        /// </summary>
        public override Blocks UnmanagedChildren => new() 
        { 
            new LinearLayout {
                Children = {
                    new Paragraph(Title)
                    {
                        FontSize = 24
                    },
                    Content
                }
            }
        };

        public abstract Blocks Content {get;}
    }
}
