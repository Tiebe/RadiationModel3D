using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium122 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium122";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 121.90304d;

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
    