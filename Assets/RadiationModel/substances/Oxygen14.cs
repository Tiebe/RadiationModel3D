using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen14 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen14";
        public override double halfLife { get; } = 70.606d;
        public override double atomicWeight { get; } = 14.0086d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon14() }, { 1.0d, new BetaParticle(1, 2493944.0) }, { 0.00052d, new GammaParticle(1635200.0, 0.00076) }, { 0.9938800000000001d, new GammaParticle(2312593.0, 0.00054) }, { 2.1099999999999998e-05d, new GammaParticle(3947500.0, 0.00031) }, { 1.99756d, new GammaParticle(511000.0, 0.00243) } } },

        };
    }
}
    