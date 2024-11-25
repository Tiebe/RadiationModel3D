using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin126 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin126";
        public override double halfLife { get; } = 6879409862461.056d;
        public override double atomicWeight { get; } = 125.90766d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony126() }, { 1.0d, new BetaParticle(-1, 187500.0) }, { 5.84e-07d, new GammaParticle(17700.0, 0.07005) }, { 0.012410000000000001d, new GammaParticle(21646.0, 0.05728) }, { 0.0009855d, new GammaParticle(22700.0, 0.05462) }, { 0.06314499999999999d, new GammaParticle(23280.0, 0.05326) }, { 0.0047085d, new GammaParticle(42641.0, 0.02908) }, { 0.07811d, new GammaParticle(64281.0, 0.01929) }, { 0.085775d, new GammaParticle(86938.0, 0.01426) }, { 0.365d, new GammaParticle(87567.0, 0.01416) }, { 0.1121023124169d, new GammaParticle(3941.0, 0.3146) }, { 0.07833755711167394d, new GammaParticle(26111.0, 0.04748) }, { 0.14626130902104917d, new GammaParticle(26359.0, 0.04704) }, { 0.04160754471191125d, new GammaParticle(29821.0, 0.04158) }, { 0.05022030646727688d, new GammaParticle(30069.0, 0.04123) }, { 0.00861276175536563d, new GammaParticle(30387.0, 0.0408) } } },

        };
    }
}
    