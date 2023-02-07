namespace OpenAndCloseBefore
{
    enum AnimalType
    {
        Dog,
        Cat,
        Fish
    }
    internal class Animal
    {
        public void Sound(AnimalType animalType) 
        {
            switch(animalType)
            {
                case AnimalType.Dog:
                    //Dog sound
                    break;
                case AnimalType.Cat:
                    //Cat sound
                    break;
                case AnimalType.Fish:
                    //Fish sound
                    break;
                default:
                    //ToDo
                    break;
            }
        }
    }
}
