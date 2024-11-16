using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium174";
        public override double halfLife { get; } = 0.24d;
        public override double atomicWeight { get; } = 173.96568d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    