using System.Collections.Generic;

namespace DesignPatterns.CompositeExample
{
    public class CompositeLayout : ILayoutElement
    {
        List<ILayoutElement> _layoutElements;

        public CompositeLayout()
        {
            _layoutElements = new List<ILayoutElement>();
        }

        public void Add(ILayoutElement element)
        {
            _layoutElements.Add(element);
        }

        public void Remove(ILayoutElement element)
        {
            _layoutElements.Remove(element);
        }

        public void Draw()
        {
            foreach (var element in _layoutElements)
            {
                element.Draw();
            }
        }
    }
}
