using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium119m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium119m";
        public override double halfLife { get; } = 1080.0d;
        public override double atomicWeight { get; } = 118.90619d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.956d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin119() }, { 1.0d, new BetaParticle(-1, 1338500.0) }, { 8.999999999999999e-05d, new GammaParticle(896600.0, 0.00138) }, { 0.00021999999999999998d, new GammaParticle(897500.0, 0.00138) }, { 0.00024d, new GammaParticle(920500.0, 0.00135) }, { 7.000000000000001e-05d, new GammaParticle(921400.0, 0.00135) }, { 0.0021988d, new GammaParticle(1065550.0, 0.00116) }, { 0.00043999999999999996d, new GammaParticle(1089900.0, 0.00114) }, { 0.00092d, new GammaParticle(1163850.0, 0.00107) }, { 0.00017999999999999998d, new GammaParticle(1187790.0, 0.00104) }, { 0.00035000000000000005d, new GammaParticle(1225700.0, 0.00101) }, { 0.00125d, new GammaParticle(1249710.0, 0.00099) }, { 6.6e-05d, new GammaParticle(1330000.0, 0.00093) }, { 2e-05d, new GammaParticle(1354000.0, 0.00092) }, { 0.00015d, new GammaParticle(1506900.0, 0.00082) }, { 4.919619081264e-07d, new GammaParticle(3753.0, 0.33036) }, { 1.5479677428669195e-06d, new GammaParticle(25044.0, 0.04951) }, { 2.8971883639657863e-06d, new GammaParticle(25271.0, 0.04906) }, { 8.192159040662448e-07d, new GammaParticle(28579.0, 0.04338) }, { 9.80601437167295e-07d, new GammaParticle(28810.0, 0.04304) }, { 1.613855331010502e-07d, new GammaParticle(29107.0, 0.0426) } } },
            { 0.044000000000000004d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium119() }, { 0.0172d, new GammaParticle(311390.0, 0.00398) }, { 0.0015334240320000001d, new GammaParticle(3571.0, 0.3472) }, { 0.004596844116040421d, new GammaParticle(24001.0, 0.05166) }, { 0.008624473013209046d, new GammaParticle(24209.0, 0.05121) }, { 0.0024198343451685158d, new GammaParticle(27367.0, 0.0453) }, { 0.002879602870750534d, new GammaParticle(27581.0, 0.04495) }, { 0.000459768525582018d, new GammaParticle(27858.0, 0.04451) } } },

        };
    }
}
    