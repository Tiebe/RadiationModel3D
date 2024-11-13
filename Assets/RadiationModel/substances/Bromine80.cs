
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine80 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine80";
        public override double halfLife { get; } = 1060.8d;
        public override double atomicWeight { get; } = 79.91853d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.917d, new List<RadioactiveSubstance> { new BetaParticle(), new Krypton80() } },

            { 0.083d, new List<RadioactiveSubstance> { new BetaParticle(), new Selenium80() } },

        };
    }
}
    
    