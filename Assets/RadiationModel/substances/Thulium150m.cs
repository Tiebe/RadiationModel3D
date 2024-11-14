using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium150m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium150m";
        public override double halfLife { get; } = 2.2d;
        public override double atomicWeight { get; } = 149.95024d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 11481000.0), new Erbium150() } },

        };
    }
}
    
    