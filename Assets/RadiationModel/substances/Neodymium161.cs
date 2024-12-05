using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neodymium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium161";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 160.95466d;

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
    