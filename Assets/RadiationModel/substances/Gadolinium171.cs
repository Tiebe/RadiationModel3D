using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium171";
        public override double halfLife { get; } = 0.3d;
        public override double atomicWeight { get; } = 170.96113d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    