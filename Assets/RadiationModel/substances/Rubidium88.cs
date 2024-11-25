using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium88 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium88";
        public override double halfLife { get; } = 1066.38d;
        public override double atomicWeight { get; } = 87.91132d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium88() }, { 1.0d, new BetaParticle(-1, 2656314.5) }, { 0.0006d, new GammaParticle(338950.0, 0.00366) }, { 3.9e-05d, new GammaParticle(416200.0, 0.00298) }, { 0.00015d, new GammaParticle(439200.0, 0.00282) }, { 0.0003d, new GammaParticle(484530.0, 0.00256) }, { 0.00021999999999999998d, new GammaParticle(891300.0, 0.00139) }, { 0.14400000000000002d, new GammaParticle(898030.0, 0.00138) }, { 0.00010999999999999999d, new GammaParticle(1027300.0, 0.00121) }, { 0.00052d, new GammaParticle(1217970.0, 0.00102) }, { 0.00113d, new GammaParticle(1366260.0, 0.00091) }, { 0.00784d, new GammaParticle(1382450.0, 0.0009) }, { 9.3e-05d, new GammaParticle(1627000.0, 0.00076) }, { 0.0005d, new GammaParticle(1679600.0, 0.00074) }, { 0.00010999999999999999d, new GammaParticle(1687300.0, 0.00073) }, { 0.0023799999999999997d, new GammaParticle(1779870.0, 0.0007) }, { 0.00053d, new GammaParticle(1798350.0, 0.00069) }, { 0.2281d, new GammaParticle(1836000.0, 0.00068) }, { 0.00122d, new GammaParticle(2111500.0, 0.00059) }, { 0.00469d, new GammaParticle(2118867.0, 0.00059) }, { 0.0003d, new GammaParticle(2388000.0, 0.00052) }, { 0.00197d, new GammaParticle(2577791.0, 0.00048) }, { 0.0213d, new GammaParticle(2677892.0, 0.00046) }, { 0.0009299999999999999d, new GammaParticle(2734086.0, 0.00045) }, { 0.0027d, new GammaParticle(3009520.0, 0.00041) }, { 5e-05d, new GammaParticle(3017190.0, 0.00041) }, { 0.0023699999999999997d, new GammaParticle(3218480.0, 0.00039) }, { 0.0014000000000000002d, new GammaParticle(3486470.0, 0.00036) }, { 5.3e-05d, new GammaParticle(3524000.0, 0.00035) }, { 0.000137d, new GammaParticle(4035500.0, 0.00031) }, { 0.00178d, new GammaParticle(4742420.0, 0.00026) }, { 0.00011599999999999999d, new GammaParticle(4852882.0, 0.00026) }, { 2.40687697157968e-06d, new GammaParticle(1890.0, 0.656) }, { 1.5297565429654798e-05d, new GammaParticle(14098.0, 0.08794) }, { 2.939013531153659e-05d, new GammaParticle(14165.0, 0.08753) }, { 7.256808040715593e-06d, new GammaParticle(15898.0, 0.07799) }, { 8.200193086008619e-06d, new GammaParticle(15955.0, 0.07771) }, { 9.433850452930271e-07d, new GammaParticle(16085.0, 0.07708) } } },

        };
    }
}
    