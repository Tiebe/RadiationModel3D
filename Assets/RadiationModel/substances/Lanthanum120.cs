
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum120 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum120";
        public override double halfLife { get; } = 2.8d;
        public override double atomicWeight { get; } = 119.9382d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium120() } },

        };
    }
}
    
    