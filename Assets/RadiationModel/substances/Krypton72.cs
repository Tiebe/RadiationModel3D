using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton72 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton72";
        public override double halfLife { get; } = 17.16d;
        public override double atomicWeight { get; } = 71.94209d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5120800.0), new Bromine72() } },

        };
    }
}
    
    