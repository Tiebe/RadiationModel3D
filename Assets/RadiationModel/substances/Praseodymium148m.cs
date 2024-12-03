using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Praseodymium148m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium148m";
        public override double halfLife { get; } = 120.6d;
        public override double atomicWeight { get; } = 147.92221d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.64d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium148()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.012d, new GammaParticle(247000.0, 0.00502)), new(0.61d, new GammaParticle(301702.0, 0.00411)), new(0.32d, new GammaParticle(450800.0, 0.00275)), new(0.26d, new GammaParticle(697520.0, 0.00178)), new(0.0102d, new GammaParticle(935000.0, 0.00133)), new(0.026000000000000002d, new GammaParticle(1106200.0, 0.00112)), new(0.031d, new GammaParticle(1556700.0, 0.0008)), new(0.0043951659584d, new GammaParticle(5870.0, 0.21122)), new(0.0076734083809935575d, new GammaParticle(36848.0, 0.03365)), new(0.013974518996528058d, new GammaParticle(37362.0, 0.03318)), new(0.004291697297118844d, new GammaParticle(42380.0, 0.02926)), new(0.005394663502478386d, new GammaParticle(42810.0, 0.02896)), new(0.0011029662053595429d, new GammaParticle(43335.0, 0.02861)) } },
            { 0.36d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Praseodymium148()), new(0.001d, new GammaParticle(76800.0, 0.01614)), new(0.038059296d, new GammaParticle(5637.0, 0.21995)), new(0.04357411456659609d, new GammaParticle(35551.0, 0.03488)), new(0.07957289000474084d, new GammaParticle(36027.0, 0.03441)), new(0.02420779890817125d, new GammaParticle(40857.0, 0.03035)), new(0.03040499542866309d, new GammaParticle(41266.0, 0.03005)), new(0.00619719652049184d, new GammaParticle(41766.0, 0.02969)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    