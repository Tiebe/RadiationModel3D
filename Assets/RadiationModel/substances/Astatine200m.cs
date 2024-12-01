using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine200m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine200m";
        public override double halfLife { get; } = 47.0d;
        public override double atomicWeight { get; } = 199.99047d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.57d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth200()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.43d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth196()), new(1.0d, new AlphaParticle(7731002.09)), new(4.7e-06d, new GammaParticle(102000.0, 0.01216)), new(0.0055000000000000005d, new GammaParticle(158300.0, 0.00783)), new(0.126372352052175d, new GammaParticle(12904.0, 0.09608)), new(0.04858167783063643d, new GammaParticle(74815.0, 0.01657)), new(0.08128104037248858d, new GammaParticle(77108.0, 0.01608)), new(0.027841930395769526d, new GammaParticle(87388.0, 0.01419)), new(0.036361561096875d, new GammaParticle(88458.0, 0.01402)), new(0.008519630701105474d, new GammaParticle(89784.0, 0.01381)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    