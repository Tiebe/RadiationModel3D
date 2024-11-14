using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium150";
        public override double halfLife { get; } = 0.258d;
        public override double atomicWeight { get; } = 149.94644d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6421100.0), new Lanthanum150() } },

        };
    }
}
    
    