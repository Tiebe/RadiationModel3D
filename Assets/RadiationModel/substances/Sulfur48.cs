
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur48 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur48";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 48.0133d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    