using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium180 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium180";
        public override double halfLife { get; } = 342.0d;
        public override double atomicWeight { get; } = 179.94989d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3099500.0), new Hafnium180() } },

        };
    }
}
    
    