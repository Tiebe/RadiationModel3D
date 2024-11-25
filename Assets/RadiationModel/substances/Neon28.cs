using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon28 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon28";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 28.01213d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium28() }, { 1.0d, new BetaParticle(-1, 6144000.0) }, { 0.146d, new GammaParticle(55000.0, 0.02254) }, { 0.0129d, new GammaParticle(596000.0, 0.00208) }, { 0.0168d, new GammaParticle(782000.0, 0.00159) }, { 0.044000000000000004d, new GammaParticle(864500.0, 0.00143) }, { 0.0141d, new GammaParticle(1076000.0, 0.00115) }, { 0.0128d, new GammaParticle(1131000.0, 0.0011) }, { 0.0123d, new GammaParticle(1200000.0, 0.00103) }, { 0.032d, new GammaParticle(1255000.0, 0.00099) }, { 0.0235d, new GammaParticle(1583000.0, 0.00078) }, { 0.018000000000000002d, new GammaParticle(1877000.0, 0.00066) }, { 0.0158d, new GammaParticle(1932000.0, 0.00064) }, { 0.156d, new GammaParticle(2062900.0, 0.0006) }, { 0.0134d, new GammaParticle(2118000.0, 0.00059) }, { 0.0129d, new GammaParticle(2659000.0, 0.00047) }, { 0.019d, new GammaParticle(2714000.0, 0.00046) }, { 0.0126d, new GammaParticle(3231000.0, 0.00038) }, { 0.009399999999999999d, new GammaParticle(3457000.0, 0.00036) } } },
            { 0.12d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium28() }, { 1.0d, new BetaParticle(-1, 6144000.0) }, { 0.146d, new GammaParticle(55000.0, 0.02254) }, { 0.0129d, new GammaParticle(596000.0, 0.00208) }, { 0.0168d, new GammaParticle(782000.0, 0.00159) }, { 0.044000000000000004d, new GammaParticle(864500.0, 0.00143) }, { 0.0141d, new GammaParticle(1076000.0, 0.00115) }, { 0.0128d, new GammaParticle(1131000.0, 0.0011) }, { 0.0123d, new GammaParticle(1200000.0, 0.00103) }, { 0.032d, new GammaParticle(1255000.0, 0.00099) }, { 0.0235d, new GammaParticle(1583000.0, 0.00078) }, { 0.018000000000000002d, new GammaParticle(1877000.0, 0.00066) }, { 0.0158d, new GammaParticle(1932000.0, 0.00064) }, { 0.156d, new GammaParticle(2062900.0, 0.0006) }, { 0.0134d, new GammaParticle(2118000.0, 0.00059) }, { 0.0129d, new GammaParticle(2659000.0, 0.00047) }, { 0.019d, new GammaParticle(2714000.0, 0.00046) }, { 0.0126d, new GammaParticle(3231000.0, 0.00038) }, { 0.009399999999999999d, new GammaParticle(3457000.0, 0.00036) } } },
            { 0.037000000000000005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium26() }, { 1.0d, new BetaParticle(-1, 940574603.472) }, { 1.0d, new NeutronParticle() } } },

        };
    }
}
    