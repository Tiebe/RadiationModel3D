using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese64 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese64";
        public override double halfLife { get; } = 0.0888d;
        public override double atomicWeight { get; } = 63.95385d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11981000.0), new Iron64() } },

        };
    }
}
    
    