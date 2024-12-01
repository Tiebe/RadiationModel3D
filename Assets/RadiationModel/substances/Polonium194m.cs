using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium194m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium194m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 193.99067d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium194()), new(0.121d, new GammaParticle(209400.0, 0.00592)), new(0.156d, new GammaParticle(248000.0, 0.005)), new(0.061d, new GammaParticle(296800.0, 0.00418)), new(0.865d, new GammaParticle(319300.0, 0.00388)), new(0.10400000000000001d, new GammaParticle(340100.0, 0.00365)), new(0.121d, new GammaParticle(358800.0, 0.00346)), new(0.10400000000000001d, new GammaParticle(362200.0, 0.00342)), new(0.69d, new GammaParticle(366100.0, 0.00339)), new(0.355d, new GammaParticle(373300.0, 0.00332)), new(0.0208d, new GammaParticle(421000.0, 0.00294)), new(0.069d, new GammaParticle(434100.0, 0.00286)), new(0.061d, new GammaParticle(438400.0, 0.00283)), new(0.061d, new GammaParticle(453000.0, 0.00274)), new(0.225d, new GammaParticle(458800.0, 0.0027)), new(0.64d, new GammaParticle(461600.0, 0.00269)), new(0.052000000000000005d, new GammaParticle(493600.0, 0.00251)), new(0.052000000000000005d, new GammaParticle(524900.0, 0.00236)), new(0.303d, new GammaParticle(545000.0, 0.00227)), new(0.019d, new GammaParticle(622000.0, 0.00199)), new(0.043d, new GammaParticle(757600.0, 0.00164)), new(0.061d, new GammaParticle(802000.0, 0.00155)), new(0.138d, new GammaParticle(918500.0, 0.00135)), new(0.027000000000000003d, new GammaParticle(958700.0, 0.00129)), new(0.272d, new GammaParticle(13292.0, 0.09328)), new(0.172d, new GammaParticle(76862.0, 0.01613)), new(0.287d, new GammaParticle(79290.0, 0.01564)), new(0.099d, new GammaParticle(89837.0, 0.0138)), new(0.129d, new GammaParticle(90941.0, 0.01363)), new(0.030699999999999998d, new GammaParticle(92315.0, 0.01343)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    