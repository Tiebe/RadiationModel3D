
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten197 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten197";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 196.98404d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    