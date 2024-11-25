using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony111 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony111";
        public override double halfLife { get; } = 75.0d;
        public override double atomicWeight { get; } = 110.91322d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium111() }, { 1.0d, new BetaParticle(1, 3777500.0) }, { 0.03288d, new GammaParticle(100240.0, 0.01237) }, { 0.6731999999999999d, new GammaParticle(154480.0, 0.00803) }, { 0.0348d, new GammaParticle(388830.0, 0.00319) }, { 0.0014399999999999999d, new GammaParticle(396200.0, 0.00313) }, { 0.396d, new GammaParticle(489100.0, 0.00253) }, { 0.00132d, new GammaParticle(546700.0, 0.00227) }, { 0.0072d, new GammaParticle(600800.0, 0.00206) }, { 0.018000000000000002d, new GammaParticle(643600.0, 0.00193) }, { 0.04872d, new GammaParticle(755400.0, 0.00164) }, { 0.0264d, new GammaParticle(777800.0, 0.00159) }, { 0.0051600000000000005d, new GammaParticle(877800.0, 0.00141) }, { 0.0192d, new GammaParticle(897400.0, 0.00138) }, { 0.015600000000000001d, new GammaParticle(997300.0, 0.00124) }, { 0.09480000000000001d, new GammaParticle(1032600.0, 0.0012) }, { 0.00132d, new GammaParticle(1067600.0, 0.00116) }, { 0.00264d, new GammaParticle(1122300.0, 0.0011) }, { 0.039599999999999996d, new GammaParticle(1147500.0, 0.00108) }, { 0.0084d, new GammaParticle(1179500.0, 0.00105) }, { 0.0014399999999999999d, new GammaParticle(1276500.0, 0.00097) }, { 0.0018d, new GammaParticle(1323700.0, 0.00094) }, { 0.00156d, new GammaParticle(1476500.0, 0.00084) }, { 0.00192d, new GammaParticle(1538500.0, 0.00081) }, { 0.00468d, new GammaParticle(1841300.0, 0.00067) }, { 1.7016d, new GammaParticle(511000.0, 0.00243) }, { 0.012851594101735999d, new GammaParticle(3753.0, 0.33036) }, { 0.03857002149136387d, new GammaParticle(25044.0, 0.04951) }, { 0.07218794963758912d, new GammaParticle(25271.0, 0.04906) }, { 0.020412037118669193d, new GammaParticle(28579.0, 0.04338) }, { 0.02443320843104703d, new GammaParticle(28810.0, 0.04304) }, { 0.0040211713123778315d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    