using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cadmium119m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium119m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 118.91d;

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
    