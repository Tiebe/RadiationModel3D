using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Titanium44 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium44";
        public override double halfLife { get; } = 1865014325.09839d;
        public override double atomicWeight { get; } = 43.95969d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Scandium44()), new(0.93d, new GammaParticle(67867.9, 0.01827)), new(0.968d, new GammaParticle(78323.4, 0.01583)), new(0.00092d, new GammaParticle(146220.0, 0.00848)), new(0.0045000000000000005d, new GammaParticle(422.0, 2.93801)), new(0.0574d, new GammaParticle(4086.0, 0.30344)), new(0.113d, new GammaParticle(4091.0, 0.30307)), new(0.0225d, new GammaParticle(4474.0, 0.27712)), new(0.0225d, new GammaParticle(4474.0, 0.27712)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    