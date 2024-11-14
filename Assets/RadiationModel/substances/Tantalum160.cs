using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum160 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum160";
        public override double halfLife { get; } = 1.7d;
        public override double atomicWeight { get; } = 159.96155d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    