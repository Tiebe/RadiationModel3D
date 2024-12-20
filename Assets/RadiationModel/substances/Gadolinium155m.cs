using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gadolinium155m : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium155m";
        public override double halfLife { get; } = 0.03197d;
        public override double atomicWeight { get; } = 154.92276d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium155()), new(0.0735d, new GammaParticle(13470.0, 0.09204)), new(0.00038449999999999997d, new GammaParticle(21036.0, 0.05894)), new(0.6988d, new GammaParticle(86545.0, 0.01433)), new(0.3085475712d, new GammaParticle(6858.0, 0.18079)), new(0.06666367434737311d, new GammaParticle(42308.0, 0.02931)), new(0.11992026326204913d, new GammaParticle(42996.0, 0.02884)), new(0.03790771052302277d, new GammaParticle(48802.0, 0.02541)), new(0.04787743839057775d, new GammaParticle(49326.0, 0.02514)), new(0.009969727867554987d, new GammaParticle(49957.0, 0.02482)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    