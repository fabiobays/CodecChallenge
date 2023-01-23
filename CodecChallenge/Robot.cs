using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodecChallenge
{
    public class Robot
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public string Facing { get; private set; }

        public Robot()
        {
            this.X = 1;
            this.Y = 1;
            this.Facing = "North";
        }

        public void Move(string commands, Plateau plateau)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'F':
                        if (MoveForward(plateau))
                        {
                            break;
                        }  
                        //Do nothing is movement is not valid
                        break;
                    default:
                        //Do nothing for invalid commands
                        break;
                }
            }
        }

        private void TurnLeft()
        {
            switch (Facing)
            {
                case "North":
                    Facing = "West";
                    break;
                case "West":
                    Facing = "South";
                    break;
                case "South":
                    Facing = "East";
                    break;
                case "East":
                    Facing = "North";
                    break;
            }
        }

        private void TurnRight()
        {
            switch (Facing)
            {
                case "North":
                    Facing = "East";
                    break;
                case "East":
                    Facing = "South";
                    break;
                case "South":
                    Facing = "West";
                    break;
                case "West":
                    Facing = "North";
                    break;
            }
        }

        private bool MoveForward(Plateau plateau)
        {
            int x = this.X;
            int y = this.Y;

            switch (Facing)
            {
                case "North":
                    y += 1;
                    break;
                case "East":
                    x += 1;
                    break;
                case "South":
                    y -= 1;
                    break;
                case "West":
                    x -= 1;
                    break;
            }

            if (plateau.IsValidMove(x, y))
            {
                this.X = x;
                this.Y = y;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
