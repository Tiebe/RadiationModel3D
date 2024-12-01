using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tungsten174q : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten174q";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 173.94985d;

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
    