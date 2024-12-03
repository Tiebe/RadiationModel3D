using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium188m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium188m";
        public override double halfLife { get; } = 1115.4d;
        public override double atomicWeight { get; } = 187.9583d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium188()), new(3.8e-13d, new GammaParticle(2636.0, 0.47035)), new(1.9800000000000002e-08d, new GammaParticle(15930.0, 0.07783)), new(0.223d, new GammaParticle(63583.0, 0.0195)), new(0.052000000000000005d, new GammaParticle(92464.0, 0.01341)), new(0.115d, new GammaParticle(105853.0, 0.01171)), new(0.0038d, new GammaParticle(156050.0, 0.00795)), new(0.0051d, new GammaParticle(169441.0, 0.00732)), new(0.4501169643395d, new GammaParticle(10063.0, 0.12321)), new(0.16808066032703414d, new GammaParticle(59718.0, 0.02076)), new(0.2907969901851802d, new GammaParticle(61141.0, 0.02028)), new(0.09666255911337954d, new GammaParticle(69395.0, 0.01787)), new(0.12343808798778566d, new GammaParticle(70206.0, 0.01766)), new(0.026775528874406134d, new GammaParticle(71195.0, 0.01741)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    