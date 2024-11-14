using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt57 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt57";
        public override double halfLife { get; } = 23484470.4d;
        public override double atomicWeight { get; } = 56.93629d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Iron57() } },

        };
    }
}
    
    