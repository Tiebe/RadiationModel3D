using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium217m : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium217m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 217.0115d;

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
    