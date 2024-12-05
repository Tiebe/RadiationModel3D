using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fluorine24 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine24";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 24.00809d;

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
    