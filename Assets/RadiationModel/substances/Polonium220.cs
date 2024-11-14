using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium220 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium220";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 220.01639d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    