using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium136m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium136m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 135.93973d;

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
    