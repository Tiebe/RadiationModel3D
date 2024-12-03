using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium148m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium148m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 147.93801d;

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
    