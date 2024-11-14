using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium149";
        public override double halfLife { get; } = 21.1d;
        public override double atomicWeight { get; } = 148.93382d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6048000.0), new Dysprosium149() } },

        };
    }
}
    
    