
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium151";
        public override double halfLife { get; } = 35.2d;
        public override double atomicWeight { get; } = 150.9317d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.88d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium151() } },

            { 0.22d, new List<RadioactiveSubstance> { new AlphaParticle(), new Terbium147() } },

        };
    }
}
    
    