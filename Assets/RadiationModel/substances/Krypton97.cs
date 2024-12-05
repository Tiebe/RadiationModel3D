using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Krypton97 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton97";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 96.94909d;

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
    