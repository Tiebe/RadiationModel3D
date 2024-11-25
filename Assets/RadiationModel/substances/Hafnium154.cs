using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium154";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 153.96486d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium154() }, { 1.0d, new BetaParticle(1, 8601000.0) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium150() }, { 1.0d, new AlphaParticle(4697002.09) } } },

        };
    }
}
    