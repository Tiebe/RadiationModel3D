using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium127 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium127";
        public override double halfLife { get; } = 0.37d;
        public override double atomicWeight { get; } = 126.9262d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium127() }, { 1.0d, new BetaParticle(-1, 4069500.0) }, { 0.002988d, new GammaParticle(122130.0, 0.01015) }, { 0.012450000000000001d, new GammaParticle(168980.0, 0.00734) }, { 0.006888999999999999d, new GammaParticle(204300.0, 0.00607) }, { 0.005229d, new GammaParticle(339000.0, 0.00366) }, { 0.007221d, new GammaParticle(368200.0, 0.00337) }, { 0.0747d, new GammaParticle(376280.0, 0.00329) }, { 0.006888999999999999d, new GammaParticle(388800.0, 0.00319) }, { 0.05146d, new GammaParticle(523600.0, 0.00237) }, { 0.004482d, new GammaParticle(656700.0, 0.00189) }, { 0.01079d, new GammaParticle(688000.0, 0.0018) }, { 0.005395d, new GammaParticle(863000.0, 0.00144) }, { 0.050629999999999994d, new GammaParticle(1067000.0, 0.00116) }, { 0.0070550000000000005d, new GammaParticle(1145300.0, 0.00108) }, { 0.008051d, new GammaParticle(1160200.0, 0.00107) }, { 0.04482d, new GammaParticle(1202270.0, 0.00103) }, { 0.083d, new GammaParticle(1235070.0, 0.001) }, { 0.02241d, new GammaParticle(1240600.0, 0.001) }, { 0.02573d, new GammaParticle(1282500.0, 0.00097) }, { 0.00664d, new GammaParticle(1372500.0, 0.0009) }, { 0.014110000000000001d, new GammaParticle(1622800.0, 0.00076) }, { 0.0027389999999999997d, new GammaParticle(1662800.0, 0.00075) }, { 0.009130000000000001d, new GammaParticle(1686000.0, 0.00074) }, { 0.00498d, new GammaParticle(1744700.0, 0.00071) }, { 0.00498d, new GammaParticle(1755400.0, 0.00071) }, { 0.0083d, new GammaParticle(1784600.0, 0.00069) }, { 0.012035d, new GammaParticle(1856000.0, 0.00067) }, { 0.004067d, new GammaParticle(1868100.0, 0.00066) }, { 0.0038179999999999998d, new GammaParticle(1907600.0, 0.00065) }, { 0.0083d, new GammaParticle(1978000.0, 0.00063) }, { 0.0045650000000000005d, new GammaParticle(2062400.0, 0.0006) }, { 0.004233d, new GammaParticle(2193600.0, 0.00057) }, { 0.0027389999999999997d, new GammaParticle(2250000.0, 0.00055) }, { 0.00249d, new GammaParticle(2266000.0, 0.00055) }, { 0.03237d, new GammaParticle(2339100.0, 0.00053) }, { 0.0025729999999999998d, new GammaParticle(2443000.0, 0.00051) }, { 0.003984d, new GammaParticle(2482300.0, 0.0005) }, { 0.003071d, new GammaParticle(2535000.0, 0.00049) }, { 0.002241d, new GammaParticle(2637900.0, 0.00047) }, { 0.00996d, new GammaParticle(2677400.0, 0.00046) }, { 0.001992d, new GammaParticle(2688600.0, 0.00046) }, { 0.014525d, new GammaParticle(2941300.0, 0.00042) }, { 0.007387d, new GammaParticle(3108900.0, 0.0004) }, { 0.00332d, new GammaParticle(3521100.0, 0.00035) } } },

        };
    }
}
    