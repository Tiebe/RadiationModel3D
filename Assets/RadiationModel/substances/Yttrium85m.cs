using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium85m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium85m";
        public override double halfLife { get; } = 17496.0d;
        public override double atomicWeight { get; } = 84.91645d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3281300.0), new Strontium85() } },

        };
    }
}
    
    