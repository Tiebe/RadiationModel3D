using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium235";
        public override double halfLife { get; } = 1518.0d;
        public override double atomicWeight { get; } = 235.04528d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9999720000000001d, new List<RadioactiveSubstance> { new BetaParticle(1, 1139000.0), new Neptunium235() } },
            { 2.8e-05d, new List<RadioactiveSubstance> { new AlphaParticle(6971047.4), new Uranium231() } },

        };
    }
}
    
    