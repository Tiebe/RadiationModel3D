using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver118n : RadioactiveSubstance
    {
        public override string name { get; } = "Silver118n";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 117.91473d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.59d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium118() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) }, { 0.035d, new GammaParticle(246200.0, 0.00504) }, { 0.027999999999999997d, new GammaParticle(275800.0, 0.0045) }, { 0.033d, new GammaParticle(294200.0, 0.00421) }, { 0.027999999999999997d, new GammaParticle(391300.0, 0.00317) }, { 0.033d, new GammaParticle(397670.0, 0.00312) }, { 0.006999999999999999d, new GammaParticle(406540.0, 0.00305) }, { 0.023d, new GammaParticle(410900.0, 0.00302) }, { 0.011899999999999999d, new GammaParticle(433600.0, 0.00286) }, { 0.57d, new GammaParticle(487770.0, 0.00254) }, { 0.040999999999999995d, new GammaParticle(532700.0, 0.00233) }, { 0.00208d, new GammaParticle(646200.0, 0.00192) }, { 0.07d, new GammaParticle(659630.0, 0.00188) }, { 0.56d, new GammaParticle(677130.0, 0.00183) }, { 0.043d, new GammaParticle(704600.0, 0.00176) }, { 0.042d, new GammaParticle(764230.0, 0.00162) }, { 0.19d, new GammaParticle(771000.0, 0.00161) }, { 0.021d, new GammaParticle(781730.0, 0.00159) }, { 0.067d, new GammaParticle(808500.0, 0.00153) }, { 0.03d, new GammaParticle(849700.0, 0.00146) }, { 0.3d, new GammaParticle(1058390.0, 0.00117) }, { 0.045d, new GammaParticle(1157400.0, 0.00107) }, { 0.016d, new GammaParticle(1269540.0, 0.00098) }, { 0.027000000000000003d, new GammaParticle(1336800.0, 0.00093) }, { 0.0049d, new GammaParticle(1428020.0, 0.00087) }, { 0.034d, new GammaParticle(1441340.0, 0.00086) }, { 0.035d, new GammaParticle(2016900.0, 0.00061) }, { 0.21d, new GammaParticle(2100800.0, 0.00059) }, { 0.10400000000000001d, new GammaParticle(2164000.0, 0.00057) }, { 0.065d, new GammaParticle(2693800.0, 0.00046) }, { 0.213d, new GammaParticle(2777800.0, 0.00045) }, { 0.052000000000000005d, new GammaParticle(2894000.0, 0.00043) }, { 8e-08d, new GammaParticle(3388.0, 0.36595) }, { 3e-07d, new GammaParticle(22983.0, 0.05395) }, { 5e-07d, new GammaParticle(23173.0, 0.0535) }, { 1.5e-07d, new GammaParticle(26184.0, 0.04735) }, { 1.8e-07d, new GammaParticle(26381.0, 0.047) }, { 3.0000000000000004e-08d, new GammaParticle(26641.0, 0.04654) } } },
            { 0.41d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver118() }, { 0.07200000000000001d, new GammaParticle(127740.0, 0.00971) }, { 0.017670049056d, new GammaParticle(3218.0, 0.38528) }, { 0.04772083459822105d, new GammaParticle(21990.0, 0.05638) }, { 0.08995444787600576d, new GammaParticle(22163.0, 0.05594) }, { 0.024919929749380922d, new GammaParticle(25030.0, 0.04953) }, { 0.0292559975257732d, new GammaParticle(25211.0, 0.04918) }, { 0.00433606777639228d, new GammaParticle(25454.0, 0.04871) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    