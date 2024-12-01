using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine122n : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine122n";
        public override double halfLife { get; } = 8e-05d;
        public override double atomicWeight { get; } = 121.908d;

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
    