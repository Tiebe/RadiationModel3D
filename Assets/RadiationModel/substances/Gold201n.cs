using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold201n : RadioactiveSubstance
    {
        public override string name { get; } = "Gold201n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 200.97339d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00077), new Gold201() } },

        };
    }
}
    
    