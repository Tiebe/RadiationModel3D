using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hassium273p : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium273p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 273.14168d;

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
    