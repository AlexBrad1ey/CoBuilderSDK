using System.Collections.Generic;

namespace CoBuilder.Service.Interfaces.App
{
    public interface IAppSelector<TElement>
    {
        IEnumerable<TElement> Selection { get; set; }
        int SelectionCount { get; }
        IEnumerable<TElement> GetSelection();
        IEnumerable<TElement> All();
    }
}