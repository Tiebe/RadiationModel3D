
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron67n : RadioactiveSubstance
    {
        public override string name { get; } = "Iron67n";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 66.95141d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Iron67() } },

        };
    }
}
    
    