using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium198p : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium198p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 197.97124d;

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
    