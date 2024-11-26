using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium235";
        public override double halfLife { get; } = 34223040.0d;
        public override double atomicWeight { get; } = 235.04406d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.999974d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium235() }, { 0.3361181679065d, new GammaParticle(16678.0, 0.07434) }, { 0.00590725939398531d, new GammaParticle(94657.0, 0.0131) }, { 0.009456153984288956d, new GammaParticle(98439.0, 0.0126) }, { 0.0034115478291547926d, new GammaParticle(111238.0, 0.01115) }, { 0.0045782971867257315d, new GammaParticle(112645.0, 0.01101) }, { 0.001166749357570939d, new GammaParticle(114446.0, 0.01083) } } },
            { 2.6e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium231() }, { 1.0d, new AlphaParticle(6215702.09) }, { 6.000000000000001e-08d, new GammaParticle(17195.0, 0.0721) }, { 1.2e-08d, new GammaParticle(18055.0, 0.06867) }, { 3.72e-06d, new GammaParticle(25650.0, 0.04834) }, { 9.5e-07d, new GammaParticle(53200.0, 0.02331) }, { 1.3e-07d, new GammaParticle(58570.0, 0.02117) }, { 1.8e-09d, new GammaParticle(63860.0, 0.01942) }, { 3.8999999999999997e-07d, new GammaParticle(81228.0, 0.01526) }, { 1.82e-07d, new GammaParticle(82087.0, 0.0151) }, { 1.7899999999999998e-06d, new GammaParticle(84214.0, 0.01472) }, { 1.8e-08d, new GammaParticle(89950.0, 0.01378) }, { 2.6e-08d, new GammaParticle(93020.0, 0.01333) }, { 5.6999999999999994e-08d, new GammaParticle(99278.0, 0.01249) }, { 7.8e-08d, new GammaParticle(102270.0, 0.01212) }, { 2.3e-08d, new GammaParticle(110800.0, 0.01119) }, { 1.8e-08d, new GammaParticle(124927.0, 0.00992) }, { 8e-08d, new GammaParticle(126000.0, 0.00984) }, { 7e-09d, new GammaParticle(135670.0, 0.00914) }, { 1.3e-08d, new GammaParticle(163101.0, 0.0076) }, { 1.8e-09d, new GammaParticle(174150.0, 0.00712) }, { 1e-08d, new GammaParticle(183489.0, 0.00676) }, { 1.56e-05d, new GammaParticle(16228.0, 0.0764) }, { 3.0000000000000004e-08d, new GammaParticle(92282.0, 0.01344) }, { 4.8999999999999995e-08d, new GammaParticle(95865.0, 0.01293) }, { 1.7e-08d, new GammaParticle(108373.0, 0.01144) }, { 2.3e-08d, new GammaParticle(109740.0, 0.0113) }, { 5.9e-09d, new GammaParticle(111482.0, 0.01112) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    