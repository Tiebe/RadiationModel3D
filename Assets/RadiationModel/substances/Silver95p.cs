using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver95p : RadioactiveSubstance
    {
        public override string name { get; } = "Silver95p";
        public override double halfLife { get; } = 0.04d;
        public override double atomicWeight { get; } = 94.9409d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00026), new Silver95() } },

        };
    }
}
    
    