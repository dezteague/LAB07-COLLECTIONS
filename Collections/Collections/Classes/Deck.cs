using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    //the deck will grow and shrink dynamically
    //Deck is the collection, similiar to MyContainer from Demo
    public class Deck<T> : IEnumerable<T>
    {
        T[] cards = new T[10];
        int currentIndex = 0;

        public void Add(T item)
        {
            if (currentIndex > cards.Length -1)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }
            //add in items to the array
            cards[currentIndex] = item;
            currentIndex++;
        }

        
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                //return each item one by one
                yield return cards[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
