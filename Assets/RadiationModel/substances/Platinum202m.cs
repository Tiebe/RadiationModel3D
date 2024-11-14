using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum202m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum202m";
        public override double halfLife { get; } = 0.00014d;
        public override double atomicWeight { get; } = 201.97756d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00069), new Platinum202() } },

        };
    }
}
    
    