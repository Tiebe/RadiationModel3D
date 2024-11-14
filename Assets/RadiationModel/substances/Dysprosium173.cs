using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium173";
        public override double halfLife { get; } = 1.43d;
        public override double atomicWeight { get; } = 172.95304d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5610000.0), new Holmium173() } },

        };
    }
}
    
    