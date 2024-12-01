using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thorium217n : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium217n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 217.01558d;

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
    