using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium147";
        public override double halfLife { get; } = 952992.0d;
        public override double atomicWeight { get; } = 146.91611d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Promethium147() }, { 1.0d, new BetaParticle(-1, 447599.99999) }, { 7e-06d, new GammaParticle(53100.0, 0.02335) }, { 7.2000000000000005e-06d, new GammaParticle(81130.0, 0.01528) }, { 0.289d, new GammaParticle(91105.0, 0.01361) }, { 0.00369d, new GammaParticle(120483.0, 0.01029) }, { 3.5000000000000004e-05d, new GammaParticle(149390.0, 0.0083) }, { 6.4e-05d, new GammaParticle(154910.0, 0.008) }, { 3.7000000000000005e-05d, new GammaParticle(191190.0, 0.00648) }, { 0.00181d, new GammaParticle(196640.0, 0.00631) }, { 1.4e-05d, new GammaParticle(222270.0, 0.00558) }, { 4.4999999999999996e-05d, new GammaParticle(230590.0, 0.00538) }, { 0.0001176d, new GammaParticle(272300.0, 0.00455) }, { 0.00791d, new GammaParticle(275388.0, 0.0045) }, { 0.01967d, new GammaParticle(319410.0, 0.00388) }, { 0.00867d, new GammaParticle(398130.0, 0.00311) }, { 0.000137d, new GammaParticle(408150.0, 0.00304) }, { 0.001071d, new GammaParticle(410520.0, 0.00302) }, { 0.01203d, new GammaParticle(439875.0, 0.00282) }, { 0.0014199999999999998d, new GammaParticle(489270.0, 0.00253) }, { 0.1311d, new GammaParticle(531012.0, 0.00233) }, { 0.000117d, new GammaParticle(541790.0, 0.00229) }, { 0.000387d, new GammaParticle(589350.0, 0.0021) }, { 0.00243d, new GammaParticle(594796.0, 0.00208) }, { 0.000161d, new GammaParticle(680400.0, 0.00182) }, { 0.00823d, new GammaParticle(685882.0, 0.00181) }, { 2.9999999999999997e-06d, new GammaParticle(716200.0, 0.00173) }, { 2.8e-06d, new GammaParticle(807200.0, 0.00154) }, { 0.07544033913560842d, new GammaParticle(6109.0, 0.20295) }, { 0.1327848197504226d, new GammaParticle(38171.0, 0.03248) }, { 0.24107628858101418d, new GammaParticle(38724.0, 0.03202) }, { 0.07474247933467786d, new GammaParticle(43934.0, 0.02822) }, { 0.09395129652369005d, new GammaParticle(44387.0, 0.02793) }, { 0.01920881718901221d, new GammaParticle(44938.0, 0.02759) } } },

        };
    }
}
    