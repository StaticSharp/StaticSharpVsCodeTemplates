using StaticSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloStaticSharp.Root
{
    public abstract class ProtoNode : MultilanguageProtoNode<Language>
    {
        protected ProtoNode(Language language) : base(language)
        {
        }
    }
}
