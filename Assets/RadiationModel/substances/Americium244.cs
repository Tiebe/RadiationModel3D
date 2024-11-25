using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium244";
        public override double halfLife { get; } = 36360.0d;
        public override double atomicWeight { get; } = 244.06428d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium244() }, { 1.0d, new BetaParticle(-1, 713649.99999) }, { 0.00096d, new GammaParticle(42965.0, 0.02886) }, { 0.046d, new GammaParticle(99383.0, 0.01248) }, { 0.16399999999999998d, new GammaParticle(153863.0, 0.00806) }, { 0.0034000000000000002d, new GammaParticle(205575.0, 0.00603) }, { 0.0066d, new GammaParticle(538400.0, 0.0023) }, { 0.66d, new GammaParticle(743971.0, 0.00167) }, { 0.28d, new GammaParticle(897848.0, 0.00138) }, { 0.9414113124754d, new GammaParticle(18579.0, 0.06673) }, { 0.020769775756934908d, new GammaParticle(104606.0, 0.01185) }, { 0.03251882849058229d, new GammaParticle(109286.0, 0.01134) }, { 0.0121791262666293d, new GammaParticle(123280.0, 0.01006) }, { 0.016466178712482814d, new GammaParticle(124855.0, 0.00993) }, { 0.004287052445853513d, new GammaParticle(126917.0, 0.00977) } } },

        };
    }
}
    