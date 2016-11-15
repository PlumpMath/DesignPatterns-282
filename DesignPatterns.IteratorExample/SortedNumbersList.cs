using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.IteratorExample
{
    public class SortedNumbersList : IEnumerable
    {
        public SortedNumbersListType OrderType { get; set; }

        List<int> _numbers;

        public SortedNumbersList(SortedNumbersListType orderType)
        {
            OrderType = orderType;
            _numbers = new List<int>();
        }

        public void Add(int number)
        {
            _numbers.Add(number);
        }

        public void Remove(int number)
        {
            _numbers.Remove(number);
        }

        public IEnumerator GetEnumerator()
        {
            switch (OrderType)
            {
                case SortedNumbersListType.Ascending:
                    return _numbers.OrderBy(x => x).GetEnumerator();
                case SortedNumbersListType.Descending:
                    return _numbers.OrderByDescending(x => x).GetEnumerator();
                default:
                    return _numbers.GetEnumerator();
            }

        }
    }
}