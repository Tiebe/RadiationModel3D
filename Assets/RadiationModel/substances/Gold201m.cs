using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold201m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold201m";
        public override double halfLife { get; } = 0.00073d;
        public override double atomicWeight { get; } = 200.9723d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((594000.0, 0.00209)), new Gold201() } },

        };
    }
}
    
    