using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zirconium90m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium90m";
        public override double halfLife { get; } = 0.8092d;
        public override double atomicWeight { get; } = 89.90719d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zirconium90()), new(0.041328d, new GammaParticle(132716.0, 0.00934)), new(4.9199999999999997e-05d, new GammaParticle(425500.0, 0.00291)), new(0.17958d, new GammaParticle(2186242.0, 0.00057)), new(0.82d, new GammaParticle(2318959.0, 0.00053)), new(0.003917907397588317d, new GammaParticle(2161.0, 0.57374)), new(0.019292556493998133d, new GammaParticle(15691.0, 0.07902)), new(0.03692355309856102d, new GammaParticle(15775.0, 0.0786)), new(0.009408594956241577d, new GammaParticle(17736.0, 0.06991)), new(0.010782249819852844d, new GammaParticle(17824.0, 0.06956)), new(0.00137365486361127d, new GammaParticle(17968.0, 0.069)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    