using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gallium72m : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium72m";
        public override double halfLife { get; } = 0.03968d;
        public override double atomicWeight { get; } = 71.9265d;

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
    