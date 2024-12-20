using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium86m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium86m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 85.92595d;

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
    