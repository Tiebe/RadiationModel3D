using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium85m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium85m";
        public override double halfLife { get; } = 3.3d;
        public override double atomicWeight { get; } = 84.92901d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    