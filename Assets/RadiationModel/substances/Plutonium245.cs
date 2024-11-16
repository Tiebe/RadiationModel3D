using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium245 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium245";
        public override double halfLife { get; } = 37800.0d;
        public override double atomicWeight { get; } = 245.06782d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1277600.0), new Americium245() } },

        };
    }
}
    
    