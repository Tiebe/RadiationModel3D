using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tin119p : RadioactiveSubstance
    {
        public override string name { get; } = "Tin119p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 118.90585d;

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
    