using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ytterbium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium168";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 167.93389d;

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
    