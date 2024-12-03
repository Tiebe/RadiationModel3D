using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bromine89 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine89";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 88.9267d;

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
    