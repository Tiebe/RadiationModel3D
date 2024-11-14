using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium169";
        public override double halfLife { get; } = 122616.0d;
        public override double atomicWeight { get; } = 168.93765d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2292530.0), new Ytterbium169() } },

        };
    }
}
    
    