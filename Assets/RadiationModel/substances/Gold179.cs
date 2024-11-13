
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold179 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold179";
        public override double halfLife { get; } = 7.1d;
        public override double atomicWeight { get; } = 178.97317d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.78d, new List<RadioactiveSubstance> { new BetaParticle(), new Platinum179() } },

            { 0.22d, new List<RadioactiveSubstance> { new AlphaParticle(), new Iridium175() } },

        };
    }
}
    
    