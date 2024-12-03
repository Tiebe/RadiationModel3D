using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth203m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth203m";
        public override double halfLife { get; } = 0.305d;
        public override double atomicWeight { get; } = 202.97807d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth203()), new(0.13699999999999998d, new GammaParticle(189500.0, 0.00654)), new(0.018000000000000002d, new GammaParticle(204700.0, 0.00606)), new(0.09d, new GammaParticle(893500.0, 0.00139)), new(0.8959999999999999d, new GammaParticle(908600.0, 0.00136)), new(0.000137d, new GammaParticle(1098100.0, 0.00113)), new(0.25d, new GammaParticle(12904.0, 0.09608)), new(0.0256d, new GammaParticle(74815.0, 0.01657)), new(0.0429d, new GammaParticle(77108.0, 0.01608)), new(0.0147d, new GammaParticle(87388.0, 0.01419)), new(0.0192d, new GammaParticle(88458.0, 0.01402)), new(0.0045000000000000005d, new GammaParticle(89784.0, 0.01381)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    