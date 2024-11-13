
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium234m : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium234m";
        public override double halfLife { get; } = 69.54d;
        public override double atomicWeight { get; } = 234.04339d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Uranium234() } },

            { 0.0016d, new List<RadioactiveSubstance> { new GammaParticle(), new Protactinium234() } },

        };
    }
}
    
    