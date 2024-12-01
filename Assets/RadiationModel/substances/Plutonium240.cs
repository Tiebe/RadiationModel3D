using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Plutonium240 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium240";
        public override double halfLife { get; } = 207044991319.29813d;
        public override double atomicWeight { get; } = 240.05381d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Uranium236()), new(1.0d, new AlphaParticle(6277702.09)), new(0.00043200000000000004d, new GammaParticle(45243.0, 0.0274)), new(7.14e-05d, new GammaParticle(104237.0, 0.01189)), new(4.058e-06d, new GammaParticle(160308.0, 0.00773)), new(1.08e-08d, new GammaParticle(212470.0, 0.00584)), new(1.42e-09d, new GammaParticle(538090.0, 0.0023)), new(1.248e-07d, new GammaParticle(642230.0, 0.00193)), new(3.42e-08d, new GammaParticle(687590.0, 0.0018)), new(2.4999999999999996e-10d, new GammaParticle(699000.0, 0.00177)), new(5.8e-09d, new GammaParticle(873980.0, 0.00142)), new(9.999999999999999e-10d, new GammaParticle(958000.0, 0.00129)), new(4.999999999999999e-10d, new GammaParticle(960000.0, 0.00129)), new(4.999999999999999e-10d, new GammaParticle(967000.0, 0.00128)), new(0.09300000000000001d, new GammaParticle(16678.0, 0.07434)), new(2.4899999999999997e-07d, new GammaParticle(94657.0, 0.0131)), new(3.99e-07d, new GammaParticle(98439.0, 0.0126)), new(1.44e-07d, new GammaParticle(111238.0, 0.01115)), new(1.9300000000000002e-07d, new GammaParticle(112645.0, 0.01101)), new(4.9200000000000004e-08d, new GammaParticle(114446.0, 0.01083)) } },
            { 5.6999999999999994e-08d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 1.3e-13d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    