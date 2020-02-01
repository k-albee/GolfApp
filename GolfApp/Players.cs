using System;
using System.Collections.Generic;
using System.Text;

namespace GolfApp
{
    class Players
    {/// <summary>
    /// This class is a Players profile
    /// </summary>
        #region Properties
        public string PlayerName { get; set; }
        public string Nickname { get; set; }
        public string EmailAddress { get; set; }
        public int Holes { get; private set; }
        public int Score { get; private set; }
        public int Fairways { get; private set; }
        public int Putts { get; private set; }
        #endregion

        #region Methods
        /// <summary>
        /// Records the number of holes played
        /// </summary>
        /// <param name="holes">Holes played in a round</param>
        /// <returns>Total holes played</returns>
        public int PlayedGolf(int holes)
        {
            Holes += holes;
            return Holes;
        }
        /// <summary>
        /// Records the score of holes played
        /// </summary>
        /// <param name="score">Total score for a round</param>
        /// <returns>Total score for all rounds played</returns>
        public int ScoredGolf (int score)
        {
            Score += score;
            return Score;
        }
        /// <summary>
        /// Records the number of fairways hit for a round from the tee
        /// </summary>
        /// <param name="fairways">Total fairways hit for a round</param>
        /// <returns>Total fairways hit for all rounds played</returns>
        public int HitFairways (int fairways)
        {
            Fairways += fairways;
            return Fairways;
        }
        /// <summary>
        /// Records the number of putts hit for a round
        /// </summary>
        /// <param name="putts">Total putts hit for a round</param>
        /// <returns>Total putts hit for all rounds played</returns>
        public int HitPutts (int putts)
        {
            Putts += putts;
            return Putts;
        }
        #endregion
    }
}
