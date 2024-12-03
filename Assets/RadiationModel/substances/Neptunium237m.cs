using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neptunium237m : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium237m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 237.04919d;

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
    