using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Potassium52 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium52";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 51.9816d;

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
    