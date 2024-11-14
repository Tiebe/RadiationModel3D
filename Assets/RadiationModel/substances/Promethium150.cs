using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium150";
        public override double halfLife { get; } = 9712.8d;
        public override double atomicWeight { get; } = 149.92099d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3454300.0), new Samarium150() } },

        };
    }
}
    
    