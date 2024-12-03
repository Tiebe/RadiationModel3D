using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Americium244m : RadioactiveSubstance
    {
        public override string name { get; } = "Americium244m";
        public override double halfLife { get; } = 1560.0d;
        public override double atomicWeight { get; } = 244.06438d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.999636d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium244()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.000252d, new GammaParticle(42965.0, 0.02886)), new(0.0034649999999999998d, new GammaParticle(941949.0, 0.00132)), new(0.00189d, new GammaParticle(1041278.0, 0.00119)), new(0.0027300000000000002d, new GammaParticle(1062953.0, 0.00117)), new(0.00357d, new GammaParticle(1084181.0, 0.00114)), new(0.00042d, new GammaParticle(1105430.0, 0.00112)), new(0.10312579898712d, new GammaParticle(18579.0, 0.06673)), new(4.7187710059721924e-05d, new GammaParticle(104606.0, 0.01185)), new(7.388086748038504e-05d, new GammaParticle(109286.0, 0.01134)), new(2.7670259215897226e-05d, new GammaParticle(123280.0, 0.01006)), new(3.741019045989305e-05d, new GammaParticle(124855.0, 0.00993)), new(9.739931243995824e-06d, new GammaParticle(126917.0, 0.00977)) } },
            { 0.000364d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium244()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    