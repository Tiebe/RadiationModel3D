using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt63 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt63";
        public override double halfLife { get; } = 27.4d;
        public override double atomicWeight { get; } = 62.9336d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel63() }, { 1.0d, new BetaParticle(-1, 1830450.0) }, { 0.494d, new GammaParticle(87130.0, 0.01423) }, { 0.0163d, new GammaParticle(155600.0, 0.00797) }, { 0.00107d, new GammaParticle(362300.0, 0.00342) }, { 0.0054d, new GammaParticle(913600.0, 0.00136) }, { 0.021400000000000002d, new GammaParticle(981700.0, 0.00126) }, { 0.0109d, new GammaParticle(1069100.0, 0.00116) }, { 0.003d, new GammaParticle(1095700.0, 0.00113) }, { 0.0070999999999999995d, new GammaParticle(1163800.0, 0.00107) }, { 0.014499999999999999d, new GammaParticle(1364500.0, 0.00091) }, { 0.0054d, new GammaParticle(2106000.0, 0.00059) }, { 0.0086d, new GammaParticle(2174500.0, 0.00057) }, { 0.0053372009773151995d, new GammaParticle(874.0, 1.41858) }, { 0.05291313991729562d, new GammaParticle(7461.0, 0.16618) }, { 0.1032653003850422d, new GammaParticle(7478.0, 0.1658) }, { 0.021521389073662155d, new GammaParticle(8296.0, 0.14945) }, { 0.021521389073662155d, new GammaParticle(8296.0, 0.14945) } } },

        };
    }
}
    