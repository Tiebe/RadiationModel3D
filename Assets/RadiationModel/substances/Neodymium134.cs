using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium134 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium134";
        public override double halfLife { get; } = 510.0d;
        public override double atomicWeight { get; } = 133.91879d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium134() }, { 1.0d, new BetaParticle(1, 4593500.0) }, { 0.02242d, new GammaParticle(90100.0, 0.01376) }, { 0.00295d, new GammaParticle(93300.0, 0.01329) }, { 0.0236d, new GammaParticle(101200.0, 0.01225) }, { 0.0177d, new GammaParticle(104100.0, 0.01191) }, { 0.0177d, new GammaParticle(115700.0, 0.01072) }, { 0.0059d, new GammaParticle(119400.0, 0.01038) }, { 0.0053100000000000005d, new GammaParticle(126000.0, 0.00984) }, { 0.0053100000000000005d, new GammaParticle(130600.0, 0.00949) }, { 0.01652d, new GammaParticle(144300.0, 0.00859) }, { 0.01298d, new GammaParticle(147800.0, 0.00839) }, { 0.59d, new GammaParticle(163200.0, 0.0076) }, { 0.00826d, new GammaParticle(183500.0, 0.00676) }, { 0.010029999999999999d, new GammaParticle(189400.0, 0.00655) }, { 0.12567d, new GammaParticle(216800.0, 0.00572) }, { 0.13216d, new GammaParticle(288900.0, 0.00429) }, { 0.01711d, new GammaParticle(295500.0, 0.0042) }, { 0.01711d, new GammaParticle(309200.0, 0.00401) }, { 0.010620000000000001d, new GammaParticle(320500.0, 0.00387) }, { 0.00413d, new GammaParticle(336000.0, 0.00369) }, { 0.00885d, new GammaParticle(352000.0, 0.00352) }, { 0.010620000000000001d, new GammaParticle(379100.0, 0.00327) }, { 0.00649d, new GammaParticle(459000.0, 0.0027) }, { 0.028319999999999998d, new GammaParticle(467900.0, 0.00265) }, { 0.0236d, new GammaParticle(483500.0, 0.00256) }, { 0.0118d, new GammaParticle(583000.0, 0.00213) }, { 0.0118d, new GammaParticle(673000.0, 0.00184) }, { 0.01829d, new GammaParticle(992000.0, 0.00125) }, { 0.041299999999999996d, new GammaParticle(1000000.0, 0.00124) }, { 0.41100000000000003d, new GammaParticle(511000.0, 0.00243) }, { 0.09699999999999999d, new GammaParticle(5637.0, 0.21995) }, { 0.1886d, new GammaParticle(35551.0, 0.03488) }, { 0.3444d, new GammaParticle(36027.0, 0.03441) }, { 0.1048d, new GammaParticle(40857.0, 0.03035) }, { 0.1316d, new GammaParticle(41266.0, 0.03005) }, { 0.0268d, new GammaParticle(41766.0, 0.02969) } } },

        };
    }
}
    