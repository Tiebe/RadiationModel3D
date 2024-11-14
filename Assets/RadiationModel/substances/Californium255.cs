using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium255 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium255";
        public override double halfLife { get; } = 5100.0d;
        public override double atomicWeight { get; } = 255.09105d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 721000.0), new Einsteinium255() } },

        };
    }
}
    
    