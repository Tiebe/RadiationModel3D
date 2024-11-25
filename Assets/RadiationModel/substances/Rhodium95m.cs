using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium95m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium95m";
        public override double halfLife { get; } = 117.6d;
        public override double atomicWeight { get; } = 94.91648d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.88d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium95() }, { 0.8d, new GammaParticle(543300.0, 0.00228) }, { 0.0037965046079999998d, new GammaParticle(2892.0, 0.42871) }, { 0.01560233415196124d, new GammaParticle(20073.0, 0.06177) }, { 0.029538686391444982d, new GammaParticle(20215.0, 0.06133) }, { 0.00802162903652982d, new GammaParticle(22806.0, 0.05436) }, { 0.00935321945659377d, new GammaParticle(22957.0, 0.05401) }, { 0.00133159042006395d, new GammaParticle(23170.0, 0.05351) } } },
            { 0.12d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium95() }, { 1.0d, new BetaParticle(1, 4111500.0) }, { 0.08d, new GammaParticle(787700.0, 0.00157) }, { 0.008d, new GammaParticle(2821000.0, 0.00044) }, { 0.009000000000000001d, new GammaParticle(3186200.0, 0.00039) }, { 0.02d, new GammaParticle(3407100.0, 0.00036) }, { 0.008d, new GammaParticle(3757400.0, 0.00033) }, { 0.013000000000000001d, new GammaParticle(3824400.0, 0.00032) }, { 0.006d, new GammaParticle(4207800.0, 0.00029) }, { 0.006999999999999999d, new GammaParticle(4242000.0, 0.00029) }, { 0.01d, new GammaParticle(4336500.0, 0.00029) }, { 0.165d, new GammaParticle(511000.0, 0.00243) }, { 0.0015203993699999998d, new GammaParticle(2737.0, 0.45299) }, { 0.006814883479682039d, new GammaParticle(19150.0, 0.06474) }, { 0.012931467703381478d, new GammaParticle(19279.0, 0.06431) }, { 0.0034751538872086823d, new GammaParticle(21736.0, 0.05704) }, { 0.004038128816936489d, new GammaParticle(21875.0, 0.05668) }, { 0.0005629749297278065d, new GammaParticle(22072.0, 0.05617) } } },

        };
    }
}
    