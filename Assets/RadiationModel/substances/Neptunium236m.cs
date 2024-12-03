using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neptunium236m : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium236m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 236.04663d;

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
    