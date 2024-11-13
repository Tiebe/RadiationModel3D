
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium156";
        public override double halfLife { get; } = 0.233d;
        public override double atomicWeight { get; } = 155.95188d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Praseodymium156() } },

        };
    }
}
    
    