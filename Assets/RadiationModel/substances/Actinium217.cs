using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium217 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium217";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 217.00934d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium213() }, { 1.0d, new AlphaParticle(10853002.09) } } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium217() }, { 1.0d, new BetaParticle(1, 2193500.0) } } },

        };
    }
}
    