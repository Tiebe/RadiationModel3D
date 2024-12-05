using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium163";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 162.98246d;

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
    