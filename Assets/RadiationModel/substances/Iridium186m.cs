using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium186m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium186m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 185.95795d;

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
    