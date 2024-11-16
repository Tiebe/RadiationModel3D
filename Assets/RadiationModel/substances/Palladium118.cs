using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium118";
        public override double halfLife { get; } = 1.9d;
        public override double atomicWeight { get; } = 117.91907d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4165399.9999999995), new Silver118() } },

        };
    }
}
    
    