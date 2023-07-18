using StaticSharp;

namespace DefaultStaticSharpProjectTemplate.Root {
    public abstract class ProtoNode : MultilanguageProtoNode<Language> {
        protected ProtoNode(Language language) : base(language) {
        }
    }
}
