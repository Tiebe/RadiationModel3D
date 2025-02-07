using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium209m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium209m";
        public override double halfLife { get; } = 0.00012d;
        public override double atomicWeight { get; } = 209.00294d;

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
    