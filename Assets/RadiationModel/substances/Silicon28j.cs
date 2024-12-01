using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silicon28j : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon28j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 27.99327d;

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
    