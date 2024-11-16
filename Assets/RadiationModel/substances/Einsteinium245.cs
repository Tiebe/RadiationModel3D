using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium245 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium245";
        public override double halfLife { get; } = 66.6d;
        public override double atomicWeight { get; } = 245.0712d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.51d, new List<RadioactiveSubstance> { new BetaParticle(1, 2934800.0), new Californium245() } },
            { 0.49d, new List<RadioactiveSubstance> { new AlphaParticle(8937002.09), new Berkelium241() } },

        };
    }
}
    
    