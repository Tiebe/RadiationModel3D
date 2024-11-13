
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium171";
        public override double halfLife { get; } = 4.07d;
        public override double atomicWeight { get; } = 170.94631d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Holmium171() } },

        };
    }
}
    
    