using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium155";
        public override double halfLife { get; } = 0.313d;
        public override double atomicWeight { get; } = 154.94871d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7635000.0), new Praseodymium155() } },

        };
    }
}
    
    