using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium170m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium170m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 169.93858d;

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
    