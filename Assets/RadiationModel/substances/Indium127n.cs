using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium127n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium127n";
        public override double halfLife { get; } = 1.04d;
        public override double atomicWeight { get; } = 126.91937d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8360000.0), new Tin127() } },

        };
    }
}
    
    