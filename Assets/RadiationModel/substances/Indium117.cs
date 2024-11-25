using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium117";
        public override double halfLife { get; } = 2592.0d;
        public override double atomicWeight { get; } = 116.90452d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin117() }, { 1.0d, new BetaParticle(-1, 727350.0) }, { 0.87d, new GammaParticle(158600.0, 0.00782) }, { 0.0017399999999999998d, new GammaParticle(396600.0, 0.00313) }, { 1.0d, new GammaParticle(552900.0, 0.00224) }, { 0.009188081832d, new GammaParticle(3753.0, 0.33036) }, { 0.028731896099940014d, new GammaParticle(25044.0, 0.04951) }, { 0.0537748382929815d, new GammaParticle(25271.0, 0.04906) }, { 0.01520550176029949d, new GammaParticle(28579.0, 0.04338) }, { 0.018200985607078488d, new GammaParticle(28810.0, 0.04304) }, { 0.0029954838467789995d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    