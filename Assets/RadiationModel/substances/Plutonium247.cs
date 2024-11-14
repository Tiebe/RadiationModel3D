using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium247";
        public override double halfLife { get; } = 196128.0d;
        public override double atomicWeight { get; } = 247.0743d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2060000.0), new Americium247() } },

        };
    }
}
    
    