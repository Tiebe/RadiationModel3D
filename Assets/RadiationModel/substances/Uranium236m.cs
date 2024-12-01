using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Uranium236m : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium236m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 236.0467d;

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
    