using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium206 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium206";
        public override double halfLife { get; } = 252.12d;
        public override double atomicWeight { get; } = 205.97611d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead206() }, { 1.0d, new BetaParticle(-1, 766099.99999) }, { 1.2999999999999998e-06d, new GammaParticle(363300.0, 0.00341) }, { 5e-05d, new GammaParticle(803060.0, 0.00154) }, { 1.8229784784e-07d, new GammaParticle(12522.0, 0.09901) }, { 1.278989265222389e-07d, new GammaParticle(72805.0, 0.01703) }, { 2.1495617902897294e-07d, new GammaParticle(74970.0, 0.01654) }, { 7.34689511895454e-08d, new GammaParticle(84986.0, 0.01459) }, { 9.56565744487881e-08d, new GammaParticle(86022.0, 0.01441) }, { 2.2187623259242707e-08d, new GammaParticle(87301.0, 0.0142) } } },

        };
    }
}
    