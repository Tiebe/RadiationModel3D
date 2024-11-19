using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron53m : RadioactiveSubstance
    {
        public override string name { get; } = "Iron53m";
        public override double halfLife { get; } = 152.4d;
        public override double atomicWeight { get; } = 52.94857d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((3040400.0, 0.00041)), new Iron53() } },

        };
    }
}
    
    