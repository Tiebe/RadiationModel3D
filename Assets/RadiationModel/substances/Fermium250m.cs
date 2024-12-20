using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fermium250m : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium250m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 250.08081d;

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
    