using System.ComponentModel;
using System.Reflection;
using Infragistics.Windows.Themes;

// ReSharper disable once CheckNamespace
namespace RedSheeps.Wpf.Infragistics.MaterialDesignThemes.ResourceSets.Indigo
{
    public class DataPresenter : DataPresenterResourceSet<Locator>
    {
        public static DataPresenter Instance { get; } = new DataPresenter();

        public DataPresenter()
        {

        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public class Locator : ResourceSetLocator
    {
        public override Assembly Assembly => this.GetType().Assembly;
        public override string Theme => "Indigo";
        public override string Grouping => DataPresenterGeneric.Instance.Grouping;
        public override string ResourcePath => @"ResourceSets\DataPresenter\DataPresenterRoyalLight.xaml";
    }
}