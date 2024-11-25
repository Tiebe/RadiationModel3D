using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium87 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium87";
        public override double halfLife { get; } = 287280.0d;
        public override double atomicWeight { get; } = 86.91088d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium87() }, { 1.0d, new BetaParticle(1, 789701.0) }, { 0.8220000000000001d, new GammaParticle(388527.6, 0.00319) }, { 0.898446d, new GammaParticle(484805.0, 0.00256) }, { 0.0036d, new GammaParticle(511000.0, 0.00243) }, { 0.03251938479186304d, new GammaParticle(1890.0, 0.656) }, { 0.20369292921614587d, new GammaParticle(14098.0, 0.08794) }, { 0.39134088225964625d, new GammaParticle(14165.0, 0.08753) }, { 0.09662717204053793d, new GammaParticle(15898.0, 0.07799) }, { 0.10918870440580784d, new GammaParticle(15955.0, 0.07771) }, { 0.012561532365269933d, new GammaParticle(16085.0, 0.07708) } } },

        };
    }
}
    