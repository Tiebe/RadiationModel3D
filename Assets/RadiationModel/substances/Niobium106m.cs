using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium106m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium106m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 105.92904d;

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
    