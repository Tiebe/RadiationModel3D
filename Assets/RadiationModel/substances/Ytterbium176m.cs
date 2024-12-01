using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ytterbium176m : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium176m";
        public override double halfLife { get; } = 11.4d;
        public override double atomicWeight { get; } = 175.9437d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium176()), new(0.13949999999999999d, new GammaParticle(82100.0, 0.0151)), new(0.7347d, new GammaParticle(96000.0, 0.01292)), new(0.8184d, new GammaParticle(190100.0, 0.00652)), new(0.93d, new GammaParticle(292900.0, 0.00423)), new(0.9114d, new GammaParticle(389300.0, 0.00318)), new(0.30788040652824d, new GammaParticle(8502.0, 0.14583)), new(0.1823499728135406d, new GammaParticle(51354.0, 0.02414)), new(0.3214348189909053d, new GammaParticle(52389.0, 0.02367)), new(0.10551115266895651d, new GammaParticle(59481.0, 0.02084)), new(0.13304956351555414d, new GammaParticle(60151.0, 0.02061)), new(0.02753841084659765d, new GammaParticle(60961.0, 0.02034)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    