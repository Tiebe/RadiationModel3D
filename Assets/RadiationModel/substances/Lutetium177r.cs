using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium177r : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium177r";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 176.94755d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00035), new Lutetium177() } },

        };
    }
}
    
    