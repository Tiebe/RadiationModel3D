using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium156n : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium156n";
        public override double halfLife { get; } = 456.0d;
        public override double atomicWeight { get; } = 155.92989d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.75d, new List<RadioactiveSubstance> { new BetaParticle(1, 5225400.0), new Dysprosium156() } },

        };
    }
}
    
    