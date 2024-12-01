using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cerium130m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium130m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 129.91737d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    