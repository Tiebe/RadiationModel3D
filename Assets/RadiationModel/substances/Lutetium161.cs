using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium161";
        public override double halfLife { get; } = 77.0d;
        public override double atomicWeight { get; } = 160.94357d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5272000.0), new Ytterbium161() } },

        };
    }
}
    
    