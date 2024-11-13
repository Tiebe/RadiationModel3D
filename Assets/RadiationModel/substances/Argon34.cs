
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon34 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon34";
        public override double halfLife { get; } = 0.84646d;
        public override double atomicWeight { get; } = 33.98027d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Chlorine34() } },

        };
    }
}
    
    