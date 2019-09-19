using Infragistics.Windows.Themes;

// ReSharper disable once CheckNamespace
namespace RedSheeps.Wpf.Infragistics.MaterialDesignThemes.ResourceSets.Indigo
{
    public class ThemesIndigoAssemblyResourceSetLoader : AssemblyResourceSetLoader
    {
        protected override void OnRegisterResourceSets(string groupingName)
        {
            if (groupingName == null)
            {
                //ThemesOrangePeelAssemblyResourceSetLoader.RegisterResourceSet(OrangePeel.Primitives.Instance);
                //ThemesOrangePeelAssemblyResourceSetLoader.RegisterResourceSet(OrangePeel.Editors.Instance);
                ThemesIndigoAssemblyResourceSetLoader.RegisterResourceSet(DataPresenter.Instance);
            }
            else
            {
                switch (groupingName)
                {
                    case "Primitives":
                        //ThemesOrangePeelAssemblyResourceSetLoader.RegisterResourceSet(OrangePeel.Primitives.Instance);
                        break;
                    case "DataPresenter":
                        ThemesIndigoAssemblyResourceSetLoader.RegisterResourceSet(DataPresenter.Instance);
                        break;
                    case "Editors":
                        //ThemesOrangePeelAssemblyResourceSetLoader.RegisterResourceSet(OrangePeel.Editors.Instance);
                        break;
                }
            }
        }
    }
}