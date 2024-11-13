
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin139 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin139";
        public override double halfLife { get; } = 0.12d;
        public override double atomicWeight { get; } = 138.9578d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Antimony139() } },

        };
    }
}
    
    