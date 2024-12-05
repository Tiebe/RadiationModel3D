using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium192m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium192m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 191.9938d;

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
    