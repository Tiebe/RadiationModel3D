using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium234";
        public override double halfLife { get; } = 380160.0d;
        public override double atomicWeight { get; } = 234.04289d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1810000.0), new Uranium234() } },

        };
    }
}
    
    