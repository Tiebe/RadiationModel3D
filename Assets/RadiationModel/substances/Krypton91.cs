using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Krypton91 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton91";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 90.92381d;

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
    