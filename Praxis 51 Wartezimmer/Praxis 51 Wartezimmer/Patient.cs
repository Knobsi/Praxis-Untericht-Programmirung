using System;
using System.Collections.Generic;
using System.Text;

namespace Praxis_51_Wartezimmer
{
    internal class Patient
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Patient(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return $"Patient = [name = {name}]";
        }

    }
}
