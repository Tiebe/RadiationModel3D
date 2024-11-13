
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt52 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt52";
        public override double halfLife { get; } = 0.1117d;
        public override double atomicWeight { get; } = 51.96313d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iron52() } },

        };
    }
}
    
    