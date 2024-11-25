using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium98";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 97.94213d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver98() }, { 1.0d, new BetaParticle(1, 9580000.0) }, { 1.994d, new GammaParticle(511000.0, 0.00243) }, { 0.00018410792d, new GammaParticle(3388.0, 0.36595) }, { 0.0006494665419013312d, new GammaParticle(22983.0, 0.05395) }, { 0.0012214905809692141d, new GammaParticle(23173.0, 0.0535) }, { 0.00034047620738532515d, new GammaParticle(26184.0, 0.04735) }, { 0.0004024428771294543d, new GammaParticle(26381.0, 0.047) }, { 6.196666974412917e-05d, new GammaParticle(26641.0, 0.04654) } } },
            { 0.0013d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver97() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    