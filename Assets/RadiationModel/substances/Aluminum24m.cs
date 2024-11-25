using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum24m : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum24m";
        public override double halfLife { get; } = 0.1307d;
        public override double atomicWeight { get; } = 24.0004d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.696d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum24() }, { 0.695d, new GammaParticle(425800.0, 0.00291) }, { 6.197933133e-07d, new GammaParticle(91.0, 13.62464) }, { 1.869772592363402e-05d, new GammaParticle(1487.0, 0.83379) }, { 9.410565457365003e-06d, new GammaParticle(1487.0, 0.83379) }, { 5.902741190009795e-07d, new GammaParticle(1558.0, 0.79579) }, { 5.902741190009795e-07d, new GammaParticle(1558.0, 0.79579) } } },
            { 0.304d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium24() }, { 1.0d, new BetaParticle(1, 4397445.5) }, { 0.044000000000000004d, new GammaParticle(1368625.0, 0.00091) }, { 0.0008d, new GammaParticle(2869300.0, 0.00043) }, { 0.0025d, new GammaParticle(4237600.0, 0.00029) }, { 0.005d, new GammaParticle(8595100.0, 0.00014) }, { 0.0017000000000000001d, new GammaParticle(8688600.0, 0.00014) }, { 0.0017000000000000001d, new GammaParticle(9825900.0, 0.00013) }, { 0.013300000000000001d, new GammaParticle(9963000.0, 0.00012) }, { 0.6105562d, new GammaParticle(511000.0, 0.00243) }, { 8.32681191162e-09d, new GammaParticle(46.0, 26.95309) }, { 2.610145041643534e-07d, new GammaParticle(1254.0, 0.98871) }, { 1.313163970450862e-07d, new GammaParticle(1254.0, 0.98871) } } },
            { 0.00028000000000000003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon20() }, { 1.0d, new AlphaParticle(6015924.29) } } },

        };
    }
}
    