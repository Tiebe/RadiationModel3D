using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium160m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium160m";
        public override double halfLife { get; } = 18072.0d;
        public override double atomicWeight { get; } = 159.9288d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.73d, new List<RadioactiveSubstance> { new GammaParticle((60000.0, 0.02066)), new Holmium160() } },
            { 0.27d, new List<RadioactiveSubstance> { new BetaParticle(1, 3350400.0), new Dysprosium160() } },

        };
    }
}
    
    