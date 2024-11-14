using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium234";
        public override double halfLife { get; } = 139.2d;
        public override double atomicWeight { get; } = 234.04773d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4110000.0), new Plutonium234() } },
            { 0.00039d, new List<RadioactiveSubstance> { new AlphaParticle(7815047.4), new Neptunium230() } },

        };
    }
}
    
    