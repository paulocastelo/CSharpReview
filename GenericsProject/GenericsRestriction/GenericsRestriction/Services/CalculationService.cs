namespace GenericsRestriction.Services
{
    class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable {
            //List<int> is a specific type
            if (list.Count == 0)
            {
                throw new InvalidOperationException("The list can't be empty");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }

            return max;
        }
    }
}
