using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium141";
        public override double halfLife { get; } = 1096.2d;
        public override double atomicWeight { get; } = 140.9144d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3198000.0), new Lanthanum141() } },

        };
    }
}
    
    