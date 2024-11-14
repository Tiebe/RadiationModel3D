using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium40 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium40";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 40.05319d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    