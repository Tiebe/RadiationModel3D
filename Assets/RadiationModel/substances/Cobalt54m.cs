
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt54m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt54m";
        public override double halfLife { get; } = 88.8d;
        public override double atomicWeight { get; } = 53.94867d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iron54() } },

        };
    }
}
    
    