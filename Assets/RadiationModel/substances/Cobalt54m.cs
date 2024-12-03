using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cobalt54m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt54m";
        public override double halfLife { get; } = 88.8d;
        public override double atomicWeight { get; } = 53.94867d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Manganese54()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.97d, new GammaParticle(411000.0, 0.00302)), new(0.98d, new GammaParticle(1130000.0, 0.0011)), new(1.0d, new GammaParticle(1407000.0, 0.00088)), new(1.99116d, new GammaParticle(511000.0, 0.00243)), new(5.6755656228e-05d, new GammaParticle(728.0, 1.70308)), new(0.0006726527422291712d, new GammaParticle(6391.0, 0.194)), new(0.0013171191349699845d, new GammaParticle(6404.0, 0.1936)), new(0.00027220079280084445d, new GammaParticle(7082.0, 0.17507)), new(0.00027220079280084445d, new GammaParticle(7082.0, 0.17507)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    