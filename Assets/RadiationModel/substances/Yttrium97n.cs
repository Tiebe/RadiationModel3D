using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium97n : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium97n";
        public override double halfLife { get; } = 0.142d;
        public override double atomicWeight { get; } = 96.92207d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.948d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium97() }, { 0.013000000000000001d, new GammaParticle(94000.0, 0.01319) }, { 0.47d, new GammaParticle(162300.0, 0.00764) }, { 0.006999999999999999d, new GammaParticle(194300.0, 0.00638) }, { 0.077d, new GammaParticle(196900.0, 0.0063) }, { 0.018000000000000002d, new GammaParticle(202100.0, 0.00613) }, { 0.048d, new GammaParticle(216900.0, 0.00572) }, { 0.021d, new GammaParticle(246700.0, 0.00503) }, { 0.024d, new GammaParticle(273200.0, 0.00454) }, { 0.29d, new GammaParticle(321300.0, 0.00386) }, { 0.027999999999999997d, new GammaParticle(359000.0, 0.00345) }, { 0.006999999999999999d, new GammaParticle(383600.0, 0.00323) }, { 0.151d, new GammaParticle(394800.0, 0.00314) }, { 0.1d, new GammaParticle(396200.0, 0.00313) }, { 0.017d, new GammaParticle(415100.0, 0.00299) }, { 0.026000000000000002d, new GammaParticle(452700.0, 0.00274) }, { 0.006d, new GammaParticle(458300.0, 0.00271) }, { 0.031d, new GammaParticle(585800.0, 0.00212) }, { 0.021d, new GammaParticle(594600.0, 0.00209) }, { 0.049d, new GammaParticle(612300.0, 0.00202) }, { 0.067d, new GammaParticle(632200.0, 0.00196) }, { 0.4d, new GammaParticle(668500.0, 0.00185) }, { 0.032d, new GammaParticle(688100.0, 0.0018) }, { 0.091d, new GammaParticle(780100.0, 0.00159) }, { 0.72d, new GammaParticle(791700.0, 0.00157) }, { 0.013999999999999999d, new GammaParticle(817400.0, 0.00152) }, { 0.009000000000000001d, new GammaParticle(843800.0, 0.00147) }, { 0.006d, new GammaParticle(862500.0, 0.00144) }, { 0.74d, new GammaParticle(911400.0, 0.00136) }, { 0.58d, new GammaParticle(989900.0, 0.00125) }, { 0.013000000000000001d, new GammaParticle(1091200.0, 0.00114) }, { 0.013999999999999999d, new GammaParticle(1138400.0, 0.00109) }, { 0.012d, new GammaParticle(1165300.0, 0.00106) }, { 0.013000000000000001d, new GammaParticle(1246100.0, 0.00099) }, { 0.015682986132d, new GammaParticle(2027.0, 0.61166) }, { 0.08584246506145815d, new GammaParticle(14883.0, 0.08331) }, { 0.164606836167705d, new GammaParticle(14958.0, 0.08289) }, { 0.041330737056974376d, new GammaParticle(16803.0, 0.07379) }, { 0.04703437877083684d, new GammaParticle(16880.0, 0.07345) }, { 0.005703641713862464d, new GammaParticle(17011.0, 0.07288) } } },
            { 0.052000000000000005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium97() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) }, { 0.037000000000000005d, new GammaParticle(161400.0, 0.00768) }, { 0.0029d, new GammaParticle(297000.0, 0.00417) }, { 0.02d, new GammaParticle(361200.0, 0.00343) }, { 0.015d, new GammaParticle(407200.0, 0.00304) }, { 0.02d, new GammaParticle(456800.0, 0.00271) }, { 0.02d, new GammaParticle(456800.0, 0.00271) }, { 0.0042d, new GammaParticle(542800.0, 0.00228) }, { 0.052000000000000005d, new GammaParticle(698200.0, 0.00178) }, { 0.032d, new GammaParticle(817900.0, 0.00152) }, { 0.052000000000000005d, new GammaParticle(840100.0, 0.00148) }, { 0.028999999999999998d, new GammaParticle(949600.0, 0.00131) }, { 0.023d, new GammaParticle(986100.0, 0.00126) }, { 0.033d, new GammaParticle(999500.0, 0.00124) }, { 0.04d, new GammaParticle(1103100.0, 0.00112) }, { 0.012d, new GammaParticle(1400100.0, 0.00089) }, { 0.00023469517878000002d, new GammaParticle(2161.0, 0.57374) }, { 0.0012989517783121723d, new GammaParticle(15691.0, 0.07902) }, { 0.0024860321116022435d, new GammaParticle(15775.0, 0.0786) }, { 0.0006334728709298297d, new GammaParticle(17736.0, 0.06991) }, { 0.0007259599100855849d, new GammaParticle(17824.0, 0.06956) }, { 9.248703915575513e-05d, new GammaParticle(17968.0, 0.069) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    