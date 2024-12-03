using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ruthenium93n : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium93n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 92.91934d;

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
    