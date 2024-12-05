using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Germanium79m : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium79m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 78.92556d;

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
    