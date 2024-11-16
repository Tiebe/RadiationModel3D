using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium178 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium178";
        public override double halfLife { get; } = 0.255d;
        public override double atomicWeight { get; } = 177.99505d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.62d, new List<RadioactiveSubstance> { new AlphaParticle(8045047.4), new Gold174() } },
            { 0.38d, new List<RadioactiveSubstance> { new BetaParticle(1, 11705000.0), new Mercury178() } },

        };
    }
}
    
    