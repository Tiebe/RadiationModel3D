using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon26 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon26";
        public override double halfLife { get; } = 2.2453d;
        public override double atomicWeight { get; } = 25.99233d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium26() }, { 1.0d, new BetaParticle(1, 4536772.0) }, { 0.0008000599999999999d, new GammaParticle(416848.0, 0.00297) }, { 0.218d, new GammaParticle(829300.0, 0.0015) }, { 0.00021364000000000002d, new GammaParticle(1342145.0, 0.00092) }, { 0.00020927999999999997d, new GammaParticle(1433730.0, 0.00086) }, { 0.027141000000000002d, new GammaParticle(1622000.0, 0.00076) }, { 0.000327d, new GammaParticle(1654730.0, 0.00075) }, { 0.00257022d, new GammaParticle(1844200.0, 0.00067) }, { 6.104e-05d, new GammaParticle(2323070.0, 0.00053) }, { 0.00061476d, new GammaParticle(2511590.0, 0.00049) }, { 3.27e-05d, new GammaParticle(2665920.0, 0.00047) }, { 9.810000000000001e-06d, new GammaParticle(3495250.0, 0.00035) }, { 1.9994059999999998d, new GammaParticle(511000.0, 0.00243) }, { 6.9e-07d, new GammaParticle(91.0, 13.62464) }, { 2.05e-05d, new GammaParticle(1487.0, 0.83379) }, { 1.0300000000000001e-05d, new GammaParticle(1487.0, 0.83379) }, { 6.499999999999999e-07d, new GammaParticle(1558.0, 0.79579) }, { 6.499999999999999e-07d, new GammaParticle(1558.0, 0.79579) } } },

        };
    }
}
    