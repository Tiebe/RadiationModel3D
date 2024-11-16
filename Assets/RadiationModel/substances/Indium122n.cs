using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium122n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium122n";
        public override double halfLife { get; } = 10.8d;
        public override double atomicWeight { get; } = 121.9106d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6660000.0), new Tin122() } },

        };
    }
}
    
    