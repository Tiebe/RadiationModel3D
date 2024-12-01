using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium106 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium106";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 105.90348d;

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
    