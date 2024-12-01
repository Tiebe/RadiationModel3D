using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mendelevium253p : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium253p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 253.0872d;

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
    