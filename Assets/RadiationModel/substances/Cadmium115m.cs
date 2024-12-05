using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cadmium115m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium115m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 114.90563d;

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
    