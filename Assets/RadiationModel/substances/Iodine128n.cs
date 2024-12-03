using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine128n : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine128n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 127.90599d;

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
    