using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium184m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium184m";
        public override double halfLife { get; } = 48.0d;
        public override double atomicWeight { get; } = 183.95681d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium184() }, { 0.28d, new GammaParticle(72700.0, 0.01705) }, { 0.27d, new GammaParticle(107100.0, 0.01158) }, { 0.87d, new GammaParticle(242500.0, 0.00511) }, { 0.96d, new GammaParticle(367600.0, 0.00337) }, { 0.59d, new GammaParticle(482300.0, 0.00257) }, { 0.36d, new GammaParticle(555000.0, 0.00223) }, { 0.24463899499d, new GammaParticle(9114.0, 0.13604) }, { 0.15457348693545828d, new GammaParticle(54608.0, 0.0227) }, { 0.2705171279934517d, new GammaParticle(55786.0, 0.02222) }, { 0.089245543465738d, new GammaParticle(63333.0, 0.01958) }, { 0.11307410357109003d, new GammaParticle(64057.0, 0.01936) }, { 0.023828560105352045d, new GammaParticle(64935.0, 0.01909) } } },

        };
    }
}
    