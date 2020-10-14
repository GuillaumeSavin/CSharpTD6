using System;

namespace Exo1
{
    public class EventTempMachine : EventArgs
    {
        private int _oldTemp, _newTemp;

        public EventTempMachine(int pOldTemp, int pNewValue)
        {
            this._oldTemp = pOldTemp;
            this._newTemp = pNewValue;
        }
        
        public int _OldTemp
        {
            get => _oldTemp;
            set => _oldTemp = value;
        }

        public int _NewTemp
        {
            get => _newTemp;
            set => _newTemp = value;
        }
    }
}