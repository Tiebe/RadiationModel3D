using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium147";
        public override double halfLife { get; } = 5.8d;
        public override double atomicWeight { get; } = 146.94014d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8439000.0), new Dysprosium147() } },

        };
    }
}
    
    