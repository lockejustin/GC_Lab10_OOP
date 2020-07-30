using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab10_MovieList_OOP
{
    class Movie
    {
        #region fields
        private string title;
        private string category;
        private int rtscore;
        private bool nicCage;
        #endregion

        #region properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public int RTScore
        {
            get { return rtscore; }
            set { rtscore = value; }
        }
        public bool NicCage
        {
            get { return nicCage; }
            set { nicCage = value; }
        }
        #endregion

        #region Constructors
        public Movie() { } //default constructor

        public Movie(string Title, string Category, int RTScore, bool NicCage)
        {
            title = Title;
            category = Category;
            rtscore = RTScore;
            nicCage = NicCage;
        }
        #endregion

        #region Methods

        #endregion
    }
}
