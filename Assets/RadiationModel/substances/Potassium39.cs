using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Potassium39 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium39";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 38.96371d;

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
    