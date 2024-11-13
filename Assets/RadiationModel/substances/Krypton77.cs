
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton77 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton77";
        public override double halfLife { get; } = 4356.0d;
        public override double atomicWeight { get; } = 76.92467d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Bromine77() } },

        };
    }
}
    
    