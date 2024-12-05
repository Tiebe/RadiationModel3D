using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fluorine18i : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine18i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 18.00206d;

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
    