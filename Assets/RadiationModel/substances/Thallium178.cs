
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

            { 0.62d, new List<RadioactiveSubstance> { new AlphaParticle(), new Gold174() } },

            { 0.38d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury178() } },

        };
    }
}
    
    