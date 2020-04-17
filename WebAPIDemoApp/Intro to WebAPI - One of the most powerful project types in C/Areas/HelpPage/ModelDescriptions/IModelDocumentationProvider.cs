using System;
using System.Reflection;

namespace Intro_to_WebAPI___One_of_the_most_powerful_project_types_in_C.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}