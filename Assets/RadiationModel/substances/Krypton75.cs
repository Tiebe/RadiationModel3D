using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton75 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton75";
        public override double halfLife { get; } = 276.0d;
        public override double atomicWeight { get; } = 74.93095d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4783000.0), new Bromine75() } },

        };
    }
}
    
    