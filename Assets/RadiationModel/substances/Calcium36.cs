using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium36 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium36";
        public override double halfLife { get; } = 0.1009d;
        public override double atomicWeight { get; } = 35.99308d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10967200.0), new Potassium36() } },

        };
    }
}
    
    