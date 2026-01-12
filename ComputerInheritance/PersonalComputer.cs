using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerInheritance
{
    public class PersonalComputer : Computer
    {
        public PersonalComputer(string model, string cpu) : base("Personal Computer", model, cpu)
        {

        }

        public override string getComputerCPU()
        {
            return cpu;
        }

        public override string getComputerType()
        {
            return type;
        }

        public override string getModel()
        {
            return model;
        }

        public override bool isComputerStatus()
        {
            return isTurnedOn;
        }

        public override void SwitchComputerStatus()
        {
            isTurnedOn = !isTurnedOn;
        }
    }
}
