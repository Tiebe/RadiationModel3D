
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury188 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury188";
        public override double halfLife { get; } = 195.0d;
        public override double atomicWeight { get; } = 187.96758d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gold188() } },

            { 3.7e-07d, new List<RadioactiveSubstance> { new AlphaParticle(), new Platinum184() } },

        };
    }
}
    
    