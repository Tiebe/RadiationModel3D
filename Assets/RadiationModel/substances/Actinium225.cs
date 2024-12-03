using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium225 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium225";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 225.02323d;

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
    