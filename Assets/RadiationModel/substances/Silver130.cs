using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver130 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver130";
        public override double halfLife { get; } = 0.0406d;
        public override double atomicWeight { get; } = 129.95072d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 15218000.0), new Cadmium130() } },

        };
    }
}
    
    