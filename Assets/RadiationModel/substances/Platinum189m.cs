using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum189m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum189m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 188.96103d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum189()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    