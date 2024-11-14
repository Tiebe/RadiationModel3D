using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold180 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold180";
        public override double halfLife { get; } = 7.9d;
        public override double atomicWeight { get; } = 179.97249d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9942d, new List<RadioactiveSubstance> { new BetaParticle(1, 8804000.0), new Platinum180() } },
            { 0.0058d, new List<RadioactiveSubstance> { new AlphaParticle(6851047.4), new Iridium176() } },

        };
    }
}
    
    