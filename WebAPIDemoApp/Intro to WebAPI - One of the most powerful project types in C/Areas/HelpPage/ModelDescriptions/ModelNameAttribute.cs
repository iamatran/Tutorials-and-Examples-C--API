using System;

namespace Intro_to_WebAPI___One_of_the_most_powerful_project_types_in_C.Areas.HelpPage.ModelDescriptions
{
    /// <summary>
    /// Use this attribute to change the name of the <see cref="ModelDescription"/> generated for a type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, AllowMultiple = false, Inherited = false)]
    public sealed class ModelNameAttribute : Attribute
    {
        public ModelNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}