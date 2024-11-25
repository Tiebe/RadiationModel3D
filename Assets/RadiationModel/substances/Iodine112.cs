using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine112 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine112";
        public override double halfLife { get; } = 3.34d;
        public override double atomicWeight { get; } = 111.928d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony112() }, { 1.0d, new BetaParticle(1, 7268000.0) } } },
            { 0.0088d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony111() }, { 1.0d, new ProtonParticle() } } },
            { 0.00104d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin108() }, { 1.0d, new AlphaParticle(13604002.09) } } },

        };
    }
}
    