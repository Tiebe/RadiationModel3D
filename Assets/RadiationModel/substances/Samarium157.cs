using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Samarium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium157";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 156.92842d;

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
    