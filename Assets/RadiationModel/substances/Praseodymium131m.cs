using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Praseodymium131m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium131m";
        public override double halfLife { get; } = 5.73d;
        public override double atomicWeight { get; } = 130.9204d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9640000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Praseodymium131()), new(0.00318d, new GammaParticle(64800.0, 0.01913)), new(0.32899999999999996d, new GammaParticle(87600.0, 0.01415)), new(0.1697246421552d, new GammaParticle(5637.0, 0.21995)), new(0.1517446752724425d, new GammaParticle(35551.0, 0.03488)), new(0.2771086107970097d, new GammaParticle(36027.0, 0.03441)), new(0.08430244930776096d, new GammaParticle(40857.0, 0.03035)), new(0.10588387633054777d, new GammaParticle(41266.0, 0.03005)), new(0.021581427022786807d, new GammaParticle(41766.0, 0.02969)) } },
            { 0.036000000000000004d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lanthanum131()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    