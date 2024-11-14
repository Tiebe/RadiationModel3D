using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony134m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony134m";
        public override double halfLife { get; } = 10.01d;
        public override double atomicWeight { get; } = 133.92084d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8793800.0), new Tellurium134() } },

        };
    }
}
    
    