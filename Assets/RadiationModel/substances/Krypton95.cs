using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Krypton95 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton95";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 94.93971d;

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
    