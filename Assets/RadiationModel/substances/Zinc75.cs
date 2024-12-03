using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zinc75 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc75";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 74.93284d;

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
    