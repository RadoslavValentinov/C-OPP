namespace Robots
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RobotManager
    {
        private List<Robot> robots;
        private int capacity;

        public RobotManager(int capacity)//test
        {
            this.robots = new List<Robot>();
            this.Capacity = capacity;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid capacity!");//test
                }

                this.capacity = value;//test
            }
        }

        public int Count => this.robots.Count;//test

        public void Add(Robot robot)//test
        {
            if (this.robots.Any(r => r.Name == robot.Name))//test
            {
                throw new InvalidOperationException($"There is already a robot with name {robot.Name}!");
            }
            else if (this.robots.Count == this.capacity)
            {
                throw new InvalidOperationException("Not enough capacity!");//test
            }

            this.robots.Add(robot);
        }

        public void Remove(string name)//test
        {
            Robot robotToRemove = this.robots.FirstOrDefault(r => r.Name == name);

            if (robotToRemove == null)
            {
                throw new InvalidOperationException($"Robot with the name {name} doesn't exist!");
            }

            this.robots.Remove(robotToRemove);//test
        }

        public void Work(string robotName, string job, int batteryUsage)//test
        {
            Robot robot = this.robots.FirstOrDefault(r => r.Name == robotName);

            if (robot == null)
            {
                throw new InvalidOperationException($"Robot with the name {robotName} doesn't exist!");
            }
            else if (robot.Battery < batteryUsage)
            {
                throw new InvalidOperationException($"{robot.Name} doesn't have enough battery!");
            }

            robot.Battery -= batteryUsage;//test
        }

        public void Charge(string robotName)
        {
            Robot robot = this.robots.FirstOrDefault(r => r.Name == robotName);

            if (robot == null)
            {
                throw new InvalidOperationException($"Robot with the name {robotName} doesn't exist!");
            }

            robot.Battery = robot.MaximumBattery;
        }
    }
}
