using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Phosphorus26m : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus26m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 26.01195d;

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
    