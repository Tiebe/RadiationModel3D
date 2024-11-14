using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium237";
        public override double halfLife { get; } = 600.0d;
        public override double atomicWeight { get; } = 237.05287d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    