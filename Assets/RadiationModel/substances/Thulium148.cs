using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium148";
        public override double halfLife { get; } = 0.7d;
        public override double atomicWeight { get; } = 147.95838d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 12714000.0), new Erbium148() } },

        };
    }
}
    
    