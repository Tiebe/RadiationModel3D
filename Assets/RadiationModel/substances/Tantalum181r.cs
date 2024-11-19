using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum181r : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum181r";
        public override double halfLife { get; } = 0.00021d;
        public override double atomicWeight { get; } = 180.95039d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00056, 2227900.0), new Tantalum181() } },

        };
    }
}
    
    