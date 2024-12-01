using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium177m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium177m";
        public override double halfLife { get; } = 1.09d;
        public override double atomicWeight { get; } = 176.94464d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium177()), new(0.001904d, new GammaParticle(14050.0, 0.08824)), new(0.02529d, new GammaParticle(55150.0, 0.02248)), new(0.000128d, new GammaParticle(69200.0, 0.01792)), new(0.01133d, new GammaParticle(71641.8, 0.01731)), new(0.0005600000000000001d, new GammaParticle(88400.0, 0.01403)), new(0.16399999999999998d, new GammaParticle(105358.9, 0.01177)), new(0.276d, new GammaParticle(112949.8, 0.01098)), new(0.00251d, new GammaParticle(117144.2, 0.01058)), new(0.2075d, new GammaParticle(128502.7, 0.00965)), new(0.018779999999999998d, new GammaParticle(136724.5, 0.00907)), new(0.01248d, new GammaParticle(145769.3, 0.00851)), new(0.214d, new GammaParticle(153284.2, 0.00809)), new(0.0069d, new GammaParticle(159734.1, 0.00776)), new(0.16140000000000002d, new GammaParticle(174398.8, 0.00711)), new(0.046900000000000004d, new GammaParticle(177000.7, 0.007)), new(0.00126d, new GammaParticle(181909.3, 0.00682)), new(0.00161d, new GammaParticle(203000.0, 0.00611)), new(0.1748d, new GammaParticle(204105.0, 0.00607)), new(0.7170000000000001d, new GammaParticle(208366.2, 0.00595)), new(0.08310000000000001d, new GammaParticle(214434.1, 0.00578)), new(0.000167d, new GammaParticle(223300.0, 0.00555)), new(0.46399999999999997d, new GammaParticle(228483.8, 0.00543)), new(0.0602d, new GammaParticle(233861.5, 0.0053)), new(0.00075d, new GammaParticle(242100.0, 0.00512)), new(0.08070000000000001d, new GammaParticle(249674.2, 0.00497)), new(0.1807d, new GammaParticle(281786.8, 0.0044)), new(0.0053300000000000005d, new GammaParticle(283609.0, 0.00437)), new(0.013300000000000001d, new GammaParticle(291542.9, 0.00425)), new(0.0105d, new GammaParticle(292526.6, 0.00424)), new(0.06480000000000001d, new GammaParticle(296458.4, 0.00418)), new(0.021099999999999997d, new GammaParticle(299053.4, 0.00415)), new(0.02327d, new GammaParticle(305503.3, 0.00406)), new(0.01697d, new GammaParticle(313725.0, 0.00395)), new(0.01506d, new GammaParticle(321315.9, 0.00386)), new(0.23850000000000002d, new GammaParticle(327682.9, 0.00378)), new(0.022799999999999997d, new GammaParticle(341643.2, 0.00363)), new(0.38d, new GammaParticle(378503.6, 0.00328)), new(0.040999999999999995d, new GammaParticle(385030.4, 0.00322)), new(0.2809d, new GammaParticle(418538.8, 0.00296)), new(0.0062d, new GammaParticle(426472.6, 0.00291)), new(0.032d, new GammaParticle(465841.6, 0.00266)), new(0.5743303342306401d, new GammaParticle(9114.0, 0.13604)), new(0.42703491246825037d, new GammaParticle(54608.0, 0.0227)), new(0.7473484642426503d, new GammaParticle(55786.0, 0.02222)), new(0.24655562604980233d, new GammaParticle(63333.0, 0.01958)), new(0.3123859782050995d, new GammaParticle(64057.0, 0.01936)), new(0.06583035215529721d, new GammaParticle(64935.0, 0.01909)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    