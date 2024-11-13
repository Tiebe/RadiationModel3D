
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium150";
        public override double halfLife { get; } = 76.8d;
        public override double atomicWeight { get; } = 149.9335d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium150() } },

        };
    }
}
    
    