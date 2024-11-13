
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium197 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium197";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 196.97815d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    