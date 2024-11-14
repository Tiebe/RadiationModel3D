using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium235";
        public override double halfLife { get; } = 618.0d;
        public override double atomicWeight { get; } = 235.0479d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.996d, new List<RadioactiveSubstance> { new BetaParticle(1, 2438000.0), new Plutonium235() } },
            { 0.004d, new List<RadioactiveSubstance> { new AlphaParticle(7595047.4), new Neptunium231() } },

        };
    }
}
    
    