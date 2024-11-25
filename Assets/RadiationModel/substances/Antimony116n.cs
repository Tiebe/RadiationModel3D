using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony116n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony116n";
        public override double halfLife { get; } = 3618.0d;
        public override double atomicWeight { get; } = 115.9072d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium116() }, { 1.0d, new BetaParticle(1, 904880.0) }, { 0.28300000000000003d, new GammaParticle(99802.0, 0.01242) }, { 0.285d, new GammaParticle(135511.0, 0.00915) }, { 0.0009d, new GammaParticle(294600.0, 0.00421) }, { 0.0033d, new GammaParticle(319240.0, 0.00388) }, { 0.38799999999999996d, new GammaParticle(407351.0, 0.00304) }, { 0.0358d, new GammaParticle(436666.0, 0.00284) }, { 0.48100000000000004d, new GammaParticle(542867.0, 0.00228) }, { 0.11199999999999999d, new GammaParticle(844001.0, 0.00147) }, { 0.742d, new GammaParticle(972573.0, 0.00127) }, { 0.255d, new GammaParticle(1072373.0, 0.00116) }, { 0.009000000000000001d, new GammaParticle(1076720.0, 0.00115) }, { 1.0d, new GammaParticle(1293557.0, 0.00096) }, { 0.004d, new GammaParticle(1315530.0, 0.00094) }, { 0.005699999999999999d, new GammaParticle(1501030.0, 0.00083) }, { 0.52482d, new GammaParticle(511000.0, 0.00243) }, { 0.08913379236092d, new GammaParticle(3753.0, 0.33036) }, { 0.2663928970266332d, new GammaParticle(25044.0, 0.04951) }, { 0.49858300023700763d, new GammaParticle(25271.0, 0.04906) }, { 0.1409805204146693d, new GammaParticle(28579.0, 0.04338) }, { 0.16875368293635915d, new GammaParticle(28810.0, 0.04304) }, { 0.02777316252168985d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    