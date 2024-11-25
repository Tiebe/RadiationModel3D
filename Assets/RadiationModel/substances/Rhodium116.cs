using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium116";
        public override double halfLife { get; } = 0.68d;
        public override double atomicWeight { get; } = 115.92406d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium116() }, { 1.0d, new BetaParticle(-1, 4545500.0) }, { 0.82d, new GammaParticle(340500.0, 0.00364) }, { 0.2706d, new GammaParticle(397700.0, 0.00312) }, { 0.1804d, new GammaParticle(737800.0, 0.00168) }, { 0.06314d, new GammaParticle(769500.0, 0.00161) }, { 0.02706d, new GammaParticle(995400.0, 0.00125) }, { 0.01722d, new GammaParticle(1336200.0, 0.00093) }, { 0.03034d, new GammaParticle(1392500.0, 0.00089) }, { 0.04428d, new GammaParticle(1665400.0, 0.00074) }, { 0.000817573128d, new GammaParticle(3053.0, 0.40611) }, { 0.003219903729885282d, new GammaParticle(21020.0, 0.05898) }, { 0.006083324636095376d, new GammaParticle(21177.0, 0.05855) }, { 0.0016690150718114021d, new GammaParticle(23904.0, 0.05187) }, { 0.0019527476340193406d, new GammaParticle(24070.0, 0.05151) }, { 0.0002837325622079384d, new GammaParticle(24297.0, 0.05103) } } },

        };
    }
}
    