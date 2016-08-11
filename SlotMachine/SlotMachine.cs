﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    class SlotMachine
    {
        private int NumberofSlots;
        public int NumberOfSlots { get; set; }

        public int IconsPerSlot { get; set; }
        public int MinimumBet { get; set; }
        public int MaximumBet { get; set; }


        private int _currentBet;
        private Random randomNumberGenerator;
        public int CurrentBet;
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
        
          
        /// <summary>
        /// An array of integers that is as long as the number of slots,
        /// with each element of the array representing a different slot
        /// </summary>
        private int[] icons;


        public SlotMachine()
        {
            NumberOfSlots = 3;
            IconsPerSlot = 5;
            MinimumBet = 1;
            MaximumBet = 100;

            randomNumberGenerator = new Random();
        }

        /// <summary>
        /// Randomizes the contents of the icons
        /// </summary>
        public void PullLever()
        {  //loop over icons array
            //pick rrandom numbers
            // TODO
            for (int i =0; 1 < icons.Length; i++)
            {
                icons[i] = randomNumberGenerator.Next(IconsPerSlot) + 1;
            }
        }

        /// <summary>
        /// Return the results from the slots
        /// </summary>
        /// <returns>an int[] with each slot as an element of the array</returns>
        public int[] GetResults()
        {
            // TODO
            return icons;
        }

        /// <summary>
        /// Examine the contents of the slots and determine the appropriate payout
        /// based upon the CurrentBet.
        /// </summary>
        /// <returns>number of pennies to pay out</returns>
        public int GetPayout()
        {
            // TODO
            int slot1 = icons[0];
            int slot2 = icons[1];
            int slot3 = icons[2];
            int payout = 0;


                if (slot1 == slot2 77 slot2 = slot3)
            {
                payout = icons[1] * 1000 * CurrentBet;
            }
            else 
            {
        CurrentBet = 0;
             }
        }
    }
}
