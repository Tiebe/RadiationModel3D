using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neodymium134m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium134m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 133.92125d;

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
    