using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lithium12 : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium12";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 12.05261d;

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
    