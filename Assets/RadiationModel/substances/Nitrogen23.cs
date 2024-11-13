
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen23 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen23";
        public override double halfLife { get; } = 0.0139d;
        public override double atomicWeight { get; } = 23.03942d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Oxygen23() } },

        };
    }
}
    
    