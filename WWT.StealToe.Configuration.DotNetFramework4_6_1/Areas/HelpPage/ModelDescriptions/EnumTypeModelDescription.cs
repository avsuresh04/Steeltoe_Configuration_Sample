using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WWT.StealToe.Configuration.DotNetFramework4_6_1.Areas.HelpPage.ModelDescriptions
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