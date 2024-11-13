
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium257m : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium257m";
        public override double halfLife { get; } = 0.27d;
        public override double atomicWeight { get; } = 257.09959d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    