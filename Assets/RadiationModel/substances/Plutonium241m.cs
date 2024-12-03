using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Plutonium241m : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium241m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 241.05702d;

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
    