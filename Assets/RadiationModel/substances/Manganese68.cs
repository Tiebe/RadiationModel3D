using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Manganese68 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese68";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 67.96895d;

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
    