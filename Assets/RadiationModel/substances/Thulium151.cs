
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium151";
        public override double halfLife { get; } = 4.17d;
        public override double atomicWeight { get; } = 150.94549d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Erbium151() } },

        };
    }
}
    
    