using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese58 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese58";
        public override double halfLife { get; } = 3.0d;
        public override double atomicWeight { get; } = 57.94007d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron58() }, { 1.0d, new BetaParticle(-1, 3163850.0) }, { 0.012d, new GammaParticle(1446500.0, 0.00086) }, { 0.005d, new GammaParticle(2065600.0, 0.0006) }, { 0.012d, new GammaParticle(2433100.0, 0.00051) } } },

        };
    }
}
    