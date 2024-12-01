using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ytterbium185 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium185";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 184.96943d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    