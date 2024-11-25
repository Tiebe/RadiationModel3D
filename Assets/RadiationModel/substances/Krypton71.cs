using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton71 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton71";
        public override double halfLife { get; } = 0.0949d;
        public override double atomicWeight { get; } = 70.95026d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium71() }, { 1.0d, new BetaParticle(1, 8408250.0) }, { 5.199999999999999e-06d, new GammaParticle(9860.0, 0.12574) }, { 0.0207d, new GammaParticle(198000.0, 0.00626) }, { 0.0256d, new GammaParticle(199000.0, 0.00623) }, { 0.0151d, new GammaParticle(208000.0, 0.00596) }, { 0.0055000000000000005d, new GammaParticle(397100.0, 0.00312) }, { 0.0121d, new GammaParticle(407400.0, 0.00304) }, { 1.9340000000000002d, new GammaParticle(511000.0, 0.00243) }, { 0.000536626180796d, new GammaParticle(1535.0, 0.80771) }, { 0.0006778782929009722d, new GammaParticle(11879.0, 0.10437) }, { 0.0013083927676143066d, new GammaParticle(11925.0, 0.10397) }, { 0.0003103318042004469d, new GammaParticle(13345.0, 0.09291) }, { 0.00033428941948472136d, new GammaParticle(13377.0, 0.09268) }, { 2.39576152842745e-05d, new GammaParticle(13469.0, 0.09205) } } },
            { 0.030600000000000002d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium70() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    