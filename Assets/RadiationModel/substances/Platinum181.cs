
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum181 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum181";
        public override double halfLife { get; } = 52.0d;
        public override double atomicWeight { get; } = 180.96309d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iridium181() } },

            { 0.00074d, new List<RadioactiveSubstance> { new AlphaParticle(), new Osmium177() } },

        };
    }
}
    
    