namespace Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// swaps list elements at indexes <paramref name="firstIndex"/> and <paramref name="secondIndex"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="l"></param>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        public static void SwapElements<T>(this List<T> l, int firstIndex, int secondIndex)
        {
            T t = l[firstIndex];
            l[firstIndex] = l[secondIndex];
            l[secondIndex] = t;
        }

        /// <summary>
        /// moves list element from <paramref name="oldIndex"/> to <paramref name="newIndex"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="l"></param>
        /// <param name="oldIndex"></param>
        /// <param name="newIndex"></param>
        public static void MoveElement<T>(this List<T> l, int oldIndex, int newIndex)
        {
            T t = l[oldIndex];
            l.Remove(t);
            l.Insert(newIndex, t);
        }

        /// <summary>
        /// move subset of elements of <paramref name="list"/> in front of the element of the same list with the index <paramref name="index"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="listSubset"></param>
        /// <param name="index"></param>
        public static void MoveElements<T>(this List<T> list, List<T> listSubset, int index)
        {
            int currentIndex = index;
            T t = list[index];
            for (int i = 0; i < listSubset.Count; i++)
            {
                int sIndex = list.IndexOf(listSubset[i]);             
                    
                if (sIndex < currentIndex) currentIndex--;
                list.MoveElement(sIndex, currentIndex);
                currentIndex = list.IndexOf(t);

            }

        }



    }
}
