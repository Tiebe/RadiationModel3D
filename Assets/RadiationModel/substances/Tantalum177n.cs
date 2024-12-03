using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum177n : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum177n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 176.94468d;

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
    