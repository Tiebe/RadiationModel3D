using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bromine69m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine69m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 68.95038d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Selenium68()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    