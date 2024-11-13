
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium43 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium43";
        public override double halfLife { get; } = 0.0211d;
        public override double atomicWeight { get; } = 42.99789d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Vanadium43() } },

        };
    }
}
    
    