using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zirconium99m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium99m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 98.91695d;

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
    