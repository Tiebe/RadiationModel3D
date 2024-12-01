using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium173p : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium173p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 172.94395d;

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
    