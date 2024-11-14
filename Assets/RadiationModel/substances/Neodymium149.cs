using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium149";
        public override double halfLife { get; } = 6220.8d;
        public override double atomicWeight { get; } = 148.92015d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1688900.0), new Promethium149() } },

        };
    }
}
    
    