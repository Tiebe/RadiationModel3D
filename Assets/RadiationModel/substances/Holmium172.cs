using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium172";
        public override double halfLife { get; } = 25.0d;
        public override double atomicWeight { get; } = 171.94473d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium172() }, { 1.0d, new BetaParticle(-1, 2501500.0) }, { 0.09359999999999999d, new GammaParticle(77000.0, 0.0161) }, { 0.07200000000000001d, new GammaParticle(103700.0, 0.01196) }, { 0.36d, new GammaParticle(133600.0, 0.00928) }, { 0.07200000000000001d, new GammaParticle(137800.0, 0.009) }, { 0.07919999999999999d, new GammaParticle(153700.0, 0.00807) }, { 0.2304d, new GammaParticle(178000.0, 0.00697) }, { 0.1332d, new GammaParticle(229400.0, 0.0054) }, { 0.15839999999999999d, new GammaParticle(291100.0, 0.00426) }, { 0.1764d, new GammaParticle(757200.0, 0.00164) }, { 0.09d, new GammaParticle(884400.0, 0.0014) }, { 0.07919999999999999d, new GammaParticle(956700.0, 0.0013) }, { 0.12240000000000001d, new GammaParticle(961400.0, 0.00129) }, { 0.12960000000000002d, new GammaParticle(1008100.0, 0.00123) }, { 0.0252d, new GammaParticle(1033700.0, 0.0012) }, { 0.039599999999999996d, new GammaParticle(1141700.0, 0.00109) }, { 0.0828d, new GammaParticle(1186100.0, 0.00105) }, { 0.16521536189952d, new GammaParticle(7933.0, 0.15629) }, { 0.08660847098433809d, new GammaParticle(48222.0, 0.02571) }, { 0.15372465563425292d, new GammaParticle(49128.0, 0.02524) }, { 0.049954957032864275d, new GammaParticle(55779.0, 0.02223) }, { 0.06294324586140898d, new GammaParticle(56399.0, 0.02198) }, { 0.01298828882854471d, new GammaParticle(57145.0, 0.0217) } } },

        };
    }
}
    