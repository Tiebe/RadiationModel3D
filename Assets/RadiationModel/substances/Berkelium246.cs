using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium246 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium246";
        public override double halfLife { get; } = 155520.0d;
        public override double atomicWeight { get; } = 246.06867d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Americium246() }, { 1.0d, new BetaParticle(1, -512000.0) }, { 8e-05d, new GammaParticle(34800.0, 0.03563) }, { 0.0008500000000000001d, new GammaParticle(42800.0, 0.02897) }, { 0.002244d, new GammaParticle(99200.0, 0.0125) }, { 0.03162d, new GammaParticle(734300.0, 0.00169) }, { 0.6222d, new GammaParticle(798700.0, 0.00155) }, { 0.051d, new GammaParticle(833500.0, 0.00149) }, { 0.002244d, new GammaParticle(982200.0, 0.00126) }, { 0.002652d, new GammaParticle(986000.0, 0.00126) }, { 0.00153d, new GammaParticle(1023400.0, 0.00121) }, { 0.017849999999999998d, new GammaParticle(1036000.0, 0.0012) }, { 0.029580000000000002d, new GammaParticle(1062000.0, 0.00117) }, { 0.03774d, new GammaParticle(1078800.0, 0.00115) }, { 0.059160000000000004d, new GammaParticle(1081400.0, 0.00115) }, { 0.003876d, new GammaParticle(1085200.0, 0.00114) }, { 0.003876d, new GammaParticle(1122640.0, 0.0011) }, { 0.04488d, new GammaParticle(1124300.0, 0.0011) }, { 0.85d, new GammaParticle(18579.0, 0.06673) }, { 0.195d, new GammaParticle(104606.0, 0.01185) }, { 0.31d, new GammaParticle(109286.0, 0.01134) }, { 0.114d, new GammaParticle(123280.0, 0.01006) }, { 0.154d, new GammaParticle(124855.0, 0.00993) }, { 0.04d, new GammaParticle(126917.0, 0.00977) } } },

        };
    }
}
    