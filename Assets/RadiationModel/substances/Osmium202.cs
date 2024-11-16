using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium202 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium202";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 201.98655d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    