using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium145";
        public override double halfLife { get; } = 4.31d;
        public override double atomicWeight { get; } = 144.92752d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5319000.0), new Lanthanum145() } },

        };
    }
}
    
    