using System.Collections.Generic;
using System.Linq;
using Autodesk.Navisworks.Api;
using CoBuilder.Service.Interfaces.App;

namespace CoBuilder.Navisworks.Infrastructure
{
    public class NavisworksSelector : IAppSelector<ModelItem>
    {
        public IEnumerable<ModelItem> Selection { get; set; }

        public int SelectionCount => Selection.Count();

        public IEnumerable<ModelItem> All()
        {
            return Application.ActiveDocument.Models.RootItemDescendantsAndSelf;
        }

        IEnumerable<ModelItem> IAppSelector<ModelItem>.GetSelection()
        {
            Selection = Application.ActiveDocument.CurrentSelection.SelectedItems;
            return Selection;
        }
    }
}