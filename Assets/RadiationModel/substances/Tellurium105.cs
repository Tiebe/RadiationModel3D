using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium105 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium105";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 104.94331d;

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
    