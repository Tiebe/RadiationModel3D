using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium207 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium207";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 207.01197d;

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
    