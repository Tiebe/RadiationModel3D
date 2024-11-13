
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium113m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium113m";
        public override double halfLife { get; } = 0.51d;
        public override double atomicWeight { get; } = 112.92298d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    