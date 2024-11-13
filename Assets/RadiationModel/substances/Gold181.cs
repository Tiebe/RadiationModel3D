
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold181 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold181";
        public override double halfLife { get; } = 13.7d;
        public override double atomicWeight { get; } = 180.97008d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.973d, new List<RadioactiveSubstance> { new BetaParticle(), new Platinum181() } },

            { 0.027000000000000003d, new List<RadioactiveSubstance> { new AlphaParticle(), new Iridium177() } },

        };
    }
}
    
    