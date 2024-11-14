using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury206 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury206";
        public override double halfLife { get; } = 499.2d;
        public override double atomicWeight { get; } = 205.97751d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1307300.0), new Thallium206() } },

        };
    }
}
    
    