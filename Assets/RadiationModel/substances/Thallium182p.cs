using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium182p : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium182p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 181.98623d;

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
    