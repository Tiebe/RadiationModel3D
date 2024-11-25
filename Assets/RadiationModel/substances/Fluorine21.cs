using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine21 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine21";
        public override double halfLife { get; } = 4.158d;
        public override double atomicWeight { get; } = 20.99995d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon21() }, { 1.0d, new BetaParticle(-1, 2842090.0) }, { 0.008955d, new GammaParticle(350725.0, 0.00354) }, { 0.15339914999999998d, new GammaParticle(1395131.0, 0.00089) }, { 0.007737119999999999d, new GammaParticle(1745800.0, 0.00071) }, { 1.791e-05d, new GammaParticle(1890400.0, 0.00066) }, { 1.9701e-06d, new GammaParticle(1989000.0, 0.00062) }, { 1.585035e-05d, new GammaParticle(2779400.0, 0.00045) }, { 1.791e-05d, new GammaParticle(2793940.0, 0.00044) }, { 3.49245e-06d, new GammaParticle(3384600.0, 0.00037) }, { 2.91933e-05d, new GammaParticle(3533200.0, 0.00035) }, { 2.48949e-05d, new GammaParticle(3735200.0, 0.00033) }, { 9.58185e-06d, new GammaParticle(3883900.0, 0.00032) }, { 0.0003196935d, new GammaParticle(4174100.0, 0.0003) }, { 0.00047551049999999996d, new GammaParticle(4333520.0, 0.00029) }, { 9.4923e-05d, new GammaParticle(4525840.0, 0.00027) }, { 0.0002802915d, new GammaParticle(4684270.0, 0.00026) }, { 3.684316297577855e-14d, new GammaParticle(848.0, 1.46208) }, { 1.8524742344221454e-14d, new GammaParticle(848.0, 1.46208) } } },

        };
    }
}
    