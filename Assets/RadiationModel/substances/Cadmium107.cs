
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium107";
        public override double halfLife { get; } = 23400.0d;
        public override double atomicWeight { get; } = 106.90661d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver107() } },

        };
    }
}
    
    