using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum158m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum158m";
        public override double halfLife { get; } = 0.0367d;
        public override double atomicWeight { get; } = 157.96674d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.95d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium154() }, { 1.0d, new AlphaParticle(7287002.09) } } },
            { 0.05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium158() }, { 1.0d, new BetaParticle(1, 8116000.0) } } },

        };
    }
}
    