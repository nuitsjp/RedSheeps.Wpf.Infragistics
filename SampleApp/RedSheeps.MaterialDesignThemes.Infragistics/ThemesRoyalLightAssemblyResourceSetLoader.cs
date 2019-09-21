using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infragistics.Windows;
using Infragistics.Windows.Themes;

namespace RedSheeps.MaterialDesignThemes.Infragistics.ResourceSets.RoyalLight
{
    class ThemesRoyalLightAssemblyResourceSetLoader : AssemblyResourceSetLoader
    {
        protected override void OnRegisterResourceSets(string groupingName)
        {
            if (groupingName == null)
            {
                RegisterResourceSet(Primitives.Instance);
                RegisterResourceSet(Editors.Instance);
                RegisterResourceSet(DataPresenters.Instance);
            }
            else
            {
                switch (groupingName)
                {
                    case "Primitives":
                        RegisterResourceSet(Primitives.Instance);
                        break;
                    case "DataPresenters":
                        RegisterResourceSet(DataPresenters.Instance);
                        break;
                    case "Editors":
                        RegisterResourceSet(Editors.Instance);
                        break;
                }
            }
        }
    }

}
