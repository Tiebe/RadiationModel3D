using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Potassium35i : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium35i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 34.99773d;

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
    