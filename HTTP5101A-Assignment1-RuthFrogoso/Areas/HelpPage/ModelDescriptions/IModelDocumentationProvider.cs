using System;
using System.Reflection;

namespace HTTP5101A_Assignment1_RuthFrogoso.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}