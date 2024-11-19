using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold183p : RadioactiveSubstance
    {
        public override string name { get; } = "Gold183p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 182.96784d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((231000.0, 0.00537)), new Gold183() } },

        };
    }
}
    
    