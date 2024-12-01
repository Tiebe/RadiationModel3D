using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Argon38i : RadioactiveSubstance
    {
        public override string name { get; } = "Argon38i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 37.97414d;

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
    