using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Germanium74 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium74";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 73.92118d;

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
    