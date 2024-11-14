using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum163m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum163m";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 162.95448d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    