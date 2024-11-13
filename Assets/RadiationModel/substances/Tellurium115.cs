
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium115";
        public override double halfLife { get; } = 348.0d;
        public override double atomicWeight { get; } = 114.9119d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Antimony115() } },

        };
    }
}
    
    