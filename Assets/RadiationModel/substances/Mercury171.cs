using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury171 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury171";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 171.00359d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8685047.4), new Platinum167() } },

        };
    }
}
    
    