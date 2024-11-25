using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium218 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium218";
        public override double halfLife { get; } = 185.82d;
        public override double atomicWeight { get; } = 218.00897d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9998d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead214() }, { 1.0d, new AlphaParticle(7136702.09) } } },
            { 0.0002d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine218() }, { 1.0d, new BetaParticle(-1, 128349.99999) } } },

        };
    }
}
    