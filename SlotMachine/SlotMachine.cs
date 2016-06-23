using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    class SlotMachine
    {
        /*
         * Classes We Make:
         * SlotMachine
         * Properties:
         * - NumberOfSlots
         * - IconsPerSlot
         * - MinimumBet
         * - MaximumBet
         * - CurrentBet
         * Methods:
         * - PullLever()
         * - DisplayResults()
         * - GetPayout()
         */

        public int NumberOfSlots { get; set; }
        public int IconsPerSlot { get; set; }
        public int MinimumBet { get; set; }
        public int MaximumBet { get; set; }

        private int _currentBet;
        public int CurrentBet
        {
            get
            {
                return _currentBet;
            }
            set
            {
                _currentBet = value;
                if (_currentBet < MinimumBet)
                {
                    _currentBet = MinimumBet;
                }
                if (_currentBet > MaximumBet)
                {
                    _currentBet = MaximumBet;
                }
            }
        }

        /// <summary>
        /// An array of integers that is as long as the number of slots,
        /// with each element of the array representing a different slot
        /// </summary>
        private int[] icons;

        /// <summary>
        /// Randomizes the contents of the icons
        /// </summary>
        public void PullLever()
        {
            // TODO
        }

        /// <summary>
        /// Return the results from the slots
        /// </summary>
        /// <returns>an int[] with each slot as an element of the array</returns>
        public int[] GetResults()
        {
            // TODO
            return null;
        }

        /// <summary>
        /// Examine the contents of the slots and determine the appropriate payout
        /// based upon the CurrentBet.
        /// </summary>
        /// <returns>number of pennies to pay out</returns>
        public int GetPayout()
        {
            // TODO
            return 0;
        }



    }
}
