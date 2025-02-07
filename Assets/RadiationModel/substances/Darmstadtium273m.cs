using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Darmstadtium273m : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium273m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 273.14868d;

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
    