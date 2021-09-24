namespace Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; } = false;
        public int CurrentChannel { get; private set; } = 3;
        public int CurrentVolume { get; private set; } = 2;

        public void TurnOff()
        {
            IsOn = false;
        }
        public void TurnOn()
        {
            IsOn = true;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }
        public void ChangeChannel(int newChannel)
        {
            if (IsOn == true)
            {
                if (3<=newChannel && newChannel <= 18)
                {
                    CurrentChannel = newChannel;
                }
            }
        }
        public void ChannelUp()
        {
            if (IsOn == true)
            {
                CurrentChannel += 1;
                if (CurrentChannel > 18)
                {
                    CurrentChannel = 3;
                }
            }
        }
        public void ChannelDown()
        {
            if (IsOn == true)
            {
                CurrentChannel -= 1;
                if (CurrentChannel < 3)
                {
                    CurrentChannel = 18;
                }
            }
        }
        public void RaiseVolume()
        {
            if (IsOn == true)
            {
                CurrentVolume += 1;
                if (CurrentVolume > 10)
                {
                    CurrentVolume = 10;
                }
            }
        }
        public void LowerVolume()
        {
            if (IsOn == true)
            {
                CurrentVolume -= 1;
                if (CurrentVolume < 0)
                {
                    CurrentVolume = 0;
                }
            }
        }
    }
}
