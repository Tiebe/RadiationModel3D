using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bohrium264p : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium264p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 264.12484d;

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
    