using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium40 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium40";
        public override double halfLife { get; } = 3.938304361629082e+16d;
        public override double atomicWeight { get; } = 39.964d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8928d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium40() }, { 1.0d, new BetaParticle(-1, 655451.0) } } },
            { 0.1072d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine40() }, { 1.0d, new BetaParticle(1, -2987750.0) }, { 0.1066d, new GammaParticle(1460820.0, 0.00085) }, { 2e-05d, new GammaParticle(511000.0, 0.00243) }, { 0.0002363097577522962d, new GammaParticle(265.0, 4.67865) }, { 0.002956421620629778d, new GammaParticle(2956.0, 0.41943) }, { 0.005855459735848243d, new GammaParticle(2958.0, 0.41915) }, { 0.0009508019983639784d, new GammaParticle(3190.0, 0.38867) }, { 0.0009508019983639784d, new GammaParticle(3190.0, 0.38867) } } },

        };
    }
}
    