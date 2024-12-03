using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Barium127m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium127m";
        public override double halfLife { get; } = 1.93d;
        public override double atomicWeight { get; } = 126.91118d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Barium127()), new(0.000945d, new GammaParticle(24200.0, 0.05123)), new(0.09d, new GammaParticle(56200.0, 0.02206)), new(0.000549d, new GammaParticle(80200.0, 0.01546)), new(0.16771250826d, new GammaParticle(4966.0, 0.24967)), new(0.11668109755749141d, new GammaParticle(31816.0, 0.03897)), new(0.2149614914471102d, new GammaParticle(32193.0, 0.03851)), new(0.0632293019132575d, new GammaParticle(36482.0, 0.03399)), new(0.0791630859953984d, new GammaParticle(36827.0, 0.03367)), new(0.01593378408214089d, new GammaParticle(37255.0, 0.03328)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    