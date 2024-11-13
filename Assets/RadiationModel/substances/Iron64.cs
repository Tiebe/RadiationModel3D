
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron64 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron64";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 63.94099d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cobalt64() } },

        };
    }
}
    
    