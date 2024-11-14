using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum116 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum116";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 115.957d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    