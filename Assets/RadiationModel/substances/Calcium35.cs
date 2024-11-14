using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium35 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium35";
        public override double halfLife { get; } = 0.0257d;
        public override double atomicWeight { get; } = 35.00557d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 16362900.0), new Potassium35() } },

        };
    }
}
    
    