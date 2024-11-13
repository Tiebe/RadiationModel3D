
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury185 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury185";
        public override double halfLife { get; } = 49.1d;
        public override double atomicWeight { get; } = 184.97189d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.94d, new List<RadioactiveSubstance> { new BetaParticle(), new Gold185() } },

            { 0.06d, new List<RadioactiveSubstance> { new AlphaParticle(), new Platinum181() } },

        };
    }
}
    
    