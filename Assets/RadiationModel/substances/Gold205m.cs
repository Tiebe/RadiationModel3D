using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold205m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold205m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 204.98104d;

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
    