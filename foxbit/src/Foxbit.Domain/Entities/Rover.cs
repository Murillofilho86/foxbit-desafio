using Foxbit.Domain.Enums;

namespace Foxbit.Domain.Entities
{
    public class Rover : EntityBase
    {

        public Rover(int postionX, int postionY, Directions direction)
        {
            PositionX = postionX;
            PositionY = postionY;
            Direction = direction;
        }

        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public Directions Direction { get; private set; }


        public void Move(string movements)
        {
            foreach (var movement in movements)
            {
                switch (movement)
                {
                    case 'M':
                        MoveInSameDirection();
                        break;
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(movement), movement, null);

                }
            }


        }


        public void SpinLeft()
        {
            switch (Direction)
            {
                case Directions.NORTH:
                    Direction = Directions.WEST;
                    break;
                case Directions.SOUTH:
                    Direction = Directions.EAST;
                    break;
                case Directions.EAST:
                    Direction = Directions.NORTH;
                    break;
                case Directions.WEST:
                    Direction = Directions.SOUTH;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(); ;
            }
        }

        public void SpinRight()
        {
            switch (Direction)
            {
                case Directions.NORTH:
                    Direction = Directions.EAST;
                    break;
                case Directions.SOUTH:
                    Direction = Directions.WEST;
                    break;
                case Directions.EAST:
                    Direction = Directions.SOUTH;
                    break;
                case Directions.WEST:
                    Direction = Directions.NORTH;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(); ;
            }
        }

        public void MoveInSameDirection()
        {
            switch (Direction)
            {
                case Directions.NORTH:
                    PositionY += 1;
                    break;
                case Directions.SOUTH:
                    PositionY -= 1;
                    break;
                case Directions.EAST:
                    PositionX += 1;
                    break;
                case Directions.WEST:
                    if (PositionX - 1 >= 0) PositionX -= 1;
                    break;
                default:
                    break;
            }
        }
    }
}
