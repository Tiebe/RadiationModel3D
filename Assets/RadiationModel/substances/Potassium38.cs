using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium38 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium38";
        public override double halfLife { get; } = 459.06d;
        public override double atomicWeight { get; } = 37.96908d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine38() }, { 1.0d, new BetaParticle(1, 498680.0) }, { 0.0001d, new GammaParticle(1770000.0, 0.0007) }, { 0.99848d, new GammaParticle(2167500.0, 0.00057) }, { 0.0015199999999999999d, new GammaParticle(3935600.0, 0.00032) }, { 1.992004d, new GammaParticle(511000.0, 0.00243) }, { 1.5e-05d, new GammaParticle(265.0, 4.67865) }, { 0.00021d, new GammaParticle(2956.0, 0.41943) }, { 0.00041d, new GammaParticle(2958.0, 0.41915) }, { 6.7e-05d, new GammaParticle(3190.0, 0.38867) }, { 6.7e-05d, new GammaParticle(3190.0, 0.38867) } } },

        };
    }
}
    