using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium60 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium60";
        public override double halfLife { get; } = 0.07d;
        public override double atomicWeight { get; } = 59.9575d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper60() }, { 1.0d, new BetaParticle(1, 9377650.0) }, { 0.87d, new GammaParticle(1003700.0, 0.00124) }, { 0.10439999999999999d, new GammaParticle(1554900.0, 0.0008) }, { 0.087d, new GammaParticle(2293000.0, 0.00054) }, { 0.1131d, new GammaParticle(2559000.0, 0.00048) }, { 0.4959d, new GammaParticle(3848300.0, 0.00032) }, { 2.0d, new GammaParticle(511000.0, 0.00243) }, { 1.258371828e-05d, new GammaParticle(1035.0, 1.19791) }, { 0.00011728469401811403d, new GammaParticle(8616.0, 0.1439) }, { 0.0002280915869663828d, new GammaParticle(8639.0, 0.14352) }, { 4.89398190155032e-05d, new GammaParticle(9610.0, 0.12902) }, { 4.89398190155032e-05d, new GammaParticle(9610.0, 0.12902) } } },
            { 0.016d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper59() }, { 1.0d, new BetaParticle(1, 474131301.736) }, { 1.0d, new ProtonParticle() } } },
            { 0.00023d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc60() }, { 1.0d, new BetaParticle(1, 7292250.0) } } },

        };
    }
}
    