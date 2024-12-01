using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium165";
        public override double halfLife { get; } = 644.4d;
        public override double atomicWeight { get; } = 164.93941d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium165()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.012d, new GammaParticle(511000.0, 0.00243)), new(0.0024d, new GammaParticle(8502.0, 0.14583)), new(0.003d, new GammaParticle(51354.0, 0.02414)), new(0.005d, new GammaParticle(52389.0, 0.02367)), new(0.0016d, new GammaParticle(59481.0, 0.02084)), new(0.002d, new GammaParticle(60151.0, 0.02061)), new(0.0004d, new GammaParticle(60961.0, 0.02034)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    