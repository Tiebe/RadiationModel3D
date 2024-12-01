using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iron54m : RadioactiveSubstance
    {
        public override string name { get; } = "Iron54m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 53.94662d;

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
    