
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton99 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton99";
        public override double halfLife { get; } = 0.04d;
        public override double atomicWeight { get; } = 98.95878d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rubidium99() } },

        };
    }
}
    
    