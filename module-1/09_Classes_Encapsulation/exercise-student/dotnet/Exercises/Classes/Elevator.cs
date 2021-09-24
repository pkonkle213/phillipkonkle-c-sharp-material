namespace Exercises.Classes
{
    public class Elevator
    {
        public Elevator(int numberOfLevels)
        {
            this.NumberOfLevels = numberOfLevels;
        }

        public int CurrentLevel { get; private set; } = 1;
        
        public int NumberOfLevels { get; private set; }
        
        public bool DoorIsOpen { get; private set; }

        public void OpenDoor()
        {
            DoorIsOpen = true;
        }
        
        public void CloseDoor()
        {
            DoorIsOpen = false;
        }
        
        public void GoUp(int desiredFloor)
        {
            if (!DoorIsOpen && (CurrentLevel < desiredFloor && desiredFloor <= NumberOfLevels))
            {
                CurrentLevel = desiredFloor;
            }

        }
        
        public void GoDown(int desiredFloor)
        {
            if (!DoorIsOpen && (CurrentLevel > desiredFloor && desiredFloor >= 1))
            {
                CurrentLevel = desiredFloor;
            }
        }
    }
}
