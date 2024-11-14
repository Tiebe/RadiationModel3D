using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium157";
        public override double halfLife { get; } = 756.0d;
        public override double atomicWeight { get; } = 156.92825d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2592000.0), new Dysprosium157() } },

        };
    }
}
    
    