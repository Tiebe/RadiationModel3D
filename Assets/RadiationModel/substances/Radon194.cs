using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon194 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon194";
        public override double halfLife { get; } = 0.00078d;
        public override double atomicWeight { get; } = 194.00615d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium190()), new(1.0d, new AlphaParticle(8885002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    