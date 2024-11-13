
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium192n : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium192n";
        public override double halfLife { get; } = 0.5d;
        public override double atomicWeight { get; } = 191.96638d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    