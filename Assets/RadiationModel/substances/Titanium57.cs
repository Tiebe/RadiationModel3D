using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium57 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium57";
        public override double halfLife { get; } = 0.098d;
        public override double atomicWeight { get; } = 56.96307d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium57() }, { 1.0d, new BetaParticle(-1, 5020000.0) }, { 0.11d, new GammaParticle(61700.0, 0.02009) }, { 0.14d, new GammaParticle(113100.0, 0.01096) }, { 0.31d, new GammaParticle(174800.0, 0.00709) }, { 0.023d, new GammaParticle(744000.0, 0.00167) }, { 0.022000000000000002d, new GammaParticle(1557300.0, 0.0008) }, { 0.16d, new GammaParticle(1579400.0, 0.00079) }, { 0.012d, new GammaParticle(1732200.0, 0.00072) }, { 0.14d, new GammaParticle(1861500.0, 0.00067) }, { 0.026000000000000002d, new GammaParticle(1922900.0, 0.00064) }, { 0.018000000000000002d, new GammaParticle(2003700.0, 0.00062) }, { 0.006999999999999999d, new GammaParticle(2114600.0, 0.00059) }, { 0.05d, new GammaParticle(2300400.0, 0.00054) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    