using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Praseodymium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium157";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 156.948d;

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
    