
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron73 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron73";
        public override double halfLife { get; } = 0.0129d;
        public override double atomicWeight { get; } = 72.97425d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cobalt73() } },

        };
    }
}
    
    