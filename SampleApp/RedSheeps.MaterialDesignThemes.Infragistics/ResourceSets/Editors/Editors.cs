using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;
using Infragistics.Windows;
using Infragistics.Windows.Themes;

namespace RedSheeps.MaterialDesignThemes.Infragistics.ResourceSets.RoyalLight
{
    public class Editors : DataPresenterResourceSet<EditorsLocator>
    {
        private static DataPresenters g_Instance;
        public static DataPresenters Instance
        {
            get
            {
                if (g_Instance == null)
                    g_Instance = new DataPresenters();
                return g_Instance;
            }
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public class EditorsLocator : ResourceSetLocator
    {
        public override Assembly Assembly { get { return this.GetType().Assembly; } }
        public override string Theme { get { return "RoyalLight"; } }
        public override string Grouping { get { return DataPresenterGeneric.Instance.Grouping; } }
        public override string ResourcePath { get { return @"ResourceSets\Editors\EditorsRoyalLight.xaml"; } }
    }
}
