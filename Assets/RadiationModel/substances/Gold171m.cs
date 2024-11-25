using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold171m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold171m";
        public override double halfLife { get; } = 0.00104d;
        public override double atomicWeight { get; } = 170.99215d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.6d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium167() }, { 1.0d, new AlphaParticle(8361002.09) } } },
            { 0.4d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum170() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    