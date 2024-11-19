using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium157n : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium157n";
        public override double halfLife { get; } = 0.0216d;
        public override double atomicWeight { get; } = 156.92568d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00623, 199000.0), new Dysprosium157() } },

        };
    }
}
    
    