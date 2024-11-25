using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt65 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt65";
        public override double halfLife { get; } = 1.16d;
        public override double atomicWeight { get; } = 64.93646d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel65() }, { 1.0d, new BetaParticle(-1, 2970300.0) }, { 0.00435d, new GammaParticle(63400.0, 0.01956) }, { 0.023780000000000003d, new GammaParticle(310400.0, 0.00399) }, { 0.02291d, new GammaParticle(963400.0, 0.00129) }, { 0.028999999999999998d, new GammaParticle(1141100.0, 0.00109) }, { 0.01131d, new GammaParticle(1210600.0, 0.00102) }, { 0.01218d, new GammaParticle(1273200.0, 0.00097) }, { 0.0001563605064d, new GammaParticle(874.0, 1.41858) }, { 0.0015377898287265769d, new GammaParticle(7461.0, 0.16618) }, { 0.003001151109926965d, new GammaParticle(7478.0, 0.1658) }, { 0.0006254660613464582d, new GammaParticle(8296.0, 0.14945) }, { 0.0006254660613464582d, new GammaParticle(8296.0, 0.14945) } } },

        };
    }
}
    