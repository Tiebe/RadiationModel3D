using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum179p : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum179p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 178.94728d;

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
    