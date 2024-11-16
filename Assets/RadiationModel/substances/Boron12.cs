using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron12 : RadioactiveSubstance
    {
        public override string name { get; } = "Boron12";
        public override double halfLife { get; } = 0.0202d;
        public override double atomicWeight { get; } = 12.01435d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 13369400.0), new Carbon12() } },

        };
    }
}
    
    