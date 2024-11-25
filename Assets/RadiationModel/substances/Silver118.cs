using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver118 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver118";
        public override double halfLife { get; } = 3.76d;
        public override double atomicWeight { get; } = 117.9146d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium118() }, { 1.0d, new BetaParticle(-1, 3574100.0) }, { 0.0005346d, new GammaParticle(345510.0, 0.00359) }, { 0.002187d, new GammaParticle(406540.0, 0.00305) }, { 0.004131d, new GammaParticle(435600.0, 0.00285) }, { 0.6399d, new GammaParticle(487770.0, 0.00254) }, { 0.00567d, new GammaParticle(646200.0, 0.00192) }, { 0.021869999999999997d, new GammaParticle(659630.0, 0.00188) }, { 0.2673d, new GammaParticle(677130.0, 0.00183) }, { 0.012960000000000001d, new GammaParticle(764230.0, 0.00162) }, { 0.032400000000000005d, new GammaParticle(781730.0, 0.00159) }, { 0.05346d, new GammaParticle(797830.0, 0.00155) }, { 0.01053d, new GammaParticle(1127320.0, 0.0011) }, { 0.014013d, new GammaParticle(1157400.0, 0.00107) }, { 0.021869999999999997d, new GammaParticle(1269540.0, 0.00098) }, { 0.008505d, new GammaParticle(1336800.0, 0.00093) }, { 0.01458d, new GammaParticle(1428020.0, 0.00087) }, { 0.01053d, new GammaParticle(1441340.0, 0.00086) }, { 0.03159d, new GammaParticle(1938600.0, 0.00064) }, { 0.011016d, new GammaParticle(2016900.0, 0.00061) }, { 0.06561d, new GammaParticle(2100800.0, 0.00059) }, { 0.005508d, new GammaParticle(2300900.0, 0.00054) }, { 0.02025d, new GammaParticle(2693800.0, 0.00046) }, { 0.01701d, new GammaParticle(2736700.0, 0.00045) }, { 0.06642d, new GammaParticle(2777800.0, 0.00045) }, { 0.10125d, new GammaParticle(2788700.0, 0.00044) }, { 0.016200000000000003d, new GammaParticle(2894000.0, 0.00043) }, { 0.09072d, new GammaParticle(3224200.0, 0.00038) }, { 2.4000000000000003e-07d, new GammaParticle(3388.0, 0.36595) }, { 8.000000000000001e-07d, new GammaParticle(22983.0, 0.05395) }, { 1.6000000000000001e-06d, new GammaParticle(23173.0, 0.0535) }, { 4.0000000000000003e-07d, new GammaParticle(26184.0, 0.04735) }, { 5e-07d, new GammaParticle(26381.0, 0.047) }, { 8e-08d, new GammaParticle(26641.0, 0.04654) } } },

        };
    }
}
    