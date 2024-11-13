
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium156";
        public override double halfLife { get; } = 0.444d;
        public override double atomicWeight { get; } = 155.94477d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium156() } },

        };
    }
}
    
    