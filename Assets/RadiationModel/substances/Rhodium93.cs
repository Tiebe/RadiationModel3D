using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium93 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium93";
        public override double halfLife { get; } = 12.2d;
        public override double atomicWeight { get; } = 92.92591d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium93() }, { 1.0d, new BetaParticle(1, 7297150.0) }, { 0.0116d, new GammaParticle(482600.0, 0.00257) }, { 0.02436d, new GammaParticle(643600.0, 0.00193) }, { 0.057999999999999996d, new GammaParticle(1359400.0, 0.00091) }, { 0.04176d, new GammaParticle(1393300.0, 0.00089) }, { 0.05684d, new GammaParticle(1629900.0, 0.00076) }, { 0.01798d, new GammaParticle(1842400.0, 0.00067) }, { 0.027839999999999997d, new GammaParticle(2273800.0, 0.00055) }, { 1.976d, new GammaParticle(511000.0, 0.00243) }, { 0.0005177655018684d, new GammaParticle(2737.0, 0.45299) }, { 0.002323634492267966d, new GammaParticle(19150.0, 0.06474) }, { 0.004409173609616634d, new GammaParticle(19279.0, 0.06431) }, { 0.0011849046960717734d, new GammaParticle(21736.0, 0.05704) }, { 0.0013768592568354006d, new GammaParticle(21875.0, 0.05668) }, { 0.0001919545607636273d, new GammaParticle(22072.0, 0.05617) } } },

        };
    }
}
    