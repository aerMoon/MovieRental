using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental
{
    /// <summary>
    /// Класс, который предоставляет данные о фильме.
    /// </summary>
    internal class Movie
    {
        // Поля

        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;
        public const int CHILDRENS = 2;

        private string title = null;
        private int priceCode = 0;

        // Методы

        public Movie(string title, int priceCode)
        {
            this.title = title;
            this.priceCode = priceCode;
        }

        // Свойства

        public int PriceCode
        {
            get { return this.priceCode; }
            set { this.priceCode = value; }
        }

        public string Title
        {
            get { return this.title; }
        }
    }
}
