using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium155m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium155m";
        public override double halfLife { get; } = 45.0d;
        public override double atomicWeight { get; } = 154.93925d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5624000.0), new Erbium155() } },

        };
    }
}
    
    