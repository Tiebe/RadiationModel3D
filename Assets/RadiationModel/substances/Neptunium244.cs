using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neptunium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium244";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 244.06789d;

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
    