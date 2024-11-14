using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium43 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium43";
        public override double halfLife { get; } = 80280.0d;
        public override double atomicWeight { get; } = 42.96073d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1833470.0), new Calcium43() } },

        };
    }
}
    
    