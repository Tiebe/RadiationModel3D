using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead207m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead207m";
        public override double halfLife { get; } = 0.806d;
        public override double atomicWeight { get; } = 206.97765d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00076, 1633400.0), new Lead207() } },

        };
    }
}
    
    