using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium165";
        public override double halfLife { get; } = 644.4d;
        public override double atomicWeight { get; } = 164.93941d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3853000.0), new Ytterbium165() } },

        };
    }
}
    
    