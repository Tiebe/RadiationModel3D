using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium180m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium180m";
        public override double halfLife { get; } = 19908.0d;
        public override double atomicWeight { get; } = 179.94779d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9969d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium180() }, { 0.48d, new GammaParticle(57538.0, 0.02155) }, { 0.165d, new GammaParticle(93324.0, 0.01329) }, { 0.816d, new GammaParticle(215426.0, 0.00576) }, { 0.94d, new GammaParticle(332274.0, 0.00373) }, { 0.82d, new GammaParticle(443162.0, 0.0028) }, { 0.142d, new GammaParticle(500697.0, 0.00248) }, { 0.239275564372d, new GammaParticle(9114.0, 0.13604) }, { 0.09586501560301526d, new GammaParticle(54608.0, 0.0227) }, { 0.1677721659135724d, new GammaParticle(55786.0, 0.02222) }, { 0.05534924252834438d, new GammaParticle(63333.0, 0.01958) }, { 0.07012749028341232d, new GammaParticle(64057.0, 0.01936) }, { 0.01477824775506795d, new GammaParticle(64935.0, 0.01909) } } },
            { 0.0031d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum180() }, { 1.0d, new BetaParticle(-1, 147849.99999) }, { 0.00017d, new GammaParticle(100700.0, 0.01231) }, { 1.36253096e-05d, new GammaParticle(9424.0, 0.13156) }, { 1.3735550393649918e-05d, new GammaParticle(56280.0, 0.02203) }, { 2.3946217562151184e-05d, new GammaParticle(57535.0, 0.02155) }, { 7.922072475747163e-06d, new GammaParticle(65315.0, 0.01898) }, { 1.0061032044198896e-05d, new GammaParticle(66067.0, 0.01877) }, { 2.1389595684517337e-06d, new GammaParticle(66981.0, 0.01851) } } },

        };
    }
}
    