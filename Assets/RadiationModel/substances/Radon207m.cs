using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon207m : RadioactiveSubstance
    {
        public override string name { get; } = "Radon207m";
        public override double halfLife { get; } = 0.00018d;
        public override double atomicWeight { get; } = 206.9917d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon207()), new(0.21d, new GammaParticle(234000.0, 0.0053)), new(0.98d, new GammaParticle(665100.0, 0.00186)), new(0.3563252525504d, new GammaParticle(14088.0, 0.08801)), new(0.21550103015294333d, new GammaParticle(81070.0, 0.01529)), new(0.3554949359170956d, new GammaParticle(83789.0, 0.0148)), new(0.12328321994694022d, new GammaParticle(94878.0, 0.01307)), new(0.1627338503299611d, new GammaParticle(96054.0, 0.01291)), new(0.03945063038302087d, new GammaParticle(97530.0, 0.01271)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    