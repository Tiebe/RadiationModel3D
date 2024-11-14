using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton70 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton70";
        public override double halfLife { get; } = 0.045d;
        public override double atomicWeight { get; } = 69.95588d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10326000.0), new Bromine70() } },

        };
    }
}
    
    