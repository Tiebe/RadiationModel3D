using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nickel60 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel60";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 59.93079d;

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
    