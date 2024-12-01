using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium212 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium212";
        public override double halfLife { get; } = 13.0d;
        public override double atomicWeight { get; } = 211.99979d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.85d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon208()), new(1.0d, new AlphaParticle(8053002.09)), new(0.00042500000000000003d, new GammaParticle(635100.0, 0.00195)), new(2.936433528e-06d, new GammaParticle(14088.0, 0.08801)), new(1.7840335650230843e-06d, new GammaParticle(81070.0, 0.01529)), new(2.9429784972337255e-06d, new GammaParticle(83789.0, 0.0148)), new(1.0206048770781748e-06d, new GammaParticle(94878.0, 0.01307)), new(1.3471984377431907e-06d, new GammaParticle(96054.0, 0.01291)), new(3.2659356066501585e-07d, new GammaParticle(97530.0, 0.01271)) } },
            { 0.15d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon212()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    