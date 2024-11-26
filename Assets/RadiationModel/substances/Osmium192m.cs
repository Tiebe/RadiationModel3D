using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium192m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium192m";
        public override double halfLife { get; } = 5.9d;
        public override double atomicWeight { get; } = 191.96364d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.87d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium192() }, { 1.5250000000000001e-05d, new GammaParticle(47400.0, 0.02616) }, { 0.07136999999999999d, new GammaParticle(201311.2, 0.00616) }, { 0.61d, new GammaParticle(205794.3, 0.00602) }, { 0.0030499999999999998d, new GammaParticle(218488.0, 0.00567) }, { 0.017079999999999998d, new GammaParticle(233920.0, 0.0053) }, { 0.00488d, new GammaParticle(247500.0, 0.00501) }, { 0.07442d, new GammaParticle(283266.8, 0.00438) }, { 0.04758d, new GammaParticle(292478.0, 0.00424) }, { 0.4941d, new GammaParticle(302480.0, 0.0041) }, { 0.06588d, new GammaParticle(307020.0, 0.00404) }, { 0.012199999999999999d, new GammaParticle(322700.0, 0.00384) }, { 0.01586d, new GammaParticle(329310.0, 0.00376) }, { 0.2257d, new GammaParticle(374485.2, 0.00331) }, { 0.0183d, new GammaParticle(379154.0, 0.00327) }, { 0.06039d, new GammaParticle(420530.0, 0.00295) }, { 0.042699999999999995d, new GammaParticle(452200.0, 0.00274) }, { 0.5489999999999999d, new GammaParticle(453100.0, 0.00274) }, { 0.4697d, new GammaParticle(484575.1, 0.00256) }, { 0.12627d, new GammaParticle(489038.0, 0.00254) }, { 0.008539999999999999d, new GammaParticle(502500.0, 0.00247) }, { 0.122d, new GammaParticle(508970.0, 0.00244) }, { 0.013420000000000001d, new GammaParticle(555750.0, 0.00223) }, { 0.09028d, new GammaParticle(563320.0, 0.0022) }, { 0.6466d, new GammaParticle(569360.0, 0.00218) }, { 0.00976d, new GammaParticle(575500.0, 0.00215) }, { 0.0366d, new GammaParticle(580460.0, 0.00214) }, { 0.0915d, new GammaParticle(606000.0, 0.00205) }, { 0.1159d, new GammaParticle(619300.0, 0.002) }, { 0.012199999999999999d, new GammaParticle(624000.0, 0.00199) }, { 0.01403d, new GammaParticle(671800.0, 0.00185) }, { 0.00549d, new GammaParticle(703960.0, 0.00176) }, { 0.021349999999999997d, new GammaParticle(1000000.0, 0.00124) }, { 0.1677748100449036d, new GammaParticle(10393.0, 0.1193) }, { 0.08691297667080372d, new GammaParticle(61486.0, 0.02016) }, { 0.14977249124729228d, new GammaParticle(63000.0, 0.01968) }, { 0.05011075141078439d, new GammaParticle(71496.0, 0.01734) }, { 0.06414176180580401d, new GammaParticle(72338.0, 0.01714) }, { 0.01403101039501963d, new GammaParticle(73364.0, 0.0169) } } },
            { 0.13d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium192() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    