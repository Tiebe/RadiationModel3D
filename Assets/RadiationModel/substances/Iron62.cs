using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron62 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron62";
        public override double halfLife { get; } = 68.0d;
        public override double atomicWeight { get; } = 61.93679d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2545900.0), new Cobalt62() } },

        };
    }
}
    
    