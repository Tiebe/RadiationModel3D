
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold183 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold183";
        public override double halfLife { get; } = 42.8d;
        public override double atomicWeight { get; } = 182.96759d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9945d, new List<RadioactiveSubstance> { new BetaParticle(), new Platinum183() } },

            { 0.0055000000000000005d, new List<RadioactiveSubstance> { new AlphaParticle(), new Iridium179() } },

        };
    }
}
    
    