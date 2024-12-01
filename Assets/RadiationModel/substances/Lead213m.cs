using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead213m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead213m";
        public override double halfLife { get; } = 0.00026d;
        public override double atomicWeight { get; } = 212.99799d;

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
    