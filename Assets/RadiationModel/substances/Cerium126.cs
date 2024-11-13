
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium126 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium126";
        public override double halfLife { get; } = 51.0d;
        public override double atomicWeight { get; } = 125.92397d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum126() } },

        };
    }
}
    
    