using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony140 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony140";
        public override double halfLife { get; } = 0.17d;
        public override double atomicWeight { get; } = 139.95235d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11977000.0), new Tellurium140() } },

        };
    }
}
    
    