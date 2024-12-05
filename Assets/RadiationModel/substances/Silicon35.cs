using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silicon35 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon35";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 34.98455d;

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
    