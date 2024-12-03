using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium219m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium219m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 219.0101d;

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
    