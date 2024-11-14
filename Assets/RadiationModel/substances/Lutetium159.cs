using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium159";
        public override double halfLife { get; } = 12.1d;
        public override double atomicWeight { get; } = 158.94663d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6124000.0), new Ytterbium159() } },

        };
    }
}
    
    