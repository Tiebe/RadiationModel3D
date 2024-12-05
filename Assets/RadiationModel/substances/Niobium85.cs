using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium85 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium85";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 84.92885d;

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
    