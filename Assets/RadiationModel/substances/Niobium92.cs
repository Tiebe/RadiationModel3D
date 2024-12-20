using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium92 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium92";
        public override double halfLife { get; } = 1095025331318342.4d;
        public override double atomicWeight { get; } = 91.90719d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Yttrium92()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.9982800000000001d, new GammaParticle(561100.0, 0.00221)), new(0.7434000000000001d, new GammaParticle(934500.0, 0.00133)), new(0.032455027905106924d, new GammaParticle(2161.0, 0.57374)), new(0.17685093504483537d, new GammaParticle(15691.0, 0.07902)), new(0.3384706890810246d, new GammaParticle(15775.0, 0.0786)), new(0.08624667321757414d, new GammaParticle(17736.0, 0.06991)), new(0.09883868750733996d, new GammaParticle(17824.0, 0.06956)), new(0.012592014289765825d, new GammaParticle(17968.0, 0.069)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    