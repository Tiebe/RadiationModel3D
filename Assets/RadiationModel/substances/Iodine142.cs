using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine142 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine142";
        public override double halfLife { get; } = 0.222d;
        public override double atomicWeight { get; } = 141.94117d;

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
    