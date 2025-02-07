using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neptunium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium233";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 233.04074d;

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
    