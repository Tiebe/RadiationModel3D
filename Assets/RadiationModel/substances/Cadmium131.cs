using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium131";
        public override double halfLife { get; } = 0.098d;
        public override double atomicWeight { get; } = 130.94073d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12812400.0), new Indium131() } },

        };
    }
}
    
    