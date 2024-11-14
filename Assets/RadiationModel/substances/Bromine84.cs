using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine84 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine84";
        public override double halfLife { get; } = 1905.6d;
        public override double atomicWeight { get; } = 83.9165d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4656345.0), new Krypton84() } },

        };
    }
}
    
    