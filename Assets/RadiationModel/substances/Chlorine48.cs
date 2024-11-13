
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine48 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine48";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 47.99541d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    