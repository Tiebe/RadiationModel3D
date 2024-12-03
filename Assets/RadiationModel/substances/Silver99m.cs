using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver99m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver99m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 98.91819d;

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
    