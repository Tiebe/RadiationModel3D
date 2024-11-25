using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine84n : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine84n";
        public override double halfLife { get; } = 360.0d;
        public override double atomicWeight { get; } = 83.91693d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton84() }, { 1.0d, new BetaParticle(-1, 2532172.5) }, { 1.0d, new GammaParticle(424000.0, 0.00292) }, { 0.03d, new GammaParticle(447000.0, 0.00277) }, { 0.98d, new GammaParticle(881600.0, 0.00141) }, { 0.01d, new GammaParticle(1016000.0, 0.00122) }, { 0.97d, new GammaParticle(1462800.0, 0.00085) }, { 0.02d, new GammaParticle(1897700.0, 0.00065) }, { 4.0405373550000004e-05d, new GammaParticle(1648.0, 0.75233) }, { 0.00028404583963151045d, new GammaParticle(12596.0, 0.09843) }, { 0.0005477166209631901d, new GammaParticle(12649.0, 0.09802) }, { 0.00013124740134929096d, new GammaParticle(14169.0, 0.0875) }, { 0.00014447713940529948d, new GammaParticle(14209.0, 0.08726) }, { 1.3229738056008528e-05d, new GammaParticle(14313.0, 0.08662) } } },

        };
    }
}
    