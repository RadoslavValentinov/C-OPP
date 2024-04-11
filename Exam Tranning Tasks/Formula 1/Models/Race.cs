using System;
using System.Collections.Generic;
using System.Text;
using Formula1.Models.Contracts;

namespace Formula1.Models
{
    public class Race : IRace
    {
        private string _raceName;
        private int _numberOfLaps;
        private bool _tookPlace=false;
        private ICollection<IPilot> _pilots;

        public Race(string raceName, int numberOfLaps)
        {
            this.RaceName = raceName;
            this.NumberOfLaps = numberOfLaps;
            this._pilots = new List<IPilot>();
        }

        public string RaceName
        {
            get => _raceName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Invalid race name: {value}.");
                }
                _raceName = value;
            }
        }

        public int NumberOfLaps
        {
            get => _numberOfLaps;
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException($"Invalid lap numbers: {value}.");
                }

                _numberOfLaps = value;
            }
        }

        public bool TookPlace
        {
            get => _tookPlace;
            set => _tookPlace = value;
        }

        public ICollection<IPilot> Pilots => _pilots;

        public void AddPilot(IPilot pilot)
        {
           this._pilots.Add(pilot);
        }

        public string RaceInfo()
        {
            StringBuilder sv = new StringBuilder();
            sv.AppendLine($"The {this.RaceName} race has:");
            sv.AppendLine($"Participants: {this.Pilots.Count}");
            sv.AppendLine($"Number of laps: {this.NumberOfLaps}");
            var str = this.TookPlace == true ? "Yes" : "No";
            sv.AppendLine($"Took place: {str}");

            return sv.ToString().Trim();
        }
    }
}
