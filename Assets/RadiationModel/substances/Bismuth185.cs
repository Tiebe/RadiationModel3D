using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth185 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth185";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 184.9976d;

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
    