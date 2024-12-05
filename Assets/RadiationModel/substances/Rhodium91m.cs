using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhodium91m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium91m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 90.93731d;

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
    