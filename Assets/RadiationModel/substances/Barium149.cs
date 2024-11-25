using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium149";
        public override double halfLife { get; } = 0.352d;
        public override double atomicWeight { get; } = 148.94328d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum149() }, { 1.0d, new BetaParticle(-1, 3694700.0) } } },
            { 0.022000000000000002d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum149() }, { 1.0d, new BetaParticle(-1, 3694700.0) } } },

        };
    }
}
    