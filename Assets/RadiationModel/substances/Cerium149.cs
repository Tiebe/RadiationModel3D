using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium149";
        public override double halfLife { get; } = 4.94d;
        public override double atomicWeight { get; } = 148.92843d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4369000.0), new Praseodymium149() } },

        };
    }
}
    
    