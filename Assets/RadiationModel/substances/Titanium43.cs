
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium43 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium43";
        public override double halfLife { get; } = 0.509d;
        public override double atomicWeight { get; } = 42.96853d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Scandium43() } },

        };
    }
}
    
    