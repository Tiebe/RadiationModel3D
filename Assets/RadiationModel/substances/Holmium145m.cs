using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium145m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium145m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 144.94737d;

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
    