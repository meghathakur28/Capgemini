using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerInheritance
{
    public abstract class Computer
    {
        protected string type;
        protected string model;
        protected string cpu;
        protected bool isTurnedOn = false;
        public Computer(string type, string model, string cpu)
        {
            this.type = type;
            this.model = model;
            this.cpu = cpu;
        }
        public abstract string getComputerType();
        public abstract string getModel();
        public abstract string getComputerCPU();
        public abstract bool isComputerStatus();
        public abstract void SwitchComputerStatus();

    }
}
