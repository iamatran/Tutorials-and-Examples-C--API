using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Intro_to_WebAPI___One_of_the_most_powerful_project_types_in_C.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}