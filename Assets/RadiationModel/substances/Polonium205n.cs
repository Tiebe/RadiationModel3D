
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium205n : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium205n";
        public override double halfLife { get; } = 0.00064d;
        public override double atomicWeight { get; } = 204.98214d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Polonium205() } },

        };
    }
}
    
    