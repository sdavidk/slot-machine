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
         * - PlaceBet(int numberOfPennies)
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

    }
}
