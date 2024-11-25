using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium35 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium35";
        public override double halfLife { get; } = 0.178d;
        public override double atomicWeight { get; } = 34.98801d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine35() }, { 1.0d, new BetaParticle(1, 8920315.0) }, { 0.0045000000000000005d, new GammaParticle(886800.0, 0.0014) }, { 0.006500000000000001d, new GammaParticle(1044400.0, 0.00119) }, { 0.07150000000000001d, new GammaParticle(1184000.0, 0.00105) }, { 0.015d, new GammaParticle(1426800.0, 0.00087) }, { 0.0095d, new GammaParticle(1507400.0, 0.00082) }, { 0.14d, new GammaParticle(1750500.0, 0.00071) }, { 0.0175d, new GammaParticle(1798900.0, 0.00069) }, { 0.26d, new GammaParticle(2589800.0, 0.00048) }, { 0.0275d, new GammaParticle(2638000.0, 0.00047) }, { 0.0175d, new GammaParticle(2934500.0, 0.00042) }, { 0.5d, new GammaParticle(2982680.0, 0.00042) }, { 0.014499999999999999d, new GammaParticle(3542000.0, 0.00035) }, { 0.0175d, new GammaParticle(3821700.0, 0.00032) }, { 0.0175d, new GammaParticle(4387200.0, 0.00028) }, { 0.013000000000000001d, new GammaParticle(4527900.0, 0.00027) }, { 0.006d, new GammaParticle(4724500.0, 0.00026) }, { 0.0095d, new GammaParticle(4785400.0, 0.00026) }, { 0.0305d, new GammaParticle(5572300.0, 0.00022) }, { 2.0012d, new GammaParticle(511000.0, 0.00243) }, { 8.525802040980001e-07d, new GammaParticle(265.0, 4.67865) }, { 1.1740541824883015e-05d, new GammaParticle(2956.0, 0.41943) }, { 2.3253202267544096e-05d, new GammaParticle(2958.0, 0.41915) }, { 3.7758249875728853e-06d, new GammaParticle(3190.0, 0.38867) }, { 3.7758249875728853e-06d, new GammaParticle(3190.0, 0.38867) } } },
            { 0.0037d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine34() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    