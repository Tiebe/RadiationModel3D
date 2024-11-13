
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon134m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon134m";
        public override double halfLife { get; } = 0.29d;
        public override double atomicWeight { get; } = 133.9075d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Xenon134() } },

        };
    }
}
    
    