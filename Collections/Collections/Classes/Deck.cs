using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections.Classes
{
    //the deck will grow and shrink dynamically
    //Deck is the collection, similiar to MyContainer from Demo
    public class Deck<T> : IEnumerable<T>
    {
        public T[] carddeck = new T[13];
        int currentIndex = 0;
        
        /// <summary>
        /// Add a card to the deck
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if (currentIndex == carddeck.Length)
            {
                Array.Resize(ref carddeck, carddeck.Length * 2);
            }
            //add in items to the array
            carddeck[currentIndex] = item;
            //increment counter when card is added
            currentIndex++;
        }

        /// <summary>
        /// Remove a card from the deck
        /// </summary>
        /// <param name="item"></param>
        public T Remove(T item)
        {
            T deletedcard = default(T);

            for (int i = 0; i < currentIndex; i++)
            {
                if (carddeck[i].Equals(item))
                {
                    deletedcard = carddeck[i];
                    while (i < currentIndex - 1)
                    {
                        carddeck[i] = carddeck[i + 1];
                        i++;
                    }
                    carddeck[i] = default(T);

                    currentIndex--;
                    return deletedcard;
                }
            }
            throw new Exception("card does not exist in the deck");
        }

        /// <summary>
        /// Count the cards in the deck
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return currentIndex;
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                //return each item one by one
                yield return carddeck[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
