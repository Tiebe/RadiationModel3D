using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium61 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium61";
        public override double halfLife { get; } = 0.044d;
        public override double atomicWeight { get; } = 60.96372d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc61() }, { 1.0d, new BetaParticle(1, 11279500.0) }, { 1.1d, new GammaParticle(511000.0, 0.00243) }, { 9.3094518e-06d, new GammaParticle(1127.0, 1.10013) }, { 8.263808119373573e-05d, new GammaParticle(9225.0, 0.1344) }, { 0.0001605870213636528d, new GammaParticle(9252.0, 0.13401) }, { 3.522653821333152e-05d, new GammaParticle(10306.0, 0.1203) }, { 3.543789744261151e-05d, new GammaParticle(10313.0, 0.12022) }, { 2.1135922927998911e-07d, new GammaParticle(10365.0, 0.11962) } } },
            { 0.62d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc60() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    