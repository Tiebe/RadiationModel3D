using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum182 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum182";
        public override double halfLife { get; } = 9913536.0d;
        public override double atomicWeight { get; } = 181.95015d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1815400.0), new Tungsten182() } },

        };
    }
}
    
    