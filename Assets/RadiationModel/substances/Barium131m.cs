using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Barium131m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium131m";
        public override double halfLife { get; } = 876.0d;
        public override double atomicWeight { get; } = 130.90715d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Barium131()), new(0.013305599999999999d, new GammaParticle(79050.0, 0.01568)), new(0.5544d, new GammaParticle(108450.0, 0.01143)), new(0.1364783865984d, new GammaParticle(4966.0, 0.24967)), new(0.13749631931023054d, new GammaParticle(31816.0, 0.03897)), new(0.25330935760912043d, new GammaParticle(32193.0, 0.03851)), new(0.07450903760435229d, new GammaParticle(36482.0, 0.03399)), new(0.09328531508064908d, new GammaParticle(36827.0, 0.03367)), new(0.018776277476296777d, new GammaParticle(37255.0, 0.03328)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    