using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium146";
        public override double halfLife { get; } = 2145870966272256.0d;
        public override double atomicWeight { get; } = 145.91305d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium142() }, { 1.0d, new AlphaParticle(3551102.09) } } },

        };
    }
}
    