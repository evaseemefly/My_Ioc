using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTest
{
    public class AppEngine : IAppEngine
    {
        private readonly IGreeter _greeter;
        private readonly IOutput _outputDisplay;

        public AppEngine(IGreeter greeter,IOutput outputDisplay)
        {
            this._greeter = greeter;
            this._outputDisplay = outputDisplay;
        }

        public void Run()
        {
            _outputDisplay.Show(_greeter.GetGreeting());
        }
    }
}
