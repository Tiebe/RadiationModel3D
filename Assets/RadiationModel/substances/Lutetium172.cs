using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium172";
        public override double halfLife { get; } = 578880.0d;
        public override double atomicWeight { get; } = 171.93909d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2519356.0), new Ytterbium172() } },

        };
    }
}
    
    