using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hydrogen7 : RadioactiveSubstance
    {
        public override string name { get; } = "Hydrogen7";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 7.05275d;

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
    