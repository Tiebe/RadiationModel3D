using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium149m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium149m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 148.91847d;

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
    