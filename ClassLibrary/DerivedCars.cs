using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ClassLibrary
{
    public class SportsCar : Car
    {
        public SportsCar() { }
        public SportsCar(string name, int maxSp, int currSp) : base(name, maxSp, currSp) { }

        public override void TurboBoost()
        {
            MessageBox.Show("Ramming Speed!", "Faster is better....");
        }
    }

    public class MiniVan : Car
    {
        public MiniVan() { }
        public MiniVan(string name, int maxSp, int currSp) : base(name, maxSp, currSp) { }

        public override void TurboBoost()
        {
            //Minivan has poor turbo capabilities
            egnState = EngineState.engineDead;
            MessageBox.Show("Eek!", "Your Engine Block Exploded");
        }
    }
}
