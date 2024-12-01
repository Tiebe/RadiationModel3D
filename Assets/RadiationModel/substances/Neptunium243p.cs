using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neptunium243p : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium243p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 243.06433d;

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
    