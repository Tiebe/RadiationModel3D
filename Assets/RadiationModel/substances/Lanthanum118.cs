using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum118 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum118";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 117.94673d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    