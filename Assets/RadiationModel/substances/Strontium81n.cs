
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium81n : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium81n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 80.92331d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    