using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium101 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium101";
        public override double halfLife { get; } = 104137855.71615d;
        public override double atomicWeight { get; } = 100.90616d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium101() }, { 0.00043799999999999997d, new GammaParticle(110940.0, 0.01118) }, { 0.68036d, new GammaParticle(127226.0, 0.00975) }, { 0.0005913d, new GammaParticle(184220.0, 0.00673) }, { 0.73d, new GammaParticle(198010.0, 0.00626) }, { 0.0059495d, new GammaParticle(295010.0, 0.0042) }, { 0.11826d, new GammaParticle(325230.0, 0.00381) }, { 0.0019855999999999997d, new GammaParticle(422190.0, 0.00294) }, { 0.051153084538259994d, new GammaParticle(2737.0, 0.45299) }, { 0.22569670972774866d, new GammaParticle(19150.0, 0.06474) }, { 0.42826700138092727d, new GammaParticle(19279.0, 0.06431) }, { 0.11509085965724979d, new GammaParticle(21736.0, 0.05704) }, { 0.13373557892172422d, new GammaParticle(21875.0, 0.05668) }, { 0.018644719264474464d, new GammaParticle(22072.0, 0.05617) } } },

        };
    }
}
    