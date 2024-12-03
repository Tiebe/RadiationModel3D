using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium181m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium181m";
        public override double halfLife { get; } = 162.0d;
        public override double atomicWeight { get; } = 180.9533d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten181()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.28300000000000003d, new GammaParticle(118090.0, 0.0105)), new(1.0d, new GammaParticle(144840.0, 0.00856)), new(0.008d, new GammaParticle(163000.0, 0.00761)), new(0.002d, new GammaParticle(221000.0, 0.00561)), new(0.01d, new GammaParticle(238000.0, 0.00521)), new(0.002d, new GammaParticle(253000.0, 0.0049)), new(0.005d, new GammaParticle(263000.0, 0.00471)), new(0.004d, new GammaParticle(666000.0, 0.00186)), new(0.042d, new GammaParticle(1118800.0, 0.00111)), new(0.008d, new GammaParticle(1207000.0, 0.00103)), new(0.004d, new GammaParticle(1428000.0, 0.00087)), new(0.013000000000000001d, new GammaParticle(1468000.0, 0.00084)), new(0.094d, new GammaParticle(511000.0, 0.00243)), new(0.2565778607d, new GammaParticle(10063.0, 0.12321)), new(0.23954789596111226d, new GammaParticle(59718.0, 0.02076)), new(0.41444272657631875d, new GammaParticle(61141.0, 0.02028)), new(0.13776309903098588d, new GammaParticle(69395.0, 0.01787)), new(0.17592347746256898d, new GammaParticle(70206.0, 0.01766)), new(0.0381603784315831d, new GammaParticle(71195.0, 0.01741)) } },
            { 0.03d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium181()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    