using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold185 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold185";
        public override double halfLife { get; } = 255.0d;
        public override double atomicWeight { get; } = 184.9658d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9974d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium185() }, { 1.0d, new BetaParticle(1, 4238950.0) } } },
            { 0.0026d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium181() }, { 1.0d, new AlphaParticle(6201902.09) } } },

        };
    }
}
    