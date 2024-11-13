
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium121";
        public override double halfLife { get; } = 0.012d;
        public override double atomicWeight { get; } = 120.95539d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Cerium120() } },

        };
    }
}
    
    