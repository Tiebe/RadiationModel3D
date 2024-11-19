using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum193m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum193m";
        public override double halfLife { get; } = 374112.0d;
        public override double atomicWeight { get; } = 192.96315d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00828, 149800.0), new Platinum193() } },

        };
    }
}
    
    