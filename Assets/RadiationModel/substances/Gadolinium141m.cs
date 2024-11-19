using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium141m : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium141m";
        public override double halfLife { get; } = 24.5d;
        public override double atomicWeight { get; } = 140.93253d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new List<RadioactiveSubstance> { new BetaParticle(1, 7080000.0), new Europium141() } },
            { 0.11d, new List<RadioactiveSubstance> { new GammaParticle(0.00328, 378000.0), new Gadolinium141() } },

        };
    }
}
    
    