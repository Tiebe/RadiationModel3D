using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium171m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium171m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 170.97182d;

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
    