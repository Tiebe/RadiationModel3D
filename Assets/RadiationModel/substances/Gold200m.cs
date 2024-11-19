using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold200m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold200m";
        public override double halfLife { get; } = 67320.0d;
        public override double atomicWeight { get; } = 199.97184d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.84d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3270300.0), new Mercury200() } },
            { 0.16d, new List<RadioactiveSubstance> { new GammaParticle(0.00123, 1007000.0), new Gold200() } },

        };
    }
}
    
    