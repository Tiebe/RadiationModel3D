using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium98";
        public override double halfLife { get; } = 523.2d;
        public override double atomicWeight { get; } = 97.91071d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium98() }, { 1.0d, new BetaParticle(1, 1628500.0) }, { 0.965d, new GammaParticle(652600.0, 0.0019) }, { 0.0039565d, new GammaParticle(670200.0, 0.00185) }, { 0.011001d, new GammaParticle(761900.0, 0.00163) }, { 0.004053d, new GammaParticle(1144200.0, 0.00108) }, { 0.049215d, new GammaParticle(1164300.0, 0.00106) }, { 0.006176d, new GammaParticle(1414200.0, 0.00088) }, { 0.0109045d, new GammaParticle(1719800.0, 0.00072) }, { 0.0008684999999999999d, new GammaParticle(1764600.0, 0.0007) }, { 0.0016405d, new GammaParticle(1792300.0, 0.00069) }, { 0.018528d, new GammaParticle(1817200.0, 0.00068) }, { 0.0165015d, new GammaParticle(1967300.0, 0.00063) }, { 0.000772d, new GammaParticle(2467600.0, 0.0005) }, { 0.009649999999999999d, new GammaParticle(2526100.0, 0.00049) }, { 0.0026055d, new GammaParticle(2552300.0, 0.00049) }, { 0.00193d, new GammaParticle(2619200.0, 0.00047) }, { 0.004824999999999999d, new GammaParticle(3179300.0, 0.00039) }, { 0.001544d, new GammaParticle(3366700.0, 0.00037) }, { 1.752868d, new GammaParticle(511000.0, 0.00243) }, { 0.005826070868638285d, new GammaParticle(2737.0, 0.45299) }, { 0.02612578190290892d, new GammaParticle(19150.0, 0.06474) }, { 0.04957453871519719d, new GammaParticle(19279.0, 0.06431) }, { 0.01332247466988184d, new GammaParticle(21736.0, 0.05704) }, { 0.015480715566402698d, new GammaParticle(21875.0, 0.05668) }, { 0.002158240896520858d, new GammaParticle(22072.0, 0.05617) } } },

        };
    }
}
    