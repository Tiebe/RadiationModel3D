using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Barium137m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium137m";
        public override double halfLife { get; } = 153.12d;
        public override double atomicWeight { get; } = 136.90654d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Barium137()), new(0.899d, new GammaParticle(661657.0, 0.00187)), new(0.009659496d, new GammaParticle(4966.0, 0.24967)), new(0.021012532500441276d, new GammaParticle(31816.0, 0.03897)), new(0.03871137159255946d, new GammaParticle(32193.0, 0.03851)), new(0.011386658072683124d, new GammaParticle(36482.0, 0.03399)), new(0.014256095906999272d, new GammaParticle(36827.0, 0.03367)), new(0.0028694378343161477d, new GammaParticle(37255.0, 0.03328)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    