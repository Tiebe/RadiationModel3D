using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium146";
        public override double halfLife { get; } = 2145872736000000.0d;
        public override double atomicWeight { get; } = 145.91305d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(3551102.09), new Neodymium142() } },

        };
    }
}
    
    