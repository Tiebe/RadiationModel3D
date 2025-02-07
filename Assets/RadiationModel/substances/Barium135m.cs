using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Barium135m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium135m";
        public override double halfLife { get; } = 103320.0d;
        public override double atomicWeight { get; } = 134.90598d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Barium135()), new(0.16d, new GammaParticle(268218.0, 0.00462)), new(0.07927568d, new GammaParticle(4966.0, 0.24967)), new(0.15363177655432125d, new GammaParticle(31816.0, 0.03897)), new(0.2830356974103192d, new GammaParticle(32193.0, 0.03851)), new(0.08325281632217224d, new GammaParticle(36482.0, 0.03399)), new(0.10423252603535965d, new GammaParticle(36827.0, 0.03367)), new(0.020979709713187408d, new GammaParticle(37255.0, 0.03328)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    