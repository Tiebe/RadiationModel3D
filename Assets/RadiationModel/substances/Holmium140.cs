using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium140";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 139.96852d;

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
    