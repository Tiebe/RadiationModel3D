
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt52m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt52m";
        public override double halfLife { get; } = 0.102d;
        public override double atomicWeight { get; } = 51.96353d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iron52() } },

        };
    }
}
    
    