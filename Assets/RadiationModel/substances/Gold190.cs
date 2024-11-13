
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold190 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold190";
        public override double halfLife { get; } = 2568.0d;
        public override double atomicWeight { get; } = 189.96475d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Platinum190() } },

            { 1e-08d, new List<RadioactiveSubstance> { new AlphaParticle(), new Iridium186() } },

        };
    }
}
    
    