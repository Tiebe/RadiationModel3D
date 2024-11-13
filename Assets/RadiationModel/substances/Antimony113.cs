
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony113 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony113";
        public override double halfLife { get; } = 400.2d;
        public override double atomicWeight { get; } = 112.90937d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin113() } },

        };
    }
}
    
    