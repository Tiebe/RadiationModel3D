using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium184m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium184m";
        public override double halfLife { get; } = 48.0d;
        public override double atomicWeight { get; } = 183.95681d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium184()), new(0.28d, new GammaParticle(72700.0, 0.01705)), new(0.27d, new GammaParticle(107100.0, 0.01158)), new(0.87d, new GammaParticle(242500.0, 0.00511)), new(0.96d, new GammaParticle(367600.0, 0.00337)), new(0.59d, new GammaParticle(482300.0, 0.00257)), new(0.36d, new GammaParticle(555000.0, 0.00223)), new(0.24463899499d, new GammaParticle(9114.0, 0.13604)), new(0.15457348693545828d, new GammaParticle(54608.0, 0.0227)), new(0.2705171279934517d, new GammaParticle(55786.0, 0.02222)), new(0.089245543465738d, new GammaParticle(63333.0, 0.01958)), new(0.11307410357109003d, new GammaParticle(64057.0, 0.01936)), new(0.023828560105352045d, new GammaParticle(64935.0, 0.01909)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    